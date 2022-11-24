using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDB
{
    public partial class Shedule : Form
    {
        public static bool Sett;
        public Shedule()
        {
            InitializeComponent();
            button_DataAuth.Visible = Shedule.Sett;
        }

        private void Shedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void openchild(Panel pen, Form emptyF)
        {
            emptyF.TopLevel = false;
            emptyF.FormBorderStyle = FormBorderStyle.None;
            emptyF.Dock = DockStyle.Fill;
            pen.Controls.Add(emptyF);
            emptyF.BringToFront();
            emptyF.Show();
        }

        private void button_she_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Shed());
        }

        private void button_teach_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Teacher());
        }

        private void button_pred_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Items());
        }

        public void button_DataAuth_Click(object sender, EventArgs e)
        {
            openchild(panel2, new DataAuth());
        }

        private void button_ExitAcc_Click(object sender, EventArgs e)
        {
            Form_Auth Win = new Form_Auth();
            Win.Show();
            this.Hide();
        }
    }
}
