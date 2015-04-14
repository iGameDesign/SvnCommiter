using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Xml;
using System.Web;

namespace SvnCommiter
{
    enum SvnStateType
    {
        None,
        Add,
        Modify,
        Delete
    }

    public partial class SvnCommiterUI : Form
    {
        const string FormText = "Svn Commiter工具";
        const string StrTarget = "target";
        const string StrEntry = "entry";
        const string StrUrl = "url";
        const string WC_Status = "wc-status";

        SortedList<SvnStateType, List<string>> m_ResultList;
        ThumbnailToolbarButton m_CommitThumbnail;
        ThumbnailToolbarButton m_ChangeThumbnail;

        public SvnCommiterUI()
        {
            InitializeComponent();
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            if (m_FolderPathDialog.ShowDialog() != DialogResult.OK)
                return;

            if (string.IsNullOrEmpty(m_FoldPath.Text))
                m_FoldPath.Text = m_FolderPathDialog.SelectedPath;
            else
                m_FoldPath.Text = string.Format("{0}\r\n{1}", m_FoldPath.Text, m_FolderPathDialog.SelectedPath);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_FoldPath.Text))
                return;

            if (Global.Config.FoldPaths != m_FoldPath.Text)
            {
                Global.Config.FoldPaths = m_FoldPath.Text;
                Global.Config.Save();
            }

            lock (this)
            {
                if (m_BackgroundWorker.IsBusy)
                {
                    MessageBox.Show("程序正在执行，请稍后重试");
                }
                else
                {
                    this.m_FlieList.Clear();
                    this.m_FlieList.Text = "正在查找请稍候..........";
                    this.Text = string.Format("{0}     正在执行......", FormText);

                    SetControlsIsEnable(false);

                    m_BackgroundWorker.RunWorkerAsync(m_FoldPath.Lines);
                }
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {            
            if (m_FlieList.Text.Contains("client/settings"))
                MessageBox.Show("你的改动和游戏逻辑的配置相关，请确保已使用剑三资源检查工具自测");
            Browser browser = new Browser(m_FlieList.Text, 601);
            browser.ShowDialog();
        }

        private void ShowTypeCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFileList();
        }

        private void ShowFileList()
        {
            string szCheckeType;
            List<string> fileList = new List<string>();

            for (int i = 0; i < m_ShowTypeCheckedList.CheckedItems.Count; i++)
            {				 		 	 	
                szCheckeType = m_ShowTypeCheckedList.CheckedItems[i].ToString();

                switch (szCheckeType)
                {
                    case "修改":
                        fileList.AddRange(m_ResultList[SvnStateType.Modify]);
                        break;

                    case "新增":
                        fileList.AddRange(m_ResultList[SvnStateType.Add]);
                        break;

                    case "删除":
                        fileList.AddRange(m_ResultList[SvnStateType.Delete]);
                        break;

                    default:
                        fileList.AddRange(m_ResultList[SvnStateType.None]);
                        break;
                }
            }

            m_FlieList.Lines = fileList.ToArray();
        }

        private void ResultListClear()
        {
            m_ResultList = new SortedList<SvnStateType, List<string>>();
            foreach (object obj in Enum.GetValues(typeof(SvnStateType)))
            {
                m_ResultList[(SvnStateType)obj] = new List<string>();
            }
        }

        private void FoldPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null)
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FoldPath_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                List<string> lines = new List<string>();
                lines.AddRange(m_FoldPath.Lines);

                TextBox textBox = (TextBox)sender;
                Array array = (Array)e.Data.GetData(DataFormats.FileDrop);

                foreach (object o in array)
                {
                    lines.Add(o.ToString());
                }

                m_FoldPath.Lines = lines.ToArray();
            }
            catch
            {

            }
        }

        private void SvnCommiterUI_Load(object sender, EventArgs e)
        {
            Base.AppUseStatistics.Send("SvnCommiter");

            ResultListClear();
            for (int i = 0; i < m_ShowTypeCheckedList.Items.Count; i++)
            {
                if (m_ShowTypeCheckedList.Items[i].ToString() != "其他")
                    m_ShowTypeCheckedList.SetItemChecked(i, true);
                else
                    m_ShowTypeCheckedList.SetItemChecked(i, false);
            }
            m_FoldPath.Text = Global.Config.FoldPaths;

            //win7 
            if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1)
            {
                m_CommitThumbnail = new ThumbnailToolbarButton(SvnCommiter.Properties.Resources.Commit, "创建提交单");
                m_CommitThumbnail.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(Apply_Click);

                m_ChangeThumbnail = new ThumbnailToolbarButton(SvnCommiter.Properties.Resources.Change, "查找变更文件");
                m_ChangeThumbnail.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(Search_Click);

                TaskbarManager.Instance.ThumbnailToolbars.AddButtons(this.Handle, m_ChangeThumbnail, m_CommitThumbnail);
            }           
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceForm replaceform = new ReplaceForm();
            replaceform.Replace += new replaceEventHandler(replace_Replace);
            replaceform.Owner = this;
            replaceform.Show();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultListClear();

            string[] fileNames = (string[])e.Argument;
            foreach (string fileName in fileNames)
            {
                if (string.IsNullOrEmpty(fileName))
                    continue;

                SelectFolders(fileName);
            }
        }

        private void m_BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Text = FormText;

            SetControlsIsEnable(true);

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
                return;
            }

            ShowFileList();		    			 	
        }

        //////////////////////////////////////////////////////
        /// <summary>
        /// 注意，这里用的都是32位的svn.exe
        /// </summary>
        /// <param name="szFileName"></param>
        void SelectFolders(string szFileName)
        {
            string stdout;
            string stderr;

            //// 切换成svn1.6版本的exe
            //File.Delete(Global.Config.SvnPath);
            //File.Copy(Global.Config.Svn6Path, Global.Config.SvnPath, true);
            Run(Global.Config.SvnPath, string.Format("st \"{0}\" --xml", szFileName), out stdout, out stderr);
            //if ((stderr.IndexOf("svn upgrade", StringComparison.OrdinalIgnoreCase) > 0) || (stderr.IndexOf("client is too old", StringComparison.OrdinalIgnoreCase) > 0 ))
            //{
            //    stderr = "";
            //    // 切换成svn1.7版本的exe再重试
            //    File.Delete(Global.Config.SvnPath);
            //    File.Copy(Global.Config.Svn7Path, Global.Config.SvnPath, true);
            //    Run(Global.Config.SvnPath, string.Format("st \"{0}\" --xml", szFileName), out stdout, out stderr);
            //}
            
            if (!string.IsNullOrEmpty(stderr))
            {
                MessageBox.Show("该文件夹没有版本信息！" 
                    + System.Environment.NewLine
                    + "详细错误信息："
                    + stderr, "Svn Commiter工具-提示");
                return;
            }

            try
            {
                XmlReader reader = XmlReader.Create(new StringReader(stdout));
                XmlParse(reader);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        private void XmlParse(XmlReader reader)
        {
            string svnUrl = "";
            string strFilePath = "";
            string strFilePathUrl = "";
            string strEntryUrl = "";
            bool bSvnURlFlag = false;

            while (!reader.EOF)
            {
                if (reader.NodeType != XmlNodeType.Element)
                {
                    reader.Read();
                    continue;
                }

                svnUrl = "";
                bSvnURlFlag = false;

                switch (reader.Name)
                {
                    case StrTarget:
                        strFilePath = reader["path"];
                        bSvnURlFlag = TryChangeToSvnUrl(strFilePath, out strFilePathUrl);
                        break;

                    case StrEntry:
                        string StrSubPath = "";

                        bSvnURlFlag = TryChangeToSvnUrl(reader["path"], out svnUrl);
                        if (!bSvnURlFlag)
                        {
                            StrSubPath = reader["path"];
                            if (StrSubPath.Length > strFilePath.Length)
                            {
                                StrSubPath = StrSubPath.Substring(strFilePath.Length, StrSubPath.Length - strFilePath.Length);
                            }
				  	 	 	
                            StrSubPath = StrSubPath.Replace("\\", "/");
                            svnUrl = strFilePathUrl + StrSubPath;
                        }

                        strEntryUrl = svnUrl;
                        break;

                    case WC_Status:
                        switch(reader["item"])
                        {
                            case "deleted":
                                m_ResultList[SvnStateType.Delete].Add(strEntryUrl);
                                break;

                            case "modified":
                                m_ResultList[SvnStateType.Modify].Add(strEntryUrl);
                                break;

                            case "added":
                                m_ResultList[SvnStateType.Add].Add(strEntryUrl);
                                break;

                            default:
                                m_ResultList[SvnStateType.None].Add(strEntryUrl);
                                break;
                        }
                        break;
                    default:
                        break;
                }
                reader.Read();		    			 	
            }
            reader.Close();
        }                            

        static bool TryChangeToSvnUrl(string szFileName, out string svnUrl)
        {
            string stdout;
            string stderr;
            svnUrl = "";

            Run(Global.Config.SvnPath, string.Format("info \"{0}\" --xml", szFileName), out stdout, out stderr);
            if (!string.IsNullOrEmpty(stderr))  
                return false;
            
            //有版本信息
            XmlReader reader = XmlReader.Create(new StringReader(stdout));
            while (!reader.EOF)
            {
                if (reader.NodeType != XmlNodeType.Element || reader.Name != StrUrl)
                {
                    reader.Read();
                    continue;
                }		 				 	 	

                svnUrl = reader.ReadString();
                reader.Read();
            }
            reader.Close();

            if (string.IsNullOrEmpty(svnUrl))
                return false;

            svnUrl = HttpUtility.UrlDecode(svnUrl);

            return true;
        }      

        static void Run(string filename, string arguments, out string stdout, out string stderr)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = filename;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
                process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                process.Start();
                stdout = process.StandardOutput.ReadToEnd();
                stderr = process.StandardError.ReadToEnd();
                process.WaitForExit();
            }
            finally
            {
                process.Close();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            m_FoldPath.Clear();
        }

        private void SetControlsIsEnable(bool bEnable)
        {
            this.m_Search.Enabled = bEnable;
            this.m_Apply.Enabled = bEnable;
            this.m_Clear.Enabled = bEnable;
            this.m_OpenFolder.Enabled = bEnable;
            this.m_ShowTypeCheckedList.Enabled = bEnable;
        }

        private void replace_Replace(object sender, SearchEventArgs f)
        {
            StringBuilder builder = new StringBuilder();					 	 	 	
            string selectedText = m_FlieList.SelectedText;
            if (string.IsNullOrEmpty(selectedText))
                return;

            selectedText = selectedText.Replace(f.Searchstring, f.Replacestring);

            string stringBeg = m_FlieList.Text.Substring(0, m_FlieList.SelectionStart);
            string stringEnd = m_FlieList.Text.Substring(m_FlieList.SelectionStart + m_FlieList.SelectionLength, m_FlieList.Text.Length - m_FlieList.SelectionStart - m_FlieList.SelectionLength);
            builder.AppendFormat("{0}{1}{2}", stringBeg, selectedText, stringEnd);

            m_FlieList.Text = builder.ToString();									 	
        }

        private void m_Publish_Click(object sender, EventArgs e)
        {
            if (m_FlieList.Text.Contains("client/settings"))
                MessageBox.Show("你的改动和游戏逻辑的配置相关，请确保已使用剑三资源检查工具自测");
            Browser browser = new Browser(m_FlieList.Text, 401);
            browser.ShowDialog();
        }

    }

    static class Global
    {
        public static Config Config
        {
            get
            {
                if (m_Config == null)
                    m_Config = new Config();
                return m_Config;									 	
            }
        }
        static Config m_Config;
    }
}