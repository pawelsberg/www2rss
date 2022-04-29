using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Web;
using System.Threading;

namespace Pawelsberg.Www2Rss
{
    public class Feed : ICloneable
    {
        private string _sourceURL;
        public string SourceURL
        {
            get { return _sourceURL; }
            set { _sourceURL = value; }
        }

        private string _sourceEncoding;
        public string SourceEncoding
        {
            get { return _sourceEncoding; }
            set { _sourceEncoding = value; }
        }

        public string GetSourceCode()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_sourceURL);
                WebResponse response = request.GetResponse();
                // TODO - this line below allocates 2MB of memmory (1MB -HtmlDecode() and 1MB ReadToEnd())
                return HttpUtility.HtmlDecode(new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(_sourceEncoding)).ReadToEnd());
            }
            catch
            {
                return "";
            }
        }

        private string _searchPatGlobal;
        public string SearchPatGlobal
        {
            get { return _searchPatGlobal; }
            set { _searchPatGlobal = value; }
        }

        private string _searchPatItem;
        public string SearchPatItem
        {
            get { return _searchPatItem; }
            set { _searchPatItem = value; }
        }

        public List<List<string>> GetExtractedData()
        {

            // ZNALEZIENIE STRINGU Z ITEMAMI (GLOBAL PATTERN)

            string globalPat = _searchPatGlobal;

            // wstaw backspace przed znakami specjalnymi z patterna
            foreach (char specialChar in @"\.$^{[(|)*+?")
                globalPat = globalPat.Replace("" + specialChar, @"\" + specialChar);

            // zamiana patternow na zrozumiale dla Regex
            globalPat = globalPat.Replace(@"\{%}", @"(.*?)");
            globalPat = globalPat.Replace(@"\{\*}", @".*?");

            // wyszukanie stringu z itemami do items
            Regex globalRegex = new Regex(globalPat, RegexOptions.Singleline);
            string items = globalRegex.Match(GetSourceCode()).Groups[1].Value;

            // ZNALEZIENIE ITEMOW (ITEM PATTERN)

            string itemsPat = _searchPatItem;

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

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _link;
        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _itemPatTitle;
        public string ItemPatTitle
        {
            get { return _itemPatTitle; }
            set { _itemPatTitle = value; }
        }

        private string _itemPatLink;
        public string ItemPatLink
        {
            get { return _itemPatLink; }
            set { _itemPatLink = value; }
        }

        private string _itemPatDescription;
        public string ItemPatDescription
        {
            get { return _itemPatDescription; }
            set { _itemPatDescription = value; }
        }

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
                writer = new XmlTextWriter(memoryStream, Encoding.GetEncoding(_sourceEncoding));
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
            writer.WriteElementString("title", _title);
            writer.WriteElementString("link", _link);
            writer.WriteElementString("description", _description);

            // write each item
            foreach (List<string> item in GetExtractedData())
            {
                writer.WriteStartElement("item");

                // replace patterns with item values
                string itemTitle = _itemPatTitle;
                string itemLink = _itemPatLink;
                string itemDescription = _itemPatDescription;
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
            retFeedClone._sourceURL = _sourceURL;
            retFeedClone._sourceEncoding = _sourceEncoding;
            retFeedClone._searchPatGlobal = _searchPatGlobal;
            retFeedClone._searchPatItem = _searchPatItem;
            retFeedClone._title = _title;
            retFeedClone._link = _link;
            retFeedClone._description = _description;
            retFeedClone._itemPatTitle = _itemPatTitle;
            retFeedClone._itemPatLink = _itemPatLink;
            retFeedClone._itemPatDescription = _itemPatDescription;
            return retFeedClone;
        }

    }

}
