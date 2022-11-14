namespace Pawelsberg.Www2Rss;

public class RssWebServer : WebServer
{
    public FeedList Feeds { get; } = new();

    public RssWebServer(ushort port, bool localonly, string server)
        : base(port, localonly, server)
    {
    }

    protected override byte[] GetFileContent(string fileName) => Feeds.GetFileContent(fileName);
}