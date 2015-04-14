namespace SvnCommiter
{
    partial class ReplaceForm
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
            this.m_ReplaceFromTextBox = new System.Windows.Forms.TextBox();
            this.m_ReplaceToTextBox = new System.Windows.Forms.TextBox();		    	 	 	
            this.m_ReplaceFromLabel = new System.Windows.Forms.Label();
            this.m_ReplaceToLabel = new System.Windows.Forms.Label();
            this.m_ReplaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ReplaceFromTextBox
            // 
            this.m_ReplaceFromTextBox.Location = new System.Drawing.Point(91, 13);
            this.m_ReplaceFromTextBox.Name = "m_ReplaceFromTextBox";				  	 	 	
            this.m_ReplaceFromTextBox.Size = new System.Drawing.Size(172, 21);
            this.m_ReplaceFromTextBox.TabIndex = 0;
            // 
            // m_ReplaceToTextBox
            // 
            this.m_ReplaceToTextBox.Location = new System.Drawing.Point(91, 50);
            this.m_ReplaceToTextBox.Name = "m_ReplaceToTextBox";
            this.m_ReplaceToTextBox.Size = new System.Drawing.Size(172, 21);
            this.m_ReplaceToTextBox.TabIndex = 0;			 					 	
            this.m_ReplaceToTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // m_ReplaceFromLabel
            // 
            this.m_ReplaceFromLabel.AutoSize = true;
            this.m_ReplaceFromLabel.Location = new System.Drawing.Point(12, 18);
            this.m_ReplaceFromLabel.Name = "m_ReplaceFromLabel";
            this.m_ReplaceFromLabel.Size = new System.Drawing.Size(71, 12);
            this.m_ReplaceFromLabel.TabIndex = 1;
            this.m_ReplaceFromLabel.Text = "±»Ìæ»»ÄÚÈÝ:";
            // 
            // m_ReplaceToLabel
            // 
            this.m_ReplaceToLabel.AutoSize = true;
            this.m_ReplaceToLabel.Location = new System.Drawing.Point(14, 53);
            this.m_ReplaceToLabel.Name = "m_ReplaceToLabel";
            this.m_ReplaceToLabel.Size = new System.Drawing.Size(47, 12);
            this.m_ReplaceToLabel.TabIndex = 1;
            this.m_ReplaceToLabel.Text = "Ìæ»»Îª:";
            // 
            // m_ReplaceButton
            // 
            this.m_ReplaceButton.Location = new System.Drawing.Point(275, 50);
            this.m_ReplaceButton.Name = "m_ReplaceButton";
            this.m_ReplaceButton.Size = new System.Drawing.Size(53, 20);
            this.m_ReplaceButton.TabIndex = 2;
            this.m_ReplaceButton.Text = "Ìæ»»";
            this.m_ReplaceButton.UseVisualStyleBackColor = true;			 					 	
            this.m_ReplaceButton.Click += new System.EventHandler(this.m_ReplaceButton_Click);
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 99);
            this.Controls.Add(this.m_ReplaceButton);
            this.Controls.Add(this.m_ReplaceToLabel);
            this.Controls.Add(this.m_ReplaceFromLabel);
            this.Controls.Add(this.m_ReplaceToTextBox);
            this.Controls.Add(this.m_ReplaceFromTextBox);									 	
            this.Name = "ReplaceForm";
            this.Text = "Ìæ»»";
            this.Load += new System.EventHandler(this.ReplaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_ReplaceFromTextBox;
        private System.Windows.Forms.TextBox m_ReplaceToTextBox;
        private System.Windows.Forms.Label m_ReplaceFromLabel;									 	
        private System.Windows.Forms.Label m_ReplaceToLabel;
        private System.Windows.Forms.Button m_ReplaceButton;
    }
}