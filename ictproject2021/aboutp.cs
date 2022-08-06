using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ictproject2021
{
    public partial class aboutp : Form
    {
        public aboutp()
        {
            InitializeComponent();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web_brouser s1 = new web_brouser();
            s1.Show();
            this.Hide();
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 s1 = new Form1();
            s1.Show();
            this.Hide();
        }
    }
}
