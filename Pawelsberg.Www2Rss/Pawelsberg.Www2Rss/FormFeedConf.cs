using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Web;
using System.Threading;
using Pawelsberg.Www2Rss;

namespace Pawelsberg.Www2Rss
{

    public partial class FormFeedConf : Form
    {
        private string _file;
        public string File
        {
            get { return _file; }
        }
        private Feed _feed;
        public Feed Feed
        {
            get { return _feed; }
        }
        private bool _result;
        public bool Result
        {
            get { return _result; }
        }
        public FormFeedConf(Feed feed,string fileName)
        {
            InitializeComponent();
            if (feed==null) _feed = new Feed();
            _feed=feed;
            _file=fileName;
            textBoxSourceURL.Text = _feed.SourceURL;
            textBoxSourceEncoding.Text = _feed.SourceEncoding;
            textBoxSourceCode.Text = "";
            textBoxGlobalSP.Text = _feed.SearchPatGlobal;
            textBoxItemSP.Text = _feed.SearchPatItem;
            textBoxExtractedData.Text = "";
            textBoxTitle.Text = _feed.Title;
            textBoxLink.Text = _feed.Link;
            textBoxDescription.Text = _feed.Description;
            textBoxItemTitle.Text = _feed.ItemPatTitle;
            textBoxItemLink.Text = _feed.ItemPatLink;
            textBoxItemDescription.Text = _feed.ItemPatDescription;
            textBoxPreview.Text = "";
            textBoxFile.Text = _file;
            panelExtractData.BringToFront();
        }
        private void buttonLoadSource_Click(object sender, EventArgs e)
        {
            Enabled = false;
            textBoxSourceCode.Text = _feed.GetSourceCode().Replace("\n",Environment.NewLine);
            Enabled = true;
        }
        private void buttonExtract_Click(object sender, EventArgs e)
        {
            Enabled = false;
            textBoxExtractedData.Text = "";
            StringBuilder extractedDataBuilder = new StringBuilder();
            
            int itm_nr=0;
            foreach (List<string> itm in _feed.GetExtractedData())
            {
                itm_nr++;
                int nr = 1;
                foreach (string val in itm)
                {
                    extractedDataBuilder.Append("{%" + nr + "}=" + val + "\r\n");
                    nr++;
                }
                extractedDataBuilder.Append("\r\n");
            }
            textBoxExtractedData.Text = extractedDataBuilder.ToString();
            labelExtractResult.Text = String.Format("({0} items)", itm_nr);
            panelCreateFeed.BringToFront();
            Enabled = true;
        }
        private void buttonPreview_Click(object sender, EventArgs e)
        {
            Enabled = false;
            textBoxPreview.Text = System.Text.UnicodeEncoding.ASCII.GetString(_feed.GetRSSCode());
            panelPreview.BringToFront();
            Enabled = true;
        }

        private void textBoxSourceURL_TextChanged(object sender, EventArgs e)
        {
            _feed.SourceURL = textBoxSourceURL.Text;
        }
        private void textBoxSourceEncoding_TextChanged(object sender, EventArgs e)
        {
            _feed.SourceEncoding = textBoxSourceEncoding.Text;
        }
        private void textBoxGlobalSP_TextChanged(object sender, EventArgs e)
        {
            _feed.SearchPatGlobal = textBoxGlobalSP.Text;
        }
        private void textBoxItemSP_TextChanged(object sender, EventArgs e)
        {
            _feed.SearchPatItem = textBoxItemSP.Text;
        }
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            _feed.Title = textBoxTitle.Text;
        }
        private void textBoxLink_TextChanged(object sender, EventArgs e)
        {
            _feed.Link = textBoxLink.Text;
        }
        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            _feed.Description = textBoxDescription.Text;
        }
        private void textBoxItemTitle_TextChanged(object sender, EventArgs e)
        {
            _feed.ItemPatTitle = textBoxItemTitle.Text;
        }
        private void textBoxItemLink_TextChanged(object sender, EventArgs e)
        {
            _feed.ItemPatLink = textBoxItemLink.Text;
        }
        private void textBoxItemDescription_TextChanged(object sender, EventArgs e)
        {
            _feed.ItemPatDescription = textBoxItemDescription.Text;
        }
        private void textBoxFile_TextChanged(object sender, EventArgs e)
        {
            _file = textBoxFile.Text;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            _result = true;
            Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _result = false;
            Close();
        }
        private void buttonBackFromPreview_Click(object sender, EventArgs e)
        {
            panelCreateFeed.BringToFront();
        }
        private void buttonBackFromCreateFeed_Click(object sender, EventArgs e)
        {
            panelExtractData.BringToFront();
        }

        private void buttonExtractDataHelp_MouseDown(object sender, MouseEventArgs e)
        {
            toolTipExtractDataHelp.ShowAlways = true;
        }



    }




}
