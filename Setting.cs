using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baq_Sozdik
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioCyrylic.Checked)
            {
                Properties.Settings.Default.Language = "kk-KZ";
            }
            else if (radioLatin.Checked)
            {
                Properties.Settings.Default.Language = "kk";
            }
            else if (radioTote.Checked)
            {
                Properties.Settings.Default.Language = "kk-CN";
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.Language == "kk-KZ")
            {
                radioCyrylic.Checked = true;
            }
            if (Properties.Settings.Default.Language == "kk")
            {
                radioLatin.Checked = true;
            }
            if (Properties.Settings.Default.Language == "kk-CN")
            {
                radioTote.Checked = true;
            }
        }
    }
}
