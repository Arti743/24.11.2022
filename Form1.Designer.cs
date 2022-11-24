
namespace SchoolDB
{
    partial class Form_Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.button_Auth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(30, 26);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(142, 20);
            this.textBox_Login.TabIndex = 0;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(30, 63);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(142, 20);
            this.textBox_Pass.TabIndex = 1;
            this.textBox_Pass.UseSystemPasswordChar = true;
            // 
            // button_Auth
            // 
            this.button_Auth.BackColor = System.Drawing.Color.Turquoise;
            this.button_Auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Auth.Location = new System.Drawing.Point(126, 104);
            this.button_Auth.Name = "button_Auth";
            this.button_Auth.Size = new System.Drawing.Size(75, 23);
            this.button_Auth.TabIndex = 2;
            this.button_Auth.Text = "Войти";
            this.button_Auth.UseVisualStyleBackColor = false;
            this.button_Auth.Click += new System.EventHandler(this.button_Auth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // button_Admin
            // 
            this.button_Admin.BackColor = System.Drawing.Color.Turquoise;
            this.button_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Admin.Location = new System.Drawing.Point(12, 104);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(105, 23);
            this.button_Admin.TabIndex = 6;
            this.button_Admin.Text = "Войти как Админ";
            this.button_Admin.UseVisualStyleBackColor = false;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // Form_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(211, 139);
            this.Controls.Add(this.button_Admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Auth);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Auth_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Button button_Auth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Admin;
    }
}

