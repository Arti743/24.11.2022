
namespace SchoolDB
{
    partial class Auth_Admin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.button_Auth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин";
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(15, 62);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(142, 20);
            this.textBox_Pass.TabIndex = 7;
            this.textBox_Pass.UseSystemPasswordChar = true;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(15, 25);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(142, 20);
            this.textBox_Login.TabIndex = 6;
            // 
            // button_Auth
            // 
            this.button_Auth.BackColor = System.Drawing.Color.Turquoise;
            this.button_Auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Auth.Location = new System.Drawing.Point(46, 104);
            this.button_Auth.Name = "button_Auth";
            this.button_Auth.Size = new System.Drawing.Size(75, 23);
            this.button_Auth.TabIndex = 10;
            this.button_Auth.Text = "Войти";
            this.button_Auth.UseVisualStyleBackColor = false;
            this.button_Auth.Click += new System.EventHandler(this.button_Auth_Click);
            // 
            // Auth_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(174, 139);
            this.Controls.Add(this.button_Auth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Auth_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auth_Admin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Button button_Auth;
    }
}