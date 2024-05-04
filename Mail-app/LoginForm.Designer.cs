namespace Mail_app
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bt_back = new System.Windows.Forms.Button();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.bt_back.TabIndex = 0;
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login.ForeColor = System.Drawing.Color.LightGray;
            this.lb_login.Location = new System.Drawing.Point(8, 8);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(55, 20);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Логин";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_password.ForeColor = System.Drawing.Color.LightGray;
            this.lb_password.Location = new System.Drawing.Point(8, 88);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(67, 20);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Пароль";
            // 
            // tb_login
            // 
            this.tb_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.tb_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.ForeColor = System.Drawing.Color.Silver;
            this.tb_login.Location = new System.Drawing.Point(8, 48);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(240, 26);
            this.tb_login.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.ForeColor = System.Drawing.Color.Silver;
            this.tb_password.Location = new System.Drawing.Point(8, 128);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(240, 26);
            this.tb_password.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_login);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.lb_password);
            this.panel1.Controls.Add(this.tb_login);
            this.panel1.Location = new System.Drawing.Point(280, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 160);
            this.panel1.TabIndex = 5;
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
            this.bt_confirm.Location = new System.Drawing.Point(280, 312);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(256, 32);
            this.bt_confirm.TabIndex = 6;
            this.bt_confirm.Text = "Принять";
            this.bt_confirm.UseVisualStyleBackColor = false;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.bt_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CancelButton = this.bt_back;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_confirm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почта - вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_confirm;
    }
}