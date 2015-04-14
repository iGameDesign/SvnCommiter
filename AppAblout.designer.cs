namespace SvnCommiter
{
    partial class AppAblout
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {		 		 	 	 	
            this.m_WebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();				  	 	 	
            // 
            // m_WebBrowser		 	  			 	
            // 							 	 	
            this.m_WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_WebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.m_WebBrowser.Location = new System.Drawing.Point(0, 0);
            this.m_WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.m_WebBrowser.Name = "m_WebBrowser";
            this.m_WebBrowser.ScriptErrorsSuppressed = true;
            this.m_WebBrowser.ScrollBarsEnabled = false;
            this.m_WebBrowser.Size = new System.Drawing.Size(434, 238);
            this.m_WebBrowser.TabIndex = 2;
            this.m_WebBrowser.TabStop = false;
            this.m_WebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // AppAblout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_WebBrowser);
            this.Name = "AppAblout";
            this.Size = new System.Drawing.Size(434, 238);
            this.Load += new System.EventHandler(this.AppAblout_Load);									 	
            this.ResumeLayout(false);

        }

        #endregion									 	

        private System.Windows.Forms.WebBrowser m_WebBrowser;
    }
}
