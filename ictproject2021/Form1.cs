using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ictproject2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'коллекцияDataSet11.старинные_монеты' table. You can move, or remove it, as needed.
            this.старинные_монетыTableAdapter.Fill(this.коллекцияDataSet11.старинные_монеты);
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aboutp s1 = new aboutp();
            s1.Show();
            this.Hide();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            redakt af = new redakt();
            af.Owner = this;
            af.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            poisk af = new poisk();
            af.Owner = this;
            af.Show();
        }
    }
}
