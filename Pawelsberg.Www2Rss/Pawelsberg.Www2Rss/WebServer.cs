using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Pawelsberg.Www2Rss
{
    abstract public class WebServer
    {

        private ushort _Port;
        public ushort Port
        {
            get { return _Port; }
        }

        private bool _Localonly;
        public bool Localonly
        {
            get { return _Localonly; }
        }

        private string _Server;
        public string Server
        {
            get { return _Server; }
        }

        private bool _running;
        private TcpListener _listener;
        private object _syncRoot = new object();

        public WebServer(ushort port, bool localonly, string server)
        {
            _Port = port;
            _Localonly = localonly;
            _Server = server;
            _running = false;
        }

        protected abstract byte[] GetFileContent(string fileName);

        public void Start()
        {
            lock (_syncRoot)
            {
                if (_running)
                    Stop();
                _listener = new TcpListener(IPAddress.Any, _Port);
                _listener.Start();
                _listener.BeginAcceptSocket(new AsyncCallback(beginAcceptSocket), this);
                _running = true;
            }
        }
        public void Stop()
        {
            lock (_syncRoot)
            {
                if (!_running)
                    return;
                _running = false;
                _listener.Stop();
            }
        }

        private static void sendResponse(string data, Socket socket)
        {
            socket.Send(Encoding.ASCII.GetBytes(data));
        }
        private static bool containsHeaderStop(string data)
        {
            return data.Contains("\r\n\r\n") || data.Contains("\n\n");
        }
        private static string receiveRequest(Socket socket)
        {
            StringBuilder requestBuilder = new StringBuilder();

            // receive until header stop occurs or socket will be disconnected
            while (!containsHeaderStop(requestBuilder.ToString()) && socket.Connected)
            {
                // receive data from the client to the bufor
                byte[] receiveBufor = new byte[1024];
                int receivedBytesCount = socket.Receive(receiveBufor, receiveBufor.Length, 0);

                // append receiving result (request header part)
                requestBuilder.Append(Encoding.ASCII.GetString(receiveBufor, 0, receivedBytesCount));
            }

            return requestBuilder.ToString();
        }
        private static string buildResponseHeader(string httpVersion, string MIMEHeader, int responseSize, string statusCode, string server)
        {
            StringBuilder responseHeaderBuilder = new StringBuilder();

            // if Mime type is not provided set default to text/html
            if (MIMEHeader.Length == 0)
                MIMEHeader = "text/html";

            responseHeaderBuilder.Append(httpVersion);
            responseHeaderBuilder.Append(" ");
            responseHeaderBuilder.Append(statusCode);
            responseHeaderBuilder.Append("\r\n");

            // include server information only if provided
            // From RFC-2616:
            //      Revealing the specific software version of the server might
            //allow the server machine to become more vulnerable to attacks
            //against software that is known to contain security holes.
            if (server != null && server != "")
            {
                responseHeaderBuilder.Append("Server: ");
                responseHeaderBuilder.Append(server);
                responseHeaderBuilder.Append("\r\n");
            }

            responseHeaderBuilder.Append("Content-Type: ");
            responseHeaderBuilder.Append(MIMEHeader);
            responseHeaderBuilder.Append("\r\n");

            responseHeaderBuilder.Append("Accept-Ranges: bytes\r\n");

            responseHeaderBuilder.Append("Content-Length: ");
            responseHeaderBuilder.Append(responseSize);
            responseHeaderBuilder.Append("\r\n\r\n");

            return responseHeaderBuilder.ToString();
        }
        private static void sendHeader(string httpVersion, string mimeHeader, int responseSize, string statusCode, string server, Socket socket)
        {
            string header = buildResponseHeader(httpVersion, mimeHeader, responseSize, statusCode, server);
            sendResponse(header, socket);
        }

        private static void beginAcceptSocket(IAsyncResult asyncResult)
        {
            // TODO - lock when accessing ws object

            // Get the listener that handles the client request.
            WebServer ws = (WebServer)asyncResult.AsyncState;
            Socket socket;
            string wsServer;

            lock (ws._syncRoot)
            {
                if (!ws._running) return;

                //Accept a new connections
                socket = ws._listener.EndAcceptSocket(asyncResult);
                ws._listener.BeginAcceptSocket(new AsyncCallback(beginAcceptSocket), ws);


                //If _localonly and not localhost - reject
                if (ws._Localonly)
                    if (!((IPEndPoint)socket.RemoteEndPoint).Address.Equals(IPAddress.Loopback))
                        return;

                wsServer = ws._Server;
            }


            if (socket.Connected)
            {
                string sBuffer = receiveRequest(socket);

                //At present we will only deal with GET type
                if (sBuffer.Substring(0, 3) != "GET")
                {
                    socket.Close();
                    return;
                }

                // Look for HTTP request
                int iStartPos = sBuffer.IndexOf("HTTP", 1);

                // Get the HTTP text and version e.g. it will return "HTTP/1.1"
                string sHttpVersion = sBuffer.Substring(iStartPos, 8);

                // Extract the Requested Type and Requested _file/directory
                string sRequest = sBuffer.Substring(0, iStartPos - 1);

                //If file does not exist dispaly error message
                byte[] content;
                try
                {
                    content = ws.GetFileContent(sRequest.Substring(5));
                }
                catch
                {
                    string sErrorMessage = "<H2>Error!! Requested file does not exists</H2><Br>";

                    //Format the message
                    sendHeader(sHttpVersion, "", sErrorMessage.Length, "404 Not Found", wsServer, socket);

                    //Send response to the browser
                    sendResponse(sErrorMessage, socket);

                    socket.Close();
                    return;
                }

                string sMimeType = "application/xhtml+xml";
                {
                    sendHeader(sHttpVersion, sMimeType, content.Length, "200 OK", wsServer, socket);
                    socket.Send(content);
                }
                socket.Close();
            }
        }
    }
}
