using System;
using System.Collections.Generic;		   				 	
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;		 		 	 	 	
using System.Windows.Forms;		   		 	 	

namespace SvnCommiter
{			   	 	 	
    public partial class Browser : Form					 			 	
    {
        int m_IssueType;
        byte[] m_Post = null;
        public Browser(string fileList, int issueType)
        {
            InitializeComponent();
            string post = string.Format("CommitFiles=\r\n{0}", fileList);
            m_Post = Encoding.UTF8.GetBytes(post);
            m_IssueType = issueType;
        }			 	 			 	
									 	
        private void Browser_Load(object sender, EventArgs e)
        {
            m_Browser.Navigate(string.Format("{0}?IssueType={1}", Global.Config.CommitUrl,  m_IssueType), null, m_Post, "Content-Type: application/x-www-form-urlencoded\r\n");           
        }
    }									 	
}