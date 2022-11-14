using System.Text;

namespace Pawelsberg.Www2Rss;

public partial class FormFeedConf : Form
{
    public string File { get; private set; }
    public Feed Feed { get; }
    public bool Result { get; private set; }

    public FormFeedConf(Feed? feed,string fileName)
    {
        InitializeComponent();
        Feed = feed ?? new Feed();
        File = fileName;
        textBoxSourceURL.Text = Feed.SourceURL;
        textBoxSourceEncoding.Text = Feed.SourceEncoding;
        textBoxSourceCode.Text = "";
        textBoxGlobalSP.Text = Feed.SearchPatGlobal;
        textBoxItemSP.Text = Feed.SearchPatItem;
        textBoxExtractedData.Text = "";
        textBoxTitle.Text = Feed.Title;
        textBoxLink.Text = Feed.Link;
        textBoxDescription.Text = Feed.Description;
        textBoxItemTitle.Text = Feed.ItemPatTitle;
        textBoxItemLink.Text = Feed.ItemPatLink;
        textBoxItemDescription.Text = Feed.ItemPatDescription;
        textBoxPreview.Text = "";
        textBoxFile.Text = File;
        panelExtractData.BringToFront();
    }
    private void buttonLoadSource_Click(object sender, EventArgs e)
    {
        Enabled = false;
        textBoxSourceCode.Text = Feed.GetSourceCode().Replace("\n",Environment.NewLine);
        Enabled = true;
    }
    private void buttonExtract_Click(object sender, EventArgs e)
    {
        Enabled = false;
        textBoxExtractedData.Text = "";
        StringBuilder extractedDataBuilder = new StringBuilder();
            
        int itm_nr=0;
        foreach (List<string> itm in Feed.GetExtractedData())
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
        labelExtractResult.Text = $"({itm_nr} items)";
        panelCreateFeed.BringToFront();
        Enabled = true;
    }
    private void buttonPreview_Click(object sender, EventArgs e)
    {
        Enabled = false;
        textBoxPreview.Text = System.Text.UnicodeEncoding.ASCII.GetString(Feed.GetRSSCode());
        panelPreview.BringToFront();
        Enabled = true;
    }

    private void textBoxSourceURL_TextChanged(object sender, EventArgs e)
    {
        Feed.SourceURL = textBoxSourceURL.Text;
    }
    private void textBoxSourceEncoding_TextChanged(object sender, EventArgs e)
    {
        Feed.SourceEncoding = textBoxSourceEncoding.Text;
    }
    private void textBoxGlobalSP_TextChanged(object sender, EventArgs e)
    {
        Feed.SearchPatGlobal = textBoxGlobalSP.Text;
    }
    private void textBoxItemSP_TextChanged(object sender, EventArgs e)
    {
        Feed.SearchPatItem = textBoxItemSP.Text;
    }
    private void textBoxTitle_TextChanged(object sender, EventArgs e)
    {
        Feed.Title = textBoxTitle.Text;
    }
    private void textBoxLink_TextChanged(object sender, EventArgs e)
    {
        Feed.Link = textBoxLink.Text;
    }
    private void textBoxDescription_TextChanged(object sender, EventArgs e)
    {
        Feed.Description = textBoxDescription.Text;
    }
    private void textBoxItemTitle_TextChanged(object sender, EventArgs e)
    {
        Feed.ItemPatTitle = textBoxItemTitle.Text;
    }
    private void textBoxItemLink_TextChanged(object sender, EventArgs e)
    {
        Feed.ItemPatLink = textBoxItemLink.Text;
    }
    private void textBoxItemDescription_TextChanged(object sender, EventArgs e)
    {
        Feed.ItemPatDescription = textBoxItemDescription.Text;
    }
    private void textBoxFile_TextChanged(object sender, EventArgs e)
    {
        File = textBoxFile.Text;
    }
    private void buttonOK_Click(object sender, EventArgs e)
    {
        Result = true;
        Close();
    }
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Result = false;
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