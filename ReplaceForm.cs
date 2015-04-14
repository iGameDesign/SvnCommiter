using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SvnCommiter			 	 	 	 	
{
    public delegate void replaceEventHandler(object sender, SearchEventArgs f);
    public partial class ReplaceForm : Form
    {
        public string ReplaceFromTextBox
        {
            get { return m_ReplaceFromTextBox.Text; }
            set { m_ReplaceFromTextBox.Text = value; }
        }				  			 	

        private SearchEventArgs seaf = new SearchEventArgs();
        public event replaceEventHandler Replace;

        public ReplaceForm()
        {
            InitializeComponent();		  	 			 	
        }
			   	 	 	
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_ReplaceButton_Click(object sender, EventArgs e)
        {
            seaf.Replacestring = m_ReplaceToTextBox.Text;
            seaf.Searchstring = m_ReplaceFromTextBox.Text;
            SearchEventArgs.Replaceed = false;
            OnReplace();
        }

        private void OnReplace()
        {		  					 	
            replaceEventHandler handler = Replace;
            if (handler != null)
            {

                if (handler.Target is System.ComponentModel.ISynchronizeInvoke)
                {							 	 	
                    System.ComponentModel.ISynchronizeInvoke aSynch = handler.Target as System.ComponentModel.ISynchronizeInvoke;
                    if (aSynch.InvokeRequired)
                    {
                        object[] args = new object[] { this, seaf };
                        aSynch.Invoke(handler, args);
                    }
                    else
                    {
                        handler(this, seaf);
                    }
                }
                else
                {

                    handler(this, seaf);
                }
            }									 	
            else
            {
                MessageBox.Show("ÊÂ¼þÎª¿Õ!");
            }

        }

        private void ReplaceForm_Load(object sender, EventArgs e)
        {									 	

        }
    }
}