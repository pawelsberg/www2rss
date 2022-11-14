using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using System.Web;

namespace Pawelsberg.Www2Rss;

public class Feed : ICloneable
{
    public string SourceURL { get; set; }

    public string SourceEncoding { get; set; }

    public string GetSourceCode()
    {
        try
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(SourceURL);
            WebResponse response = request.GetResponse();
            // TODO - this line below allocates 2MB of memmory (1MB -HtmlDecode() and 1MB ReadToEnd())
            return HttpUtility.HtmlDecode(new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(SourceEncoding)).ReadToEnd());
        }
        catch
        {
            return "";
        }
    }

    public string SearchPatGlobal { get; set; }

    public string SearchPatItem { get; set; }

    public List<List<string>> GetExtractedData()
    {

        // ZNALEZIENIE STRINGU Z ITEMAMI (GLOBAL PATTERN)

        string globalPat = SearchPatGlobal;

        // wstaw backspace przed znakami specjalnymi z patterna
        foreach (char specialChar in @"\.$^{[(|)*+?")
            globalPat = globalPat.Replace("" + specialChar, @"\" + specialChar);

        // zamiana patternow na zrozumiale dla Regex
        globalPat = globalPat.Replace(@"\{%}", @"(.*?)");
        globalPat = globalPat.Replace(@"\{\*}", @".*?");

        // wyszukanie stringu z itemami do items
        Regex globalRegex = new Regex(globalPat, RegexOptions.Singleline );
        string items = globalRegex.Match(GetSourceCode()).Groups[1].Value;

        // ZNALEZIENIE ITEMOW (ITEM PATTERN)

        string itemsPat = SearchPatItem;

        // wstaw backspace przed znakami specjalnymi z patterna
        foreach (char specialChar in @"\.$^{[(|)*+?")
            itemsPat = itemsPat.Replace("" + specialChar, @"\" + specialChar);

        // zamiana patternow na zrozumiale dla Regex
        itemsPat = itemsPat.Replace(@"\{%}", @"(.*?)");
        itemsPat = itemsPat.Replace(@"\{\*}", @".*?");

        // wyszukanie itemow do itemsMatches
        Regex itemsRegex = new Regex(itemsPat, RegexOptions.Singleline);
        MatchCollection itemsMatches = itemsRegex.Matches(items);


        List<List<string>> retData = new List<List<string>>();

        // dla kazdego znalezionego itemu dodaj go do listy itemow
        // TODO - this Extracting Match from MatchCollection takes >98% of whole application CPU consumption
        foreach (Match match in itemsMatches)
        {
            List<string> item = new List<string>();

            // dla kazdej podgrupy znalezionego itemu(bez grupy 0 - zawierajacej caly pattern)
            for (int groupIndex = 1; groupIndex < match.Groups.Count; groupIndex++)
            {

                // dodaj podgrupe (pole itemu) do itemu
                Group group = match.Groups[groupIndex];
                item.Add(group.Value);
            }

            retData.Add(item);
        }
        return retData;
    }

    public string Title { get; set; }

    public string Link { get; set; }

    public string Description { get; set; }

    public string ItemPatTitle { get; set; }

    public string ItemPatLink { get; set; }

    public string ItemPatDescription { get; set; }

    private ReaderWriterLockSlim _rwLock = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);

    public void EnterReadLock()
    {
        _rwLock.EnterReadLock();
    }
    public void ExitReadLock()
    {
        _rwLock.ExitReadLock();
    }
    public void EnterWriteLock()
    {
        _rwLock.EnterWriteLock();
    }
    public void ExitWriteLock()
    {
        _rwLock.ExitWriteLock();
    }

    public byte[] GetRSSCode()
    {
        // init writer
        Stream memoryStream = new MemoryStream();
        XmlTextWriter writer;
        try
        {
            writer = new XmlTextWriter(memoryStream, Encoding.GetEncoding(SourceEncoding));
        }
        catch
        {
            return new byte[0];
        }

        // start the document
        writer.Formatting = Formatting.Indented;
        writer.WriteStartDocument();
        writer.WriteStartElement("rss");
        writer.WriteAttributeString("version", "2.0");
        writer.WriteStartElement("channel");
        writer.WriteElementString("title", Title);
        writer.WriteElementString("link", Link);
        writer.WriteElementString("description", Description);

        // write each item
        foreach (List<string> item in GetExtractedData())
        {
            writer.WriteStartElement("item");

            // replace patterns with item values
            string itemTitle = ItemPatTitle;
            string itemLink = ItemPatLink;
            string itemDescription = ItemPatDescription;
            for (int nr = 0; nr < item.Count; nr++)
            {
                itemTitle = itemTitle.Replace("{%" + (nr + 1) + "}", item[nr]);
                itemLink = itemLink.Replace("{%" + (nr + 1) + "}", item[nr]);
                itemDescription = itemDescription.Replace("{%" + (nr + 1) + "}", item[nr]);
            }

            // write filled patterns
            writer.WriteElementString("title", itemTitle);
            writer.WriteElementString("link", itemLink);
            writer.WriteElementString("description", itemDescription);
            writer.WriteElementString("guid", itemLink);

            writer.WriteEndElement();
        }

        // end writing rss document
        writer.WriteEndDocument();
        writer.Flush();

        // serialize rss to byte array
        memoryStream.Seek(0, SeekOrigin.Begin);
        byte[] retRSS = new byte[memoryStream.Length];
        memoryStream.Read(retRSS, 0, (int)memoryStream.Length);

        return retRSS;
    }

    public object Clone()
    {
        Feed retFeedClone = new Feed();
        retFeedClone.SourceURL = SourceURL;
        retFeedClone.SourceEncoding = SourceEncoding;
        retFeedClone.SearchPatGlobal = SearchPatGlobal;
        retFeedClone.SearchPatItem = SearchPatItem;
        retFeedClone.Title = Title;
        retFeedClone.Link = Link;
        retFeedClone.Description = Description;
        retFeedClone.ItemPatTitle = ItemPatTitle;
        retFeedClone.ItemPatLink = ItemPatLink;
        retFeedClone.ItemPatDescription = ItemPatDescription;
        return retFeedClone;
    }

}