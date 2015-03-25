using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baq_Sozdik.Controls
{
    public partial class TextBoxWithButton : UserControl
    {
        public TextBoxWithButton()
        {
            InitializeComponent();
        }

        private void TextBoxWithButton_Resize(object sender, EventArgs e)
        {
            this.Height = this.textBox.Height;
            button_Resize(sender, e);
        }

        private void button_Resize(object sender, EventArgs e)
        {
            this.button.Width = this.button.Image.Width + 2;
            textBox_Resize(sender, e);
        }

        private void textBox_Resize(object sender, EventArgs e)
        {
            textBox.Width = this.Width - button.Width;
        }

        [System.ComponentModel.Browsable(true)]
        public override RightToLeft RightToLeft
        {
            get
            {
                return base.RightToLeft;
            }
            set
            {
                base.RightToLeft = value;
            }
        }

        [System.ComponentModel.Browsable(true)]
        public override string Text
        {
            get
            {
                return this.textBox.Text;
            }
            set
            {
                this.textBox.Text = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Category("Action"), Description("TextButton button on click action")]
        [System.ComponentModel.Browsable(true)]
        public event EventHandler BClick;
        private void button_Click(object sender, EventArgs e)
        {
            if (BClick != null) BClick(sender, e);
        }

        [EditorBrowsable(EditorBrowsableState.Always), Category("Behavior"), Description("TextButton textbox text changed behavior")]
        [System.ComponentModel.Browsable(true)]
        public event EventHandler TextBChanged;
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBChanged != null) TextBChanged(sender, e);
        }

        private void TextBoxWithButton_RightToLeftChanged(object sender, EventArgs e)
        {
            this.textBox.Dock = DockStyle.Right;
            this.button.Dock = DockStyle.Left;
        }
    }
}
