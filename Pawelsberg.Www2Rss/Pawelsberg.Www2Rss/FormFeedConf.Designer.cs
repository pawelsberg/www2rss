namespace Pawelsberg.Www2Rss
{
    partial class FormFeedConf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated GetCode

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the GetCode editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxSourceURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadSource = new System.Windows.Forms.Button();
            this.textBoxSourceCode = new System.Windows.Forms.TextBox();
            this.textBoxSourceEncoding = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGlobalSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxItemSP = new System.Windows.Forms.TextBox();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.textBoxExtractedData = new System.Windows.Forms.TextBox();
            this.labelExtractResult = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxItemDescription = new System.Windows.Forms.TextBox();
            this.textBoxItemLink = new System.Windows.Forms.TextBox();
            this.textBoxItemTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonExtractDataHelp = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelExtractData = new System.Windows.Forms.Panel();
            this.panelCreateFeed = new System.Windows.Forms.Panel();
            this.buttonBackFromCreateFeed = new System.Windows.Forms.Button();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.buttonBackFromPreview = new System.Windows.Forms.Button();
            this.toolTipExtractDataHelp = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.panelExtractData.SuspendLayout();
            this.panelCreateFeed.SuspendLayout();
            this.panelPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSourceURL
            // 
            this.textBoxSourceURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceURL.Location = new System.Drawing.Point(56, 22);
            this.textBoxSourceURL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSourceURL.Name = "textBoxSourceURL";
            this.textBoxSourceURL.Size = new System.Drawing.Size(922, 23);
            this.textBoxSourceURL.TabIndex = 0;
            this.textBoxSourceURL.Text = "http://wroclaw.dlastudenta.pl/stancje/?cena=0&pokoje=0&miasto=1&typ=400";
            this.textBoxSourceURL.TextChanged += new System.EventHandler(this.textBoxSourceURL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // buttonLoadSource
            // 
            this.buttonLoadSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadSource.Location = new System.Drawing.Point(892, 56);
            this.buttonLoadSource.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadSource.Name = "buttonLoadSource";
            this.buttonLoadSource.Size = new System.Drawing.Size(88, 26);
            this.buttonLoadSource.TabIndex = 2;
            this.buttonLoadSource.Text = "Load";
            this.buttonLoadSource.UseVisualStyleBackColor = true;
            this.buttonLoadSource.Click += new System.EventHandler(this.buttonLoadSource_Click);
            // 
            // textBoxSourceCode
            // 
            this.textBoxSourceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceCode.Location = new System.Drawing.Point(4, 5);
            this.textBoxSourceCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSourceCode.Multiline = true;
            this.textBoxSourceCode.Name = "textBoxSourceCode";
            this.textBoxSourceCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSourceCode.Size = new System.Drawing.Size(977, 139);
            this.textBoxSourceCode.TabIndex = 3;
            this.toolTipExtractDataHelp.SetToolTip(this.textBoxSourceCode, "Source GetCode of the web page");
            // 
            // textBoxSourceEncoding
            // 
            this.textBoxSourceEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceEncoding.Location = new System.Drawing.Point(83, 56);
            this.textBoxSourceEncoding.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSourceEncoding.Name = "textBoxSourceEncoding";
            this.textBoxSourceEncoding.Size = new System.Drawing.Size(801, 23);
            this.textBoxSourceEncoding.TabIndex = 4;
            this.textBoxSourceEncoding.Text = "iso-8859-2";
            this.textBoxSourceEncoding.TextChanged += new System.EventHandler(this.textBoxSourceEncoding_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encoding:";
            // 
            // textBoxGlobalSP
            // 
            this.textBoxGlobalSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGlobalSP.Location = new System.Drawing.Point(4, 22);
            this.textBoxGlobalSP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGlobalSP.Multiline = true;
            this.textBoxGlobalSP.Name = "textBoxGlobalSP";
            this.textBoxGlobalSP.Size = new System.Drawing.Size(977, 81);
            this.textBoxGlobalSP.TabIndex = 6;
            this.textBoxGlobalSP.Text = "ht{%}</html>";
            this.textBoxGlobalSP.TextChanged += new System.EventHandler(this.textBoxGlobalSP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Global search pattern:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item (repeatable) Search Pattern:";
            // 
            // textBoxItemSP
            // 
            this.textBoxItemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxItemSP.Location = new System.Drawing.Point(4, 19);
            this.textBoxItemSP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemSP.Multiline = true;
            this.textBoxItemSP.Name = "textBoxItemSP";
            this.textBoxItemSP.Size = new System.Drawing.Size(977, 187);
            this.textBoxItemSP.TabIndex = 9;
            this.textBoxItemSP.Text = "<td><a href=\"{%}\"{*}<b>{%}<span class=\"strz fred\"{*}<td style=\"text-align:center;" +
    "\">{%}<{*}<td style=\"text-align:right;padding-right:13px\">{%}<";
            this.textBoxItemSP.TextChanged += new System.EventHandler(this.textBoxItemSP_TextChanged);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExtract.Location = new System.Drawing.Point(896, 209);
            this.buttonExtract.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(88, 26);
            this.buttonExtract.TabIndex = 10;
            this.buttonExtract.Text = "Extract >>";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // textBoxExtractedData
            // 
            this.textBoxExtractedData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtractedData.Location = new System.Drawing.Point(4, 19);
            this.textBoxExtractedData.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExtractedData.Multiline = true;
            this.textBoxExtractedData.Name = "textBoxExtractedData";
            this.textBoxExtractedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExtractedData.Size = new System.Drawing.Size(978, 136);
            this.textBoxExtractedData.TabIndex = 11;
            // 
            // labelExtractResult
            // 
            this.labelExtractResult.AutoSize = true;
            this.labelExtractResult.Location = new System.Drawing.Point(133, 0);
            this.labelExtractResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExtractResult.Name = "labelExtractResult";
            this.labelExtractResult.Size = new System.Drawing.Size(0, 15);
            this.labelExtractResult.TabIndex = 12;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(43, 10);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(940, 23);
            this.textBoxTitle.TabIndex = 13;
            this.textBoxTitle.Text = "Pokój do wynajêcia Wroc³aw";
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Link:";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLink.Location = new System.Drawing.Point(43, 40);
            this.textBoxLink.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(940, 23);
            this.textBoxLink.TabIndex = 16;
            this.textBoxLink.Text = "http://wroclaw.dlastudenta.pl/stancje/?cena=0&pokoje=0&miasto=1&typ=400";
            this.textBoxLink.TextChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(4, 85);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(978, 103);
            this.textBoxDescription.TabIndex = 18;
            this.textBoxDescription.Text = "Pokój do wynajêcia Wroc³aw";
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxLink);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.MinimumSize = new System.Drawing.Size(0, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(987, 196);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxItemDescription);
            this.groupBox2.Controls.Add(this.textBoxItemLink);
            this.groupBox2.Controls.Add(this.textBoxItemTitle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.MinimumSize = new System.Drawing.Size(0, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(987, 217);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Link:";
            // 
            // textBoxItemDescription
            // 
            this.textBoxItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxItemDescription.Location = new System.Drawing.Point(7, 89);
            this.textBoxItemDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemDescription.Multiline = true;
            this.textBoxItemDescription.Name = "textBoxItemDescription";
            this.textBoxItemDescription.Size = new System.Drawing.Size(977, 115);
            this.textBoxItemDescription.TabIndex = 3;
            this.textBoxItemDescription.Text = "{%2}- {%3} - {%4}";
            this.textBoxItemDescription.TextChanged += new System.EventHandler(this.textBoxItemDescription_TextChanged);
            // 
            // textBoxItemLink
            // 
            this.textBoxItemLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxItemLink.Location = new System.Drawing.Point(43, 44);
            this.textBoxItemLink.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemLink.Name = "textBoxItemLink";
            this.textBoxItemLink.Size = new System.Drawing.Size(940, 23);
            this.textBoxItemLink.TabIndex = 2;
            this.textBoxItemLink.Text = "http://wroclaw.dlastudenta.pl{%1}";
            this.textBoxItemLink.TextChanged += new System.EventHandler(this.textBoxItemLink_TextChanged);
            // 
            // textBoxItemTitle
            // 
            this.textBoxItemTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxItemTitle.Location = new System.Drawing.Point(43, 15);
            this.textBoxItemTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemTitle.Name = "textBoxItemTitle";
            this.textBoxItemTitle.Size = new System.Drawing.Size(940, 23);
            this.textBoxItemTitle.TabIndex = 1;
            this.textBoxItemTitle.Text = "{%2}";
            this.textBoxItemTitle.TextChanged += new System.EventHandler(this.textBoxItemTitle_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Title:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBoxPreview);
            this.groupBox3.Location = new System.Drawing.Point(13, 35);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(981, 567);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview:";
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPreview.Location = new System.Drawing.Point(4, 20);
            this.textBoxPreview.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPreview.Multiline = true;
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPreview.Size = new System.Drawing.Size(973, 543);
            this.textBoxPreview.TabIndex = 22;
            this.textBoxPreview.WordWrap = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxSourceURL);
            this.groupBox4.Controls.Add(this.buttonLoadSource);
            this.groupBox4.Controls.Add(this.textBoxSourceEncoding);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(6, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(988, 94);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Source:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.splitContainer2);
            this.groupBox5.Controls.Add(this.splitter1);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Location = new System.Drawing.Point(4, 104);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(998, 540);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Source GetCode:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 178);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxGlobalSP);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonExtractDataHelp);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.buttonExtract);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxItemSP);
            this.splitContainer2.Size = new System.Drawing.Size(990, 358);
            this.splitContainer2.SplitterDistance = 111;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 12;
            // 
            // buttonExtractDataHelp
            // 
            this.buttonExtractDataHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExtractDataHelp.Location = new System.Drawing.Point(801, 209);
            this.buttonExtractDataHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtractDataHelp.Name = "buttonExtractDataHelp";
            this.buttonExtractDataHelp.Size = new System.Drawing.Size(88, 26);
            this.buttonExtractDataHelp.TabIndex = 11;
            this.buttonExtractDataHelp.Text = "Help";
            this.buttonExtractDataHelp.UseVisualStyleBackColor = true;
            this.buttonExtractDataHelp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonExtractDataHelp_MouseDown);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(4, 173);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(990, 5);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxSourceCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 153);
            this.panel1.TabIndex = 8;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Location = new System.Drawing.Point(7, 14);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.textBoxExtractedData);
            this.splitContainer4.Panel1.Controls.Add(this.label11);
            this.splitContainer4.Panel1.Controls.Add(this.labelExtractResult);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(991, 593);
            this.splitContainer4.SplitterDistance = 162;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Extracted data:";
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer5.Panel1MinSize = 100;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer5.Panel2MinSize = 100;
            this.splitContainer5.Size = new System.Drawing.Size(991, 426);
            this.splitContainer5.SplitterDistance = 200;
            this.splitContainer5.SplitterWidth = 5;
            this.splitContainer5.TabIndex = 0;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreview.Location = new System.Drawing.Point(897, 614);
            this.buttonPreview.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(105, 26);
            this.buttonPreview.TabIndex = 22;
            this.buttonPreview.Text = "Preview >>";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(812, 4);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 26);
            this.buttonOK.TabIndex = 26;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(10, 10);
            this.labelFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(61, 15);
            this.labelFile.TabIndex = 27;
            this.labelFile.Text = "File name:";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFile.Location = new System.Drawing.Point(81, 7);
            this.textBoxFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(722, 23);
            this.textBoxFile.TabIndex = 28;
            this.textBoxFile.TextChanged += new System.EventHandler(this.textBoxFile_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(906, 4);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 26);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelExtractData
            // 
            this.panelExtractData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExtractData.Controls.Add(this.groupBox5);
            this.panelExtractData.Controls.Add(this.groupBox4);
            this.panelExtractData.Location = new System.Drawing.Point(0, 0);
            this.panelExtractData.Margin = new System.Windows.Forms.Padding(4);
            this.panelExtractData.Name = "panelExtractData";
            this.panelExtractData.Size = new System.Drawing.Size(1005, 648);
            this.panelExtractData.TabIndex = 31;
            // 
            // panelCreateFeed
            // 
            this.panelCreateFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCreateFeed.Controls.Add(this.buttonBackFromCreateFeed);
            this.panelCreateFeed.Controls.Add(this.buttonPreview);
            this.panelCreateFeed.Controls.Add(this.splitContainer4);
            this.panelCreateFeed.Location = new System.Drawing.Point(0, 0);
            this.panelCreateFeed.Margin = new System.Windows.Forms.Padding(4);
            this.panelCreateFeed.Name = "panelCreateFeed";
            this.panelCreateFeed.Size = new System.Drawing.Size(1005, 648);
            this.panelCreateFeed.TabIndex = 32;
            // 
            // buttonBackFromCreateFeed
            // 
            this.buttonBackFromCreateFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBackFromCreateFeed.Location = new System.Drawing.Point(7, 614);
            this.buttonBackFromCreateFeed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackFromCreateFeed.Name = "buttonBackFromCreateFeed";
            this.buttonBackFromCreateFeed.Size = new System.Drawing.Size(88, 26);
            this.buttonBackFromCreateFeed.TabIndex = 24;
            this.buttonBackFromCreateFeed.Text = "<< Back";
            this.buttonBackFromCreateFeed.UseVisualStyleBackColor = true;
            this.buttonBackFromCreateFeed.Click += new System.EventHandler(this.buttonBackFromCreateFeed_Click);
            // 
            // panelPreview
            // 
            this.panelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPreview.Controls.Add(this.buttonBackFromPreview);
            this.panelPreview.Controls.Add(this.groupBox3);
            this.panelPreview.Controls.Add(this.buttonOK);
            this.panelPreview.Controls.Add(this.buttonCancel);
            this.panelPreview.Controls.Add(this.labelFile);
            this.panelPreview.Controls.Add(this.textBoxFile);
            this.panelPreview.Location = new System.Drawing.Point(0, 0);
            this.panelPreview.Margin = new System.Windows.Forms.Padding(4);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(1005, 648);
            this.panelPreview.TabIndex = 33;
            // 
            // buttonBackFromPreview
            // 
            this.buttonBackFromPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBackFromPreview.Location = new System.Drawing.Point(10, 614);
            this.buttonBackFromPreview.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackFromPreview.Name = "buttonBackFromPreview";
            this.buttonBackFromPreview.Size = new System.Drawing.Size(88, 26);
            this.buttonBackFromPreview.TabIndex = 30;
            this.buttonBackFromPreview.Text = "<< Back";
            this.buttonBackFromPreview.UseVisualStyleBackColor = true;
            this.buttonBackFromPreview.Click += new System.EventHandler(this.buttonBackFromPreview_Click);
            // 
            // toolTipExtractDataHelp
            // 
            this.toolTipExtractDataHelp.IsBalloon = true;
            this.toolTipExtractDataHelp.OwnerDraw = true;
            this.toolTipExtractDataHelp.ToolTipTitle = "Source GetCode";
            // 
            // FormFeedConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 649);
            this.Controls.Add(this.panelExtractData);
            this.Controls.Add(this.panelCreateFeed);
            this.Controls.Add(this.panelPreview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFeedConf";
            this.Text = "Feed Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.panelExtractData.ResumeLayout(false);
            this.panelCreateFeed.ResumeLayout(false);
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSourceURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadSource;
        private System.Windows.Forms.TextBox textBoxSourceCode;
        private System.Windows.Forms.TextBox textBoxSourceEncoding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGlobalSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxItemSP;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.TextBox textBoxExtractedData;
        private System.Windows.Forms.Label labelExtractResult;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxItemDescription;
        private System.Windows.Forms.TextBox textBoxItemLink;
        private System.Windows.Forms.TextBox textBoxItemTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Panel panelExtractData;
        private System.Windows.Forms.Panel panelCreateFeed;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.Button buttonBackFromCreateFeed;
        private System.Windows.Forms.Button buttonBackFromPreview;
        private System.Windows.Forms.Button buttonExtractDataHelp;
        private System.Windows.Forms.ToolTip toolTipExtractDataHelp;
    }
}

