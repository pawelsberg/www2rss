namespace Pawelsberg.Www2Rss
{
    partial class FormFeedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFeedList));
            this.listViewFeeds = new System.Windows.Forms.ListView();
            this.columnHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSourceURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemFeedList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemServerConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFeeds
            // 
            this.listViewFeeds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFile,
            this.columnHeaderTitle,
            this.columnHeaderSourceURL});
            this.listViewFeeds.FullRowSelect = true;
            this.listViewFeeds.Location = new System.Drawing.Point(16, 15);
            this.listViewFeeds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewFeeds.MultiSelect = false;
            this.listViewFeeds.Name = "listViewFeeds";
            this.listViewFeeds.Size = new System.Drawing.Size(676, 493);
            this.listViewFeeds.TabIndex = 0;
            this.listViewFeeds.UseCompatibleStateImageBehavior = false;
            this.listViewFeeds.View = System.Windows.Forms.View.Details;
            this.listViewFeeds.ItemActivate += new System.EventHandler(this.listViewFeeds_ItemActivate);
            this.listViewFeeds.SelectedIndexChanged += new System.EventHandler(this.listViewFeeds_SelectedIndexChanged);
            // 
            // columnHeaderFile
            // 
            this.columnHeaderFile.Text = "File";
            this.columnHeaderFile.Width = 120;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 200;
            // 
            // columnHeaderSourceURL
            // 
            this.columnHeaderSourceURL.Text = "Source URL";
            this.columnHeaderSourceURL.Width = 300;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(16, 518);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add ...";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(593, 518);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.Location = new System.Drawing.Point(124, 518);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 28);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit ...";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpen.Location = new System.Drawing.Point(232, 518);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(140, 28);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open in browser";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WWW2RSS";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFeedList,
            this.toolStripMenuItemServerConfiguration,
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripNotifyIcon.ShowImageMargin = false;
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(281, 104);
            this.contextMenuStripNotifyIcon.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripNotifyIcon_ItemClicked);
            // 
            // toolStripMenuItemFeedList
            // 
            this.toolStripMenuItemFeedList.Name = "toolStripMenuItemFeedList";
            this.toolStripMenuItemFeedList.Size = new System.Drawing.Size(280, 24);
            this.toolStripMenuItemFeedList.Text = "Feed List ...";
            // 
            // toolStripMenuItemServerConfiguration
            // 
            this.toolStripMenuItemServerConfiguration.Name = "toolStripMenuItemServerConfiguration";
            this.toolStripMenuItemServerConfiguration.Size = new System.Drawing.Size(280, 24);
            this.toolStripMenuItemServerConfiguration.Text = "HTTP Server Configuration ...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(280, 24);
            this.toolStripMenuItemExit.Text = "Exit";
            // 
            // FormFeedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 561);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listViewFeeds);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFeedList";
            this.Text = "WWW2RSS Feed List";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formFeedList_FormClosing);
            this.Shown += new System.EventHandler(this.formFeedList_Shown);
            this.Resize += new System.EventHandler(this.formFeedList_Resize);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFeeds;
        private System.Windows.Forms.ColumnHeader columnHeaderFile;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderSourceURL;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFeedList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemServerConfiguration;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}