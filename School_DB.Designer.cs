
namespace SchoolDB
{
    partial class Shedule
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
            this.button_she = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_teach = new System.Windows.Forms.Button();
            this.button_pred = new System.Windows.Forms.Button();
            this.button_DataAuth = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_ExitAcc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_she
            // 
            this.button_she.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_she.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_she.Location = new System.Drawing.Point(0, 0);
            this.button_she.Name = "button_she";
            this.button_she.Size = new System.Drawing.Size(206, 42);
            this.button_she.TabIndex = 0;
            this.button_she.Text = "Расписание";
            this.button_she.UseVisualStyleBackColor = true;
            this.button_she.Click += new System.EventHandler(this.button_she_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_DataAuth);
            this.panel1.Controls.Add(this.button_ExitAcc);
            this.panel1.Controls.Add(this.button_pred);
            this.panel1.Controls.Add(this.button_teach);
            this.panel1.Controls.Add(this.button_she);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 450);
            this.panel1.TabIndex = 1;
            // 
            // button_teach
            // 
            this.button_teach.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_teach.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_teach.Location = new System.Drawing.Point(0, 42);
            this.button_teach.Name = "button_teach";
            this.button_teach.Size = new System.Drawing.Size(206, 42);
            this.button_teach.TabIndex = 1;
            this.button_teach.Text = "Учителя";
            this.button_teach.UseVisualStyleBackColor = true;
            this.button_teach.Click += new System.EventHandler(this.button_teach_Click);
            // 
            // button_pred
            // 
            this.button_pred.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_pred.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_pred.Location = new System.Drawing.Point(0, 84);
            this.button_pred.Name = "button_pred";
            this.button_pred.Size = new System.Drawing.Size(206, 42);
            this.button_pred.TabIndex = 2;
            this.button_pred.Text = "Предметы";
            this.button_pred.UseVisualStyleBackColor = true;
            this.button_pred.Click += new System.EventHandler(this.button_pred_Click);
            // 
            // button_DataAuth
            // 
            this.button_DataAuth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_DataAuth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_DataAuth.Location = new System.Drawing.Point(0, 361);
            this.button_DataAuth.Name = "button_DataAuth";
            this.button_DataAuth.Size = new System.Drawing.Size(206, 45);
            this.button_DataAuth.TabIndex = 3;
            this.button_DataAuth.Text = "Данные авторизации";
            this.button_DataAuth.UseVisualStyleBackColor = true;
            this.button_DataAuth.Click += new System.EventHandler(this.button_DataAuth_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 450);
            this.panel2.TabIndex = 2;
            // 
            // button_ExitAcc
            // 
            this.button_ExitAcc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_ExitAcc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ExitAcc.Location = new System.Drawing.Point(0, 406);
            this.button_ExitAcc.Name = "button_ExitAcc";
            this.button_ExitAcc.Size = new System.Drawing.Size(206, 40);
            this.button_ExitAcc.TabIndex = 4;
            this.button_ExitAcc.Text = "Выйти из аккаунта";
            this.button_ExitAcc.UseVisualStyleBackColor = true;
            this.button_ExitAcc.Click += new System.EventHandler(this.button_ExitAcc_Click);
            // 
            // Shedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Shedule";
            this.Text = "Shedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shedule_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_she;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_pred;
        private System.Windows.Forms.Button button_teach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_ExitAcc;
        private System.Windows.Forms.Button button_DataAuth;
    }
}