
namespace SchoolDB
{
    partial class Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Obn = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Obn
            // 
            this.button_Obn.Location = new System.Drawing.Point(502, 424);
            this.button_Obn.Name = "button_Obn";
            this.button_Obn.Size = new System.Drawing.Size(75, 23);
            this.button_Obn.TabIndex = 9;
            this.button_Obn.Text = "Обновить";
            this.button_Obn.UseVisualStyleBackColor = true;
            this.button_Obn.Visible = false;
            this.button_Obn.Click += new System.EventHandler(this.button_Obn_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(502, 395);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(75, 23);
            this.button_Del.TabIndex = 8;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Visible = false;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(421, 395);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Visible = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(340, 395);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Visible = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 372);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button_Obn);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.button_Del);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 450);
            this.panel1.TabIndex = 10;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher";
            this.Text = "Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Obn;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button_Save;
    }
}