namespace Baq_Sozdik.Controls
{
    partial class TextBoxWithButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextBoxWithButton));
            this.textBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.Name = "textBox";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.Resize += new System.EventHandler(this.textBox_Resize);
            // 
            // button
            // 
            resources.ApplyResources(this.button, "button");
            this.button.FlatAppearance.BorderSize = 0;
            this.button.Image = global::Baq_Sozdik.Properties.Resources.Search_icon;
            this.button.Name = "button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            this.button.Resize += new System.EventHandler(this.button_Resize);
            // 
            // TextBoxWithButton
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.Name = "TextBoxWithButton";
            this.RightToLeftChanged += new System.EventHandler(this.TextBoxWithButton_RightToLeftChanged);
            this.Resize += new System.EventHandler(this.TextBoxWithButton_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox;
        public System.Windows.Forms.Button button;

    }
}
