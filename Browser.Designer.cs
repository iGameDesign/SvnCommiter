namespace SvnCommiter
{
    partial class Browser
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {		 	 		 	 	
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.m_Browser = new System.Windows.Forms.WebBrowser();			 			 	 	
            this.SuspendLayout();
            // 
            // m_Browser
            // 
            this.m_Browser.Dock = System.Windows.Forms.DockStyle.Fill;		 						 	
            this.m_Browser.Location = new System.Drawing.Point(0, 0);
            this.m_Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.m_Browser.Name = "m_Browser";
            this.m_Browser.Size = new System.Drawing.Size(879, 702);
            this.m_Browser.TabIndex = 0;			 			 	 	
            this.m_Browser.Url = new System.Uri("http://www.886s.com", System.UriKind.Absolute);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 702);
            this.Controls.Add(this.m_Browser);					 			 	
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser";
            this.Text = "Head提交单";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.ResumeLayout(false);				 				 	
									 	
        }

        #endregion
									 	
        private System.Windows.Forms.WebBrowser m_Browser;
    }
}