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
    public partial class redakt : Form
    {
        public redakt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void redakt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'коллекцияDataSet1.старинные_монеты' table. You can move, or remove it, as needed.
            this.старинные_монетыTableAdapter.Fill(this.коллекцияDataSet1.старинные_монеты);
            
            изображениеDataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
            
        }
        bool res = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "да") { res=true; } else { res = false; }
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                DataRow nRow = коллекцияDataSet1.Tables[0].NewRow();
                int rc = dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox4.Text;
                nRow[4] = textBox3.Text;
                nRow[5] = res;
                nRow[6] = img;
                коллекцияDataSet1.Tables[0].Rows.Add(nRow);
                
                старинные_монетыTableAdapter.Adapter.Update(коллекцияDataSet1.старинные_монеты);
                коллекцияDataSet1.Tables[0].AcceptChanges();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Cancel)

            {
                e.Cancel = true;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
