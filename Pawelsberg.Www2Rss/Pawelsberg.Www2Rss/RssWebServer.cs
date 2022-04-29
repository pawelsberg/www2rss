using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pawelsberg.Www2Rss
{
    public class RssWebServer : WebServer
    {
        private FeedList _Feeds = new FeedList();
        public FeedList Feeds
        {
            get { return _Feeds; }
        }

        public RssWebServer(ushort port, bool localonly, string server)
            : base(port, localonly, server)
        {
        }

        protected override byte[] GetFileContent(string fileName)
        {
            return _Feeds.GetFileContent(fileName);
        }

    }
}
