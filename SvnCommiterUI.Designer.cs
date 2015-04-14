namespace SvnCommiter
{
    partial class SvnCommiterUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SvnCommiterUI));
            this.m_FolderPathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.m_FoldPath = new System.Windows.Forms.TextBox();
            this.m_OpenFolder = new System.Windows.Forms.Button();
            this.m_Search = new System.Windows.Forms.Button();
            this.m_Apply = new System.Windows.Forms.Button();
            this.m_FlieList = new System.Windows.Forms.TextBox();
            this.m_FileListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提交ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ShowTypeCheckedList = new System.Windows.Forms.CheckedListBox();
            this.m_BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.m_Clear = new System.Windows.Forms.Button();
            this.m_Publish = new System.Windows.Forms.Button();
            this.m_FileListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_FoldPath
            // 
            this.m_FoldPath.AllowDrop = true;
            this.m_FoldPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_FoldPath.Location = new System.Drawing.Point(4, 12);
            this.m_FoldPath.Multiline = true;
            this.m_FoldPath.Name = "m_FoldPath";
            this.m_FoldPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_FoldPath.Size = new System.Drawing.Size(760, 60);
            this.m_FoldPath.TabIndex = 0;
            this.m_FoldPath.WordWrap = false;
            this.m_FoldPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.FoldPath_DragDrop);
            this.m_FoldPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.FoldPath_DragEnter);
            // 
            // m_OpenFolder
            // 
            this.m_OpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_OpenFolder.Location = new System.Drawing.Point(771, 12);
            this.m_OpenFolder.Name = "m_OpenFolder";
            this.m_OpenFolder.Size = new System.Drawing.Size(42, 24);
            this.m_OpenFolder.TabIndex = 1;
            this.m_OpenFolder.Text = "...";
            this.m_OpenFolder.UseVisualStyleBackColor = true;
            this.m_OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // m_Search
            // 
            this.m_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Search.Location = new System.Drawing.Point(12, 78);
            this.m_Search.Name = "m_Search";
            this.m_Search.Size = new System.Drawing.Size(59, 21);
            this.m_Search.TabIndex = 2;
            this.m_Search.Text = "查找";
            this.m_Search.UseVisualStyleBackColor = true;
            this.m_Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // m_Apply
            // 
            this.m_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Apply.Enabled = false;
            this.m_Apply.Location = new System.Drawing.Point(77, 78);
            this.m_Apply.Name = "m_Apply";
            this.m_Apply.Size = new System.Drawing.Size(73, 21);
            this.m_Apply.TabIndex = 2;
            this.m_Apply.Text = "创建提交单";
            this.m_Apply.UseVisualStyleBackColor = true;
            this.m_Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // m_FlieList
            // 
            this.m_FlieList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_FlieList.Location = new System.Drawing.Point(4, 143);
            this.m_FlieList.Multiline = true;
            this.m_FlieList.Name = "m_FlieList";
            this.m_FlieList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_FlieList.Size = new System.Drawing.Size(806, 346);
            this.m_FlieList.TabIndex = 3;
            this.m_FlieList.WordWrap = false;
            // 
            // m_FileListMenu
            // 
            this.m_FileListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.提交ToolStripMenuItem});
            this.m_FileListMenu.Name = "m_FileListMenu";
            this.m_FileListMenu.Size = new System.Drawing.Size(149, 48);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem.Text = "替换选中文字";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 提交ToolStripMenuItem
            // 
            this.提交ToolStripMenuItem.Name = "提交ToolStripMenuItem";
            this.提交ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.提交ToolStripMenuItem.Text = "提交";
            // 
            // m_ShowTypeCheckedList
            // 
            this.m_ShowTypeCheckedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ShowTypeCheckedList.CheckOnClick = true;
            this.m_ShowTypeCheckedList.FormattingEnabled = true;
            this.m_ShowTypeCheckedList.Items.AddRange(new object[] {
            "新增",
            "修改",
            "删除",
            "其他"});
            this.m_ShowTypeCheckedList.Location = new System.Drawing.Point(4, 105);
            this.m_ShowTypeCheckedList.MultiColumn = true;
            this.m_ShowTypeCheckedList.Name = "m_ShowTypeCheckedList";
            this.m_ShowTypeCheckedList.Size = new System.Drawing.Size(804, 20);
            this.m_ShowTypeCheckedList.TabIndex = 4;
            this.m_ShowTypeCheckedList.SelectedIndexChanged += new System.EventHandler(this.ShowTypeCheckedList_SelectedIndexChanged);
            // 
            // m_BackgroundWorker
            // 
            this.m_BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.m_BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.m_BackgroundWorker_RunWorkerCompleted);
            // 
            // m_Clear
            // 
            this.m_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Clear.Location = new System.Drawing.Point(771, 48);
            this.m_Clear.Name = "m_Clear";
            this.m_Clear.Size = new System.Drawing.Size(44, 24);
            this.m_Clear.TabIndex = 6;
            this.m_Clear.Text = "清空";
            this.m_Clear.UseVisualStyleBackColor = true;
            this.m_Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // m_Publish
            // 
            this.m_Publish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Publish.Enabled = false;
            this.m_Publish.Location = new System.Drawing.Point(156, 78);
            this.m_Publish.Name = "m_Publish";
            this.m_Publish.Size = new System.Drawing.Size(73, 21);
            this.m_Publish.TabIndex = 7;
            this.m_Publish.Text = "创建发布单";
            this.m_Publish.UseVisualStyleBackColor = true;
            this.m_Publish.Click += new System.EventHandler(this.m_Publish_Click);
            // 
            // SvnCommiterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 491);
            this.Controls.Add(this.m_Publish);
            this.Controls.Add(this.m_Clear);
            this.Controls.Add(this.m_FoldPath);
            this.Controls.Add(this.m_FlieList);
            this.Controls.Add(this.m_OpenFolder);
            this.Controls.Add(this.m_ShowTypeCheckedList);
            this.Controls.Add(this.m_Apply);
            this.Controls.Add(this.m_Search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SvnCommiterUI";
            this.Text = "Svn Committer";
            this.Load += new System.EventHandler(this.SvnCommiterUI_Load);
            this.m_FileListMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog m_FolderPathDialog;
        private System.Windows.Forms.TextBox m_FoldPath;
        private System.Windows.Forms.Button m_OpenFolder;
        private System.Windows.Forms.Button m_Search;
        private System.Windows.Forms.Button m_Apply;
        private System.Windows.Forms.TextBox m_FlieList;
        private System.Windows.Forms.CheckedListBox m_ShowTypeCheckedList;
        private System.Windows.Forms.ContextMenuStrip m_FileListMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker m_BackgroundWorker;
        private System.Windows.Forms.Button m_Clear;
        private System.Windows.Forms.ToolStripMenuItem 提交ToolStripMenuItem;
        private System.Windows.Forms.Button m_Publish;
    }									 	
}

