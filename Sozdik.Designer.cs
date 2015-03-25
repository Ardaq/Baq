using Baq_Sozdik.Properties;
namespace Baq_Sozdik
{
    partial class Sozdik
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
        /// 使用代码Edit器修改此方法的Help。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sozdik));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxWithButton1 = new Baq_Sozdik.Controls.TextBoxWithButton();
            this.progressControler1 = new Baq_Sozdik.Controls.ProgressControler();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cyryl = new System.Windows.Forms.ToolStripButton();
            this.tote = new System.Windows.Forms.ToolStripButton();
            this.latin = new System.Windows.Forms.ToolStripButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveasAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CutTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PastePToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectallAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxWithButton1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressControler1);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.TabStop = false;
            this.listBox1.UseTabStops = false;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // textBoxWithButton1
            // 
            resources.ApplyResources(this.textBoxWithButton1, "textBoxWithButton1");
            this.textBoxWithButton1.Name = "textBoxWithButton1";
            this.textBoxWithButton1.BClick += new System.EventHandler(this.textBoxWithButton1_BClick);
            this.textBoxWithButton1.TextBChanged += new System.EventHandler(this.textBoxWithButton1_TextBChanged);
            // 
            // progressControler1
            // 
            this.progressControler1.BackColor = System.Drawing.SystemColors.Window;
            this.progressControler1.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.progressControler1, "progressControler1");
            this.progressControler1.Name = "progressControler1";
            this.progressControler1.NumberOfVisibleCircles = 5;
            this.progressControler1.Percentage = 0F;
            this.progressControler1.ShowText = true;
            this.progressControler1.TextDisplay = Baq_Sozdik.Controls.TextDisplayModes.Text;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator6,
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1,
            this.toolStripSeparator7,
            this.selectAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.cut_64;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.copy_64;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.paste_64;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Image = global::Baq_Sozdik.Properties.Resources.undo_64;
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            resources.ApplyResources(this.undoToolStripMenuItem1, "undoToolStripMenuItem1");
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem1_Click);
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Image = global::Baq_Sozdik.Properties.Resources.redo_64;
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            resources.ApplyResources(this.redoToolStripMenuItem1, "redoToolStripMenuItem1");
            this.redoToolStripMenuItem1.Click += new System.EventHandler(this.redoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.selectall_64;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cyryl,
            this.tote,
            this.latin});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // cyryl
            // 
            this.cyryl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cyryl.Name = "cyryl";
            resources.ApplyResources(this.cyryl, "cyryl");
            this.cyryl.Click += new System.EventHandler(this.cyryl_Click);
            // 
            // tote
            // 
            this.tote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tote.Name = "tote";
            resources.ApplyResources(this.tote, "tote");
            this.tote.Click += new System.EventHandler(this.tote_Click);
            // 
            // latin
            // 
            this.latin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.latin.Name = "latin";
            resources.ApplyResources(this.latin, "latin");
            this.latin.Click += new System.EventHandler(this.latin_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFToolStripMenuItem,
            this.EditEToolStripMenuItem,
            this.ToolTToolStripMenuItem,
            this.HelpHToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileFToolStripMenuItem
            // 
            this.FileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeNToolStripMenuItem,
            this.OpenOToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveasAToolStripMenuItem,
            this.SaveSToolStripMenuItem,
            this.toolStripSeparator1,
            this.printPreviewToolStripMenuItem,
            this.PrintPToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitXToolStripMenuItem});
            this.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem";
            resources.ApplyResources(this.FileFToolStripMenuItem, "FileFToolStripMenuItem");
            // 
            // HomeNToolStripMenuItem
            // 
            this.HomeNToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.home;
            this.HomeNToolStripMenuItem.Name = "HomeNToolStripMenuItem";
            resources.ApplyResources(this.HomeNToolStripMenuItem, "HomeNToolStripMenuItem");
            this.HomeNToolStripMenuItem.Click += new System.EventHandler(this.HomeNToolStripMenuItem_Click);
            // 
            // OpenOToolStripMenuItem
            // 
            resources.ApplyResources(this.OpenOToolStripMenuItem, "OpenOToolStripMenuItem");
            this.OpenOToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.folder_green;
            this.OpenOToolStripMenuItem.Name = "OpenOToolStripMenuItem";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // SaveasAToolStripMenuItem
            // 
            this.SaveasAToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.html_64;
            this.SaveasAToolStripMenuItem.Name = "SaveasAToolStripMenuItem";
            resources.ApplyResources(this.SaveasAToolStripMenuItem, "SaveasAToolStripMenuItem");
            this.SaveasAToolStripMenuItem.Click += new System.EventHandler(this.SaveasAToolStripMenuItem_Click);
            // 
            // SaveSToolStripMenuItem
            // 
            this.SaveSToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.pdf_64;
            this.SaveSToolStripMenuItem.Name = "SaveSToolStripMenuItem";
            resources.ApplyResources(this.SaveSToolStripMenuItem, "SaveSToolStripMenuItem");
            this.SaveSToolStripMenuItem.Click += new System.EventHandler(this.SaveSToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.perview_64;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            resources.ApplyResources(this.printPreviewToolStripMenuItem, "printPreviewToolStripMenuItem");
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // PrintPToolStripMenuItem
            // 
            this.PrintPToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.print_64;
            this.PrintPToolStripMenuItem.Name = "PrintPToolStripMenuItem";
            resources.ApplyResources(this.PrintPToolStripMenuItem, "PrintPToolStripMenuItem");
            this.PrintPToolStripMenuItem.Click += new System.EventHandler(this.PrintPToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // ExitXToolStripMenuItem
            // 
            this.ExitXToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.exit;
            this.ExitXToolStripMenuItem.Name = "ExitXToolStripMenuItem";
            resources.ApplyResources(this.ExitXToolStripMenuItem, "ExitXToolStripMenuItem");
            this.ExitXToolStripMenuItem.Click += new System.EventHandler(this.ExitXToolStripMenuItem_Click);
            // 
            // EditEToolStripMenuItem
            // 
            this.EditEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.CutTToolStripMenuItem,
            this.CopyCToolStripMenuItem,
            this.PastePToolStripMenuItem,
            this.toolStripSeparator4,
            this.SelectallAToolStripMenuItem});
            this.EditEToolStripMenuItem.Name = "EditEToolStripMenuItem";
            resources.ApplyResources(this.EditEToolStripMenuItem, "EditEToolStripMenuItem");
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.undo_64;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.redo_64;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // CutTToolStripMenuItem
            // 
            this.CutTToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.cut_64;
            this.CutTToolStripMenuItem.Name = "CutTToolStripMenuItem";
            resources.ApplyResources(this.CutTToolStripMenuItem, "CutTToolStripMenuItem");
            this.CutTToolStripMenuItem.Click += new System.EventHandler(this.CutTToolStripMenuItem_Click);
            // 
            // CopyCToolStripMenuItem
            // 
            this.CopyCToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.copy_64;
            this.CopyCToolStripMenuItem.Name = "CopyCToolStripMenuItem";
            resources.ApplyResources(this.CopyCToolStripMenuItem, "CopyCToolStripMenuItem");
            this.CopyCToolStripMenuItem.Click += new System.EventHandler(this.CopyCToolStripMenuItem_Click);
            // 
            // PastePToolStripMenuItem
            // 
            this.PastePToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.paste_64;
            this.PastePToolStripMenuItem.Name = "PastePToolStripMenuItem";
            resources.ApplyResources(this.PastePToolStripMenuItem, "PastePToolStripMenuItem");
            this.PastePToolStripMenuItem.Click += new System.EventHandler(this.PastePToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // SelectallAToolStripMenuItem
            // 
            this.SelectallAToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.selectall_64;
            this.SelectallAToolStripMenuItem.Name = "SelectallAToolStripMenuItem";
            resources.ApplyResources(this.SelectallAToolStripMenuItem, "SelectallAToolStripMenuItem");
            this.SelectallAToolStripMenuItem.Tag = "";
            this.SelectallAToolStripMenuItem.Click += new System.EventHandler(this.SelectallAToolStripMenuItem_Click);
            // 
            // ToolTToolStripMenuItem
            // 
            this.ToolTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsOToolStripMenuItem});
            this.ToolTToolStripMenuItem.Name = "ToolTToolStripMenuItem";
            resources.ApplyResources(this.ToolTToolStripMenuItem, "ToolTToolStripMenuItem");
            // 
            // SettingsOToolStripMenuItem
            // 
            this.SettingsOToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.settings_icon;
            this.SettingsOToolStripMenuItem.Name = "SettingsOToolStripMenuItem";
            resources.ApplyResources(this.SettingsOToolStripMenuItem, "SettingsOToolStripMenuItem");
            this.SettingsOToolStripMenuItem.Click += new System.EventHandler(this.SettingsOToolStripMenuItem_Click);
            // 
            // HelpHToolStripMenuItem
            // 
            this.HelpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpCToolStripMenuItem,
            this.toolStripSeparator5,
            this.AboutAToolStripMenuItem});
            this.HelpHToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.FAQ_icon;
            this.HelpHToolStripMenuItem.Name = "HelpHToolStripMenuItem";
            resources.ApplyResources(this.HelpHToolStripMenuItem, "HelpHToolStripMenuItem");
            // 
            // HelpCToolStripMenuItem
            // 
            this.HelpCToolStripMenuItem.Image = global::Baq_Sozdik.Properties.Resources.FAQ_icon;
            this.HelpCToolStripMenuItem.Name = "HelpCToolStripMenuItem";
            resources.ApplyResources(this.HelpCToolStripMenuItem, "HelpCToolStripMenuItem");
            this.HelpCToolStripMenuItem.Click += new System.EventHandler(this.HelpCToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // AboutAToolStripMenuItem
            // 
            this.AboutAToolStripMenuItem.Name = "AboutAToolStripMenuItem";
            resources.ApplyResources(this.AboutAToolStripMenuItem, "AboutAToolStripMenuItem");
            this.AboutAToolStripMenuItem.Click += new System.EventHandler(this.AboutAToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Sozdik
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sozdik";
            this.Load += new System.EventHandler(this.Sozdik_Load);
            this.SizeChanged += new System.EventHandler(this.Sozdik_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Baq_Sozdik.Controls.TextBoxWithButton textBoxWithButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem FileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomeNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveasAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PrintPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CutTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PastePToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem SelectallAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem AboutAToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton cyryl;
        private System.Windows.Forms.ToolStripButton tote;
        private System.Windows.Forms.ToolStripButton latin;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Controls.ProgressControler progressControler1;
    }
}

