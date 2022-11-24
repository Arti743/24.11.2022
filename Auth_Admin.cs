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
    public partial class Auth_Admin : Form
    {
        public static bool Sett = false;
        public Auth_Admin()
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
                const string comand = "SELECT * FROM Auth_Admin WHERE Log_Admin=@Log_Admin AND Pas_Admin=@Pas_Admin";
                SqlCommand check = new SqlCommand(comand, conn);
                check.Parameters.AddWithValue("@Log_Admin", textBox_Login.Text);
                check.Parameters.AddWithValue("@Pas_Admin", textBox_Pass.Text);
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
                Shedule.Sett = true;
                Teacher.Sett = true;
                Items.Sett = true;
                Shed.Sett = true;
                DataAuth.Sett = true;
                Shedule Win = new Shedule();
                Win.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void Auth_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
