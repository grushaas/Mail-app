namespace Mail_app
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.bt_confirm = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.lb_firstName = new System.Windows.Forms.Label();
            this.lb_lastName = new System.Windows.Forms.Label();
            this.lb_patronymic = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_patronymic = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_confirm
            // 
            this.bt_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.bt_confirm.FlatAppearance.BorderSize = 0;
            this.bt_confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.bt_confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.bt_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_confirm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bt_confirm.ForeColor = System.Drawing.Color.Silver;
            this.bt_confirm.Location = new System.Drawing.Point(272, 352);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(256, 32);
            this.bt_confirm.TabIndex = 7;
            this.bt_confirm.Text = "Принять";
            this.bt_confirm.UseVisualStyleBackColor = false;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // bt_back
            // 
            this.bt_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_back.BackgroundImage")));
            this.bt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_back.FlatAppearance.BorderSize = 0;
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back.Location = new System.Drawing.Point(16, 16);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(32, 24);
            this.bt_back.TabIndex = 8;
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // lb_firstName
            // 
            this.lb_firstName.AutoSize = true;
            this.lb_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_firstName.ForeColor = System.Drawing.Color.LightGray;
            this.lb_firstName.Location = new System.Drawing.Point(8, 8);
            this.lb_firstName.Name = "lb_firstName";
            this.lb_firstName.Size = new System.Drawing.Size(40, 20);
            this.lb_firstName.TabIndex = 9;
            this.lb_firstName.Text = "Имя";
            // 
            // lb_lastName
            // 
            this.lb_lastName.AutoSize = true;
            this.lb_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_lastName.ForeColor = System.Drawing.Color.LightGray;
            this.lb_lastName.Location = new System.Drawing.Point(8, 72);
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(81, 20);
            this.lb_lastName.TabIndex = 10;
            this.lb_lastName.Text = "Фамилия";
            // 
            // lb_patronymic
            // 
            this.lb_patronymic.AutoSize = true;
            this.lb_patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_patronymic.ForeColor = System.Drawing.Color.LightGray;
            this.lb_patronymic.Location = new System.Drawing.Point(8, 136);
            this.lb_patronymic.Name = "lb_patronymic";
            this.lb_patronymic.Size = new System.Drawing.Size(92, 20);
            this.lb_patronymic.TabIndex = 11;
            this.lb_patronymic.Text = "Отчетство";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_password.ForeColor = System.Drawing.Color.LightGray;
            this.lb_password.Location = new System.Drawing.Point(8, 264);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(67, 20);
            this.lb_password.TabIndex = 12;
            this.lb_password.Text = "Пароль";
            // 
            // tb_patronymic
            // 
            this.tb_patronymic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.tb_patronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_patronymic.ForeColor = System.Drawing.Color.Silver;
            this.tb_patronymic.Location = new System.Drawing.Point(8, 168);
            this.tb_patronymic.Name = "tb_patronymic";
            this.tb_patronymic.Size = new System.Drawing.Size(240, 26);
            this.tb_patronymic.TabIndex = 13;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.ForeColor = System.Drawing.Color.Silver;
            this.tb_password.Location = new System.Drawing.Point(8, 296);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(240, 26);
            this.tb_password.TabIndex = 14;
            // 
            // tb_lastName
            // 
            this.tb_lastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.tb_lastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_lastName.ForeColor = System.Drawing.Color.Silver;
            this.tb_lastName.Location = new System.Drawing.Point(8, 104);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(240, 26);
            this.tb_lastName.TabIndex = 15;
            // 
            // tb_firstName
            // 
            this.tb_firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.tb_firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_firstName.ForeColor = System.Drawing.Color.Silver;
            this.tb_firstName.Location = new System.Drawing.Point(8, 40);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(240, 26);
            this.tb_firstName.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_login);
            this.panel1.Controls.Add(this.lb_login);
            this.panel1.Controls.Add(this.tb_patronymic);
            this.panel1.Controls.Add(this.tb_firstName);
            this.panel1.Controls.Add(this.lb_firstName);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.tb_lastName);
            this.panel1.Controls.Add(this.lb_lastName);
            this.panel1.Controls.Add(this.lb_patronymic);
            this.panel1.Controls.Add(this.lb_password);
            this.panel1.Location = new System.Drawing.Point(272, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 328);
            this.panel1.TabIndex = 17;
            // 
            // tb_login
            // 
            this.tb_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.tb_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.ForeColor = System.Drawing.Color.Silver;
            this.tb_login.Location = new System.Drawing.Point(8, 232);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(240, 26);
            this.tb_login.TabIndex = 18;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login.ForeColor = System.Drawing.Color.LightGray;
            this.lb_login.Location = new System.Drawing.Point(8, 200);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(55, 20);
            this.lb_login.TabIndex = 17;
            this.lb_login.Text = "Логин";
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.bt_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CancelButton = this.bt_back;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_confirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почта - регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Label lb_firstName;
        private System.Windows.Forms.Label lb_lastName;
        private System.Windows.Forms.Label lb_patronymic;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_patronymic;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_login;
    }
}