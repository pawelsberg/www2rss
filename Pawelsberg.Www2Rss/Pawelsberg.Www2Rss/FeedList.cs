using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections;

namespace Pawelsberg.Www2Rss
{
    public class FeedList
    {
        private Dictionary<string, Feed> _feeds = new Dictionary<string, Feed>();
        private object _feedsSyncRoot = new object();

        public void AddFeed(string fileName, Feed feed)
        {
            lock (_feedsSyncRoot)
            {
                _feeds.Add(fileName, feed);
            }
        }
        public void AddFeeds(FeedList feeds)
        {
            lock (_feedsSyncRoot)
            {
                IEnumerable<KeyValuePair<string, Feed>> enumerableFeedsConcatenation = _feeds.Concat(feeds._feeds);
                _feeds = enumerableFeedsConcatenation.ToDictionary(feed => feed.Key, feed => feed.Value);
            }
        }
        public Feed GetFeedCloneByFileName(string fileName)
        {
            Feed retFeedClone;
            lock (_feedsSyncRoot)
            {
                Feed sourceFeed = _feeds[fileName];
                sourceFeed.EnterReadLock();
                retFeedClone = (Feed)sourceFeed.Clone();
                sourceFeed.ExitReadLock();
            }
            return retFeedClone;
        }
        public IEnumerable<string> GetFileNames()
        {
            lock (_feedsSyncRoot)
            {
                foreach (KeyValuePair<string, Feed> feedKVP in _feeds)
                    yield return feedKVP.Key;
            }
        }
        public Feed this[string fileName]
        {
            get
            {
                lock (_feedsSyncRoot)
                {
                    return _feeds[fileName];
                }
            }
        }
        public void ReplaceFeed(string fileName, Feed feed)
        {
            lock (_feedsSyncRoot)
            {
                _feeds[fileName] = feed;
            }
        }
        public void ReplaceFeed(string oldFileName, string newFileName, Feed feed)
        {
            lock (_feedsSyncRoot)
            {
                _feeds.Remove(oldFileName);
                _feeds.Add(newFileName, feed);
            }
        }
        public void RemoveFeed(string fileName)
        {
            lock (_feedsSyncRoot)
            {
                _feeds.Remove(fileName);
            }
        }

        public byte[] GetFileContent(string fileName)
        {
            Feed feed;
            lock (_feedsSyncRoot)
            {
                feed = _feeds[fileName];
            }
            feed.EnterReadLock();
            byte[] content = feed.GetRSSCode();
            feed.ExitReadLock();

            return content;
        }

        public void Read(XmlElement parentXmlElement)
        {
            lock (_feedsSyncRoot)
            {
                foreach (XmlNode FEED in parentXmlElement.GetElementsByTagName("FEED"))
                {
                    Feed feed = new Feed();
                    feed.SourceURL = FEED.Attributes.GetNamedItem("sourceURL").Value;
                    feed.SourceEncoding = FEED.Attributes.GetNamedItem("sourceEncoding").Value;
                    feed.SearchPatGlobal = FEED.Attributes.GetNamedItem("searchPatGlobal").Value;
                    feed.SearchPatItem = FEED.Attributes.GetNamedItem("searchPatItem").Value;
                    feed.Title = FEED.Attributes.GetNamedItem("title").Value;
                    feed.Link = FEED.Attributes.GetNamedItem("link").Value;
                    feed.Description = FEED.Attributes.GetNamedItem("description").Value;
                    feed.ItemPatTitle = FEED.Attributes.GetNamedItem("itemPatTitle").Value;
                    feed.ItemPatLink = FEED.Attributes.GetNamedItem("itemPatLink").Value;
                    feed.ItemPatDescription = FEED.Attributes.GetNamedItem("itemPatDescription").Value;
                    _feeds.Add(FEED.Attributes.GetNamedItem("filename").Value, feed);
                }
            }
        }
        public void Write(XmlDocument document, XmlElement parentXmlElement)
        {
            lock (_feedsSyncRoot)
            {
                foreach (KeyValuePair<string, Feed> feedKVP in _feeds)
                {
                    string fileName = feedKVP.Key;
                    Feed feed = feedKVP.Value;
                    XmlElement feedXmlElement = document.CreateElement("FEED");
                    parentXmlElement.AppendChild(feedXmlElement);
                    feedXmlElement.SetAttribute("sourceURL", feed.SourceURL);
                    feedXmlElement.SetAttribute("sourceEncoding", feed.SourceEncoding);
                    feedXmlElement.SetAttribute("searchPatGlobal", feed.SearchPatGlobal);
                    feedXmlElement.SetAttribute("searchPatItem", feed.SearchPatItem);
                    feedXmlElement.SetAttribute("title", feed.Title);
                    feedXmlElement.SetAttribute("link", feed.Link);
                    feedXmlElement.SetAttribute("description", feed.Description);
                    feedXmlElement.SetAttribute("itemPatTitle", feed.ItemPatTitle);
                    feedXmlElement.SetAttribute("itemPatLink", feed.ItemPatLink);
                    feedXmlElement.SetAttribute("itemPatDescription", feed.ItemPatDescription);
                    feedXmlElement.SetAttribute("filename", fileName);
                }
            }
        }

    }
}
