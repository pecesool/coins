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
    public partial class registr : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Коллекция.mdb";
        private OleDbConnection myConnection;
        public registr()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && maskedTextBox1.Text != "")
            {
                string log = textBox1.Text;
                string pas = textBox4.Text;
                string name3 = textBox5.Text;
                string name = textBox2.Text;
                string surn = textBox3.Text;
                string phone = maskedTextBox1.Text;
                string query1 = "INSERT INTO авторизация ([Логин], [Имя], [Фамилия], [Отчество], [Телефон], [Пароль]) VALUES ('" + log + "', '" + name + "', '" + surn + "', '" + name3 + "', '" + phone + "', '" + pas + "')";
                OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                command1.ExecuteNonQuery(); this.Close();
            }
            else{ MessageBox.Show("Убедитесь что все поля регистрации заполнены", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
        }
        
    }
}
