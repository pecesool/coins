using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ictproject2021
{
    public partial class autorizaion : Form
    {

        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Коллекция.mdb";
        private OleDbConnection myConnection;
        public autorizaion()
        {
            
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            textBox2.PasswordChar = '*';
            this.ShowInTaskbar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => OnFrameChanged(sender, e)));
                return;
            }
            ImageAnimator.UpdateFrames();
            Invalidate(false);
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            registr registr = new registr();
            registr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string log = textBox1.Text;
            string pas = textBox2.Text;
            string query = "SELECT COUNT(*) FROM авторизация WHERE Логин='" + log + "' AND Пароль='" + pas + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            int asd = Convert.ToInt32(command.ExecuteScalar());
            if (asd == 1)
            {

                Form1 s = new Form1();
                s.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';

        }
    }
}
