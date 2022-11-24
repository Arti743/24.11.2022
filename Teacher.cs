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
    public partial class Teacher : Form
    {
        DataSet data;
        SqlDataAdapter adap;
        SqlCommandBuilder command;
        string connectionString = @"Data Source=192.168.0.7, 3306; Initial Catalog=School; Integrated Security=True";
        string sql = "SELECT * FROM Teacher";
        public static bool Sett;
        public Teacher()
        {
            InitializeComponent();
            button_Save.Visible = Teacher.Sett;
            button_Add.Visible = Teacher.Sett;
            button_Del.Visible = Teacher.Sett;
            button_Obn.Visible = Teacher.Sett;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adap = new SqlDataAdapter(sql, connection);

                data = new DataSet();
                adap.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
        }

        public void button_Save_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                {
                    connection.Open();
                    adap = new SqlDataAdapter(sql, connection);
                    command = new SqlCommandBuilder(adap);
                    adap.InsertCommand = new SqlCommand("ADD_Teacher", connection);
                    adap.InsertCommand.CommandType = CommandType.StoredProcedure;
                    adap.InsertCommand.Parameters.Add(new SqlParameter("@Name_teacher", SqlDbType.VarChar, 100, "Name_teacher"));
                    adap.InsertCommand.Parameters.Add(new SqlParameter("@Exp_teacher", SqlDbType.VarChar, 20, "Exp_teacher"));
                    adap.InsertCommand.Parameters.Add(new SqlParameter("@Auth_teacher", SqlDbType.Int, 0, "Auth_teacher"));


                    adap.Update(data);
                }
            }
        }

        public void button_Add_Click(object sender, EventArgs e)
        {
            DataRow row = data.Tables[0].NewRow();
            data.Tables[0].Rows.Add(row);
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        void openchild(Panel pen, Form empryF)
        {
            empryF.TopLevel = false;
            empryF.FormBorderStyle = FormBorderStyle.None;
            empryF.Dock = DockStyle.Fill;
            pen.Controls.Add(empryF);
            empryF.BringToFront();
            empryF.Show();
        }

        public void button_Obn_Click(object sender, EventArgs e)
        {
            openchild(panel1, new Teacher());
        }
    }
}
