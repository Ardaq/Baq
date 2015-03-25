using Baq_Sozdik.Classes;
using Microsoft.Win32;
using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baq_Sozdik
{
    public partial class Sozdik : Form
    {
        private IHTMLDocument2 doc;
        public String wordtt = string.Empty;
        public String naviga = string.Empty;
        public Boolean nav = false;
        public String lang = Thread.CurrentThread.CurrentCulture.Name.ToLower();
        public String member = "Word";

        public Sozdik()
        {
            if (lang == "kk-cn") member = "ArabicWord";
            InitializeComponent();
            this.AcceptButton =this.textBoxWithButton1.button;
            timer1.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = (1000) * (1);              // Timer will tick every 1 second
            timer1.Enabled = true;                       // Enable the timer
            timer1.Start();   
        }

        private void Sozdik_Load(object sender, EventArgs e)
        {

            IEregister.FixBrowserVersion();
            listBox1.DataSource = getWord("");
            listBox1.DisplayMember = member;
            listBox1.ValueMember = member;
            if (lang == "kk-cn") webBrowser1.Navigate(Links.HtmlUrlHomeCN);
            if (lang == "kk-kz") webBrowser1.Navigate(Links.HtmlUrlHomeKZ);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cutToolStripMenuItem.Enabled = IsCommandEnabled("Copy");
            CutTToolStripMenuItem.Enabled = IsCommandEnabled("Copy");
            copyToolStripMenuItem.Enabled = IsCommandEnabled("Copy");
            CopyCToolStripMenuItem.Enabled = IsCommandEnabled("Copy");
            pasteToolStripMenuItem.Enabled = IsCommandEnabled("Paste");
            PastePToolStripMenuItem.Enabled = IsCommandEnabled("Paste");
            redoToolStripMenuItem1.Enabled = IsCommandEnabled("Redo");
            redoToolStripMenuItem.Enabled = IsCommandEnabled("Redo");
            undoToolStripMenuItem1.Enabled = IsCommandEnabled("Undo");
            undoToolStripMenuItem.Enabled = IsCommandEnabled("Undo");
            SelectallAToolStripMenuItem.Enabled = IsCommandEnabled("SelectAll");
            selectAllToolStripMenuItem.Enabled = IsCommandEnabled("SelectAll");
        }

        private void textBoxWithButton1_BClick(object sender, EventArgs e)
        {

            String word = textBoxWithButton1.Text.Trim();
            progressControler1.Visible = true;
            progressControler1.Start();
           
            if (word != "")
            {
                searchWord(word);
                webBrowser1.Navigate(Links.HtmlUrlString);
            }
            progressControler1.Visible = false;
            progressControler1.Stop();
            
        }

        private void searchWord(String word)
        {
            String websource = string.Empty;
            
                switch (lang)
                {
                    case "kk-cn":
                        word = SQLiteHelper.GetWordDictArab(word + " ").Word;
                        websource = HtmlBuilder.GetDict(word, "kk-cn");
                        break;

                    case "kk":
                        websource = HtmlBuilder.GetDict(word, "kk");
                        break;

                    case "kk-kz":
                        websource = HtmlBuilder.GetDict(word, "kk-kz");
                        break;

                    default:
                        websource = HtmlBuilder.GetDict(word, "kk-cyrl");
                        break;
                }
                CreateIndexHtml(websource);
            
        }

        private void CreateIndexHtml(string websource)
        {
            FileStream indexhtml = new FileStream(Links.HtmlUrlString, FileMode.Create);
            StreamWriter indexwrite = new StreamWriter(indexhtml);
            indexwrite.Write(websource);
            indexwrite.Close();
        }

        private void textBoxWithButton1_TextBChanged(object sender, EventArgs e)
        {
            String word = textBoxWithButton1.Text.Trim();
            listBox1.DataSource = getWord(word);
            listBox1.DisplayMember = member;
            listBox1.ValueMember = member;
        }

        private object getWord(string word)
        {
            if(lang == "kk-cn")
            {
                return SQLiteHelper.GetWordListInArabicWord(word);
            }
            else
            {
                return SQLiteHelper.GetWordListInDictionaryWord(word);
            }
        }
                
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            textBoxWithButton1.Text = listBox1.SelectedValue.ToString();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if(nav & naviga != "")
            {
                textBoxWithButton1.Text = naviga;
            }
            naviga = "";
            nav = false;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            webBrowser1.Document.MouseOver += new HtmlElementEventHandler(this.Browser_Mouse_Moved);
        }

        private void Browser_Mouse_Moved(object sender, HtmlElementEventArgs e)
        {
            String element = webBrowser1.Document.GetElementFromPoint(e.ClientMousePosition).GetAttribute("href");
            if(element != "" & element.Contains("#org"))
            {
                String selectword = webBrowser1.Document.GetElementFromPoint(e.ClientMousePosition).InnerText;
                naviga = selectword;
            }
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            nav = true;
            wordtt = webBrowser1.Document.Title;
            doc = (IHTMLDocument2)webBrowser1.Document.DomDocument;
        }

        private void cyryl_Click(object sender, EventArgs e)
        {
            String lang = "kk-cyrl";
            if (wordtt != "")
            {
                String websource = HtmlBuilder.GetDict(wordtt, lang);
                //webControl1.LoadHTML(websource);
                CreateIndexHtml(websource);
                webBrowser1.Navigate(Links.HtmlUrlString);
            }
        }

        private void tote_Click(object sender, EventArgs e)
        {
            String lang = "kk-arab";
            if (wordtt != "")
            {
                String websource = HtmlBuilder.GetDict(wordtt, lang);
                //webControl1.LoadHTML(websource);
                CreateIndexHtml(websource);
                webBrowser1.Navigate(Links.HtmlUrlString);
            }
        }

        private void latin_Click(object sender, EventArgs e)
        {
            String lang = "kk-latn";
            if (wordtt != "")
            {
                String websource = HtmlBuilder.GetDict(wordtt, lang);
                //webControl1.LoadHTML(websource);
                CreateIndexHtml(websource);
                webBrowser1.Navigate(Links.HtmlUrlString);
            }
        }

        private void SaveSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PrintPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                webBrowser1.ShowPrintDialog(); 
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                webBrowser1.ShowPrintPreviewDialog();
            }
        }

        private void SaveasAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                webBrowser1.ShowSaveAsDialog();
            }
            else
            {
                MessageBox.Show(Baq_Sozdik.Properties.Resources.ThereIsNoThingsToSave,Baq_Sozdik.Properties.Resources.Warning);
            }
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void HomeNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lang == "kk-cn") webBrowser1.Navigate(Links.HtmlUrlHomeCN);
            if (lang == "kk-kz") webBrowser1.Navigate(Links.HtmlUrlHomeKZ);
        }

        private void CutTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void CopyCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void PastePToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void SelectallAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
            
        }

        public void SelectAll()
        {
            webBrowser1.Document.ExecCommand("SelectAll", false, null);
        }

        public void Undo()
        {
            webBrowser1.Document.ExecCommand("Undo", false, null);
        }

        public void Redo()
        {
            webBrowser1.Document.ExecCommand("Redo", false, null);
        }

        public void Cut()
        {
            webBrowser1.Document.ExecCommand("Cut", false, null);
        }

        public void Paste()
        {
            webBrowser1.Document.ExecCommand("Paste", false, null);
        }

        public void Copy()
        {
            webBrowser1.Document.ExecCommand("Copy", false, null);
        }

        private bool IsCommandEnabled(string wCmd)
        {

            if (this.doc != null)
                return this.doc.queryCommandEnabled(wCmd);
            return false;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void SettingsOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settings = new Setting();
            settings.ShowDialog();
        }

        private void Sozdik_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide(); 
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void AboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }


        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.Visible = true;

            if ((e.CurrentProgress > 0) && (e.MaximumProgress > 0))
            {

                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);//设置正在加载的文档总字节数

                progressBar1.Step = Convert.ToInt32(e.CurrentProgress);////获取已下载文档的字节数

                progressBar1.PerformStep();

            }

            else if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)//加载完成后隐藏进度条
            {

                progressBar1.Value = 0;

                progressBar1.Visible = false;

            }
        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            progressControler1.Location = new Point((splitContainer1.Panel2.Width - progressControler1.Width) / 2, (splitContainer1.Panel2.Height - progressControler1.Height) / 2);
        }

        private void HelpCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lang == "kk-cn")webBrowser1.Navigate(Links.HtmlUrlHomeCN);
            if (lang == "kk-kz") webBrowser1.Navigate(Links.HtmlUrlHomeKZ);
        }
    }
}
