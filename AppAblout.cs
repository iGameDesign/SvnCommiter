using System;		   				 	
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SvnCommiter			 	 	 	 	
{
    public partial class AppAblout : UserControl									 	
    {
        Uri m_Url;

        public AppAblout()
        {				  			 	
            InitializeComponent();
        }

        public string Url				 				 	
        {
            set			   			 	
            {
                m_Url = new Uri(value);
            }
        }

        public void Activate()
        {
            if (m_Url == null)
                return;
									 	
            m_WebBrowser.Navigate(m_Url);
        }       

        private void AppAblout_Load(object sender, EventArgs e)
        {            
            Activate();           									 	
        }
    }
}
