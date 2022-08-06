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
    public partial class poisk : Form
    {
        public poisk()
        {
            InitializeComponent();
        }

        private void poisk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'коллекцияDataSet.старинные_монеты' table. You can move, or remove it, as needed.
            this.старинные_монетыTableAdapter.Fill(this.коллекцияDataSet.старинные_монеты);
            изображениеDataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
        bool res = true;
        private void button2_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "да") { res = true; } else { res = false; }
            int k = 0;
            string poisk = "";
            if (textBox1.Text != "")
            {
                k++;
                if (k > 1)
                {
                    poisk += " AND ";
                }
                poisk += "[Название монеты] LIKE'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                k++;
                if (k > 1)
                {
                    poisk += " AND ";
                }
                poisk += "[Страна] LIKE'%" + textBox2.Text + "%'";
            }
            if (textBox3.Text != "")
            {
                k++;
                if (k > 1)
                {
                    poisk += " AND ";
                }
                poisk += "[Материал] LIKE'%" + textBox3.Text + "%'";
            }
            if (textBox4.Text != "")
            {
                k++;
                if (k > 1)
                {
                    poisk += " AND ";
                }
                poisk += "[Масса]=" + Convert.ToInt32(textBox4.Text);
            }
            if (comboBox1.Text != "")
            {
                k++;
                if (k > 1)
                {
                    poisk += " AND ";
                }if (res == true)
                {
                    poisk += старинныеМонетыBindingSource.Filter = "[Памятная монета] = 1";
                }else { poisk += старинныеМонетыBindingSource.Filter = "[Памятная монета] = 0"; }
            }
            if (k >= 1)
            {
                старинныеМонетыBindingSource.Filter = poisk;
            }
            else
            {
                if (k == 0)
                {
                   старинныеМонетыBindingSource.Filter = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            старинныеМонетыBindingSource.Filter = null;
        }
    }
}
