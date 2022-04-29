using Pawelsberg.Www2Rss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Pawelsberg.Www2Rss
{
    public partial class FormFeedList : Form
    {
        private readonly string _server = "WWW2RSS";
        private readonly string _configFileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Pawelsberg.Www2rss\\Www2Rss.config.xml";
        RssWebServer _WS;
        public FormFeedList()
        {
            InitializeComponent();
            getConfig();
            updateFeedList();
            _WS.Start();
            listViewFeeds_SelectedIndexChanged(null, null); // disable add and delete buttons
        }
        private void updateFeedList()
        {
            listViewFeeds.Items.Clear();
            foreach (string plik in _WS.Feeds.GetFileNames())
            {
                Feed feed = _WS.Feeds[plik];
                ListViewItem listViewFeed = new ListViewItem(new string[] { plik, feed.Title, feed.SourceURL });
                listViewFeeds.Items.Add(listViewFeed);
            }
        }
        private void getConfig()
        {
            XmlDocument config = new System.Xml.XmlDocument();
            try { config.Load(_configFileName); }
            catch {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "Pawelsberg.Www2Rss.Www2Rss.config.xml";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                    config.Load(reader);

                Directory.CreateDirectory(Path.GetDirectoryName(_configFileName));
                config.Save(_configFileName);


            } // gdy nie ma pliku lub bledna tresc

            XmlElement KONF = (XmlElement)config.GetElementsByTagName("CONFIG").Item(0);
            UInt16 port = Convert.ToUInt16(KONF.Attributes.GetNamedItem("WS_port").Value);
            bool localonly = Convert.ToBoolean(KONF.Attributes.GetNamedItem("WS_localonly").Value);
            _WS = new RssWebServer(port, localonly, _server);
            _WS.Feeds.Read(KONF);
        }
        private void setConfig()
        {
            XmlDocument config = new System.Xml.XmlDocument();

            XmlElement KONF = config.CreateElement("CONFIG");
            config.AppendChild(KONF);
            KONF.SetAttribute("WS_port", _WS.Port.ToString());
            KONF.SetAttribute("WS_localonly", _WS.Localonly.ToString());
            _WS.Feeds.Write(config, KONF);
            try { config.Save(_configFileName); }
            catch { }
        }
        private void listViewFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool itemchecked = (listViewFeeds.SelectedItems.Count == 0);
            buttonDelete.Enabled = !itemchecked;
            buttonEdit.Enabled = !itemchecked;
            buttonOpen.Enabled = !itemchecked;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormFeedConf fcf = new FormFeedConf(new Feed(), "");
            fcf.ShowDialog();
            if (fcf.Result)
                _WS.Feeds.AddFeed(fcf.File, fcf.Feed);
            updateFeedList();
            setConfig();
            listViewFeeds_SelectedIndexChanged(null, null); // disable add and delete buttons
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string selectedFileName = listViewFeeds.SelectedItems[0].Text;
            Feed selectedFeed = _WS.Feeds.GetFeedCloneByFileName(selectedFileName);

            FormFeedConf fcf = new FormFeedConf(selectedFeed, selectedFileName);
            fcf.ShowDialog();
            if (fcf.Result)
            {
                if (selectedFileName == fcf.File)
                    _WS.Feeds.ReplaceFeed(selectedFileName, selectedFeed);
                else
                    _WS.Feeds.ReplaceFeed(selectedFileName, fcf.File, selectedFeed);
            }
            updateFeedList();
            setConfig();
            listViewFeeds_SelectedIndexChanged(null, null); // disable add and delete buttons
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start(String.Format("http://localhost:{0}/{1}", _WS.Port, listViewFeeds.SelectedItems[0].Text)); }
            catch { } // sometimes it does not work - unknown reason
            updateFeedList();
            listViewFeeds_SelectedIndexChanged(null, null); // disable add and delete buttons
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string selectedFileName = listViewFeeds.SelectedItems[0].Text;
            _WS.Feeds.RemoveFeed(selectedFileName);
            updateFeedList();
            setConfig();
            listViewFeeds_SelectedIndexChanged(null, null); // disable add and delete buttons
        }
        private void contextMenuStripNotifyIcon_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolStripMenuItemFeedList)
            {
                Show();
                ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
                TopMost = true;
                TopMost = false;
                return;
            }
            else if (e.ClickedItem == toolStripMenuItemExit)
            {
                Application.Exit();
            }
            else if (e.ClickedItem == toolStripMenuItemServerConfiguration)
            {
                FormServerConfiguration sc = new FormServerConfiguration(_WS.Port, _WS.Localonly);
                sc.ShowDialog();
                if (sc.Result)
                {
                    _WS.Stop();
                    RssWebServer newWS = new RssWebServer(sc.Port, sc.Localonly, _server);
                    newWS.Feeds.AddFeeds(_WS.Feeds);
                    _WS = newWS;
                    _WS.Start();
                    setConfig();
                }
            }
        }
        private void formFeedList_Shown(object sender, EventArgs e)
        {
            Hide(); // if minimized only still exist in Alt-TAB list
        }
        private void formFeedList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            { // Form "X" clicked - dont stop server
                e.Cancel = true;
                Hide();
            }
        }
        private void formFeedList_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Hide(); // if clicked minimize hide window (ex. hide on Alt-TAB list)
        }
        private void listViewFeeds_ItemActivate(object sender, EventArgs e)
        {
            buttonEdit_Click(null, null);
        }

    }


}