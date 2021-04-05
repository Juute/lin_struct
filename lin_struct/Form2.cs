using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lin_struct
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            button1.Enabled = checkBox.Checked;
        }

        private void button1_click (object sender, EventArgs e)
        {
            Progressbar progressbar = new Progressbar();
            progressbar.Visible = true;
            this.Hide();
        }
    }
}
