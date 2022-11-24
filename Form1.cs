using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolDB
{
    public partial class Form_Auth : Form
    {
        public Form_Auth()
        {
            InitializeComponent();
        }

        private void button_Auth_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=192.168.0.7, 3306; Initial Catalog=School; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            bool success = false;
            try
            {
                const string comand = "SELECT * FROM Auth WHERE Log_auth=@Log_auth AND Pwd_auth=@Pwd_auth";
                SqlCommand check = new SqlCommand(comand, conn);
                check.Parameters.AddWithValue("@Log_auth", textBox_Login.Text);
                check.Parameters.AddWithValue("@Pwd_auth", textBox_Pass.Text);
                conn.Open();


                using (var dataReader = check.ExecuteReader())
                {
                    success = dataReader.Read();
                }
            }
            finally
            {
                conn.Close();
            }
            if (success)
            {
                Shedule Win = new Shedule();
                Win.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void Form_Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            Auth_Admin Win = new Auth_Admin();
            Win.Show();
            this.Hide();
        }
    }
}
