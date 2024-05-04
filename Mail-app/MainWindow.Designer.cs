namespace Mail_app
{
    partial class MainWindow
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
            System.Windows.Forms.Button bt_createEmail;
            System.Windows.Forms.Button bt_exit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_choosePostOffice = new System.Windows.Forms.Button();
            this.bt_sendEmail = new System.Windows.Forms.Button();
            this.lb_fio = new System.Windows.Forms.Label();
            this.lb_nickname = new System.Windows.Forms.Label();
            this.lbox_emails = new System.Windows.Forms.ListBox();
            this.lb_postOffice = new System.Windows.Forms.Label();
            bt_createEmail = new System.Windows.Forms.Button();
            bt_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_createEmail
            // 
            bt_createEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            bt_createEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            bt_createEmail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            bt_createEmail.FlatAppearance.BorderSize = 0;
            bt_createEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            bt_createEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            bt_createEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_createEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bt_createEmail.ForeColor = System.Drawing.Color.Silver;
            bt_createEmail.Location = new System.Drawing.Point(0, 0);
            bt_createEmail.Name = "bt_createEmail";
            bt_createEmail.Size = new System.Drawing.Size(144, 32);
            bt_createEmail.TabIndex = 8;
            bt_createEmail.Text = "Создать письмо";
            bt_createEmail.UseVisualStyleBackColor = false;
            bt_createEmail.Click += new System.EventHandler(this.bt_createEmail_Click);
            // 
            // bt_exit
            // 
            bt_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            bt_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            bt_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_exit.BackgroundImage")));
            bt_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bt_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            bt_exit.FlatAppearance.BorderSize = 0;
            bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_exit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bt_exit.ForeColor = System.Drawing.Color.Silver;
            bt_exit.Location = new System.Drawing.Point(24, 16);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new System.Drawing.Size(40, 32);
            bt_exit.TabIndex = 10;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(bt_createEmail);
            this.panel1.Controls.Add(this.bt_choosePostOffice);
            this.panel1.Controls.Add(this.bt_sendEmail);
            this.panel1.Location = new System.Drawing.Point(112, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 40);
            this.panel1.TabIndex = 2;
            // 
            // bt_choosePostOffice
            // 
            this.bt_choosePostOffice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_choosePostOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.bt_choosePostOffice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_choosePostOffice.FlatAppearance.BorderSize = 0;
            this.bt_choosePostOffice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.bt_choosePostOffice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.bt_choosePostOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_choosePostOffice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_choosePostOffice.ForeColor = System.Drawing.Color.Silver;
            this.bt_choosePostOffice.Location = new System.Drawing.Point(352, 0);
            this.bt_choosePostOffice.Name = "bt_choosePostOffice";
            this.bt_choosePostOffice.Size = new System.Drawing.Size(208, 32);
            this.bt_choosePostOffice.TabIndex = 9;
            this.bt_choosePostOffice.Text = "Выбрать почтовое отделение";
            this.bt_choosePostOffice.UseVisualStyleBackColor = false;
            this.bt_choosePostOffice.Click += new System.EventHandler(this.bt_choosePostOffice_Click);
            // 
            // bt_sendEmail
            // 
            this.bt_sendEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_sendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.bt_sendEmail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_sendEmail.FlatAppearance.BorderSize = 0;
            this.bt_sendEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.bt_sendEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.bt_sendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sendEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_sendEmail.ForeColor = System.Drawing.Color.Silver;
            this.bt_sendEmail.Location = new System.Drawing.Point(152, 0);
            this.bt_sendEmail.Name = "bt_sendEmail";
            this.bt_sendEmail.Size = new System.Drawing.Size(144, 32);
            this.bt_sendEmail.TabIndex = 7;
            this.bt_sendEmail.Text = "Отправить письмо";
            this.bt_sendEmail.UseVisualStyleBackColor = false;
            this.bt_sendEmail.Click += new System.EventHandler(this.bt_sendEmail_Click);
            // 
            // lb_fio
            // 
            this.lb_fio.AutoSize = true;
            this.lb_fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_fio.ForeColor = System.Drawing.Color.White;
            this.lb_fio.Location = new System.Drawing.Point(536, 56);
            this.lb_fio.Name = "lb_fio";
            this.lb_fio.Size = new System.Drawing.Size(47, 20);
            this.lb_fio.TabIndex = 4;
            this.lb_fio.Text = "ФИО";
            // 
            // lb_nickname
            // 
            this.lb_nickname.AutoSize = true;
            this.lb_nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_nickname.ForeColor = System.Drawing.Color.White;
            this.lb_nickname.Location = new System.Drawing.Point(712, 88);
            this.lb_nickname.Name = "lb_nickname";
            this.lb_nickname.Size = new System.Drawing.Size(66, 17);
            this.lb_nickname.TabIndex = 5;
            this.lb_nickname.Text = "Никнейм";
            // 
            // lbox_emails
            // 
            this.lbox_emails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lbox_emails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbox_emails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbox_emails.ForeColor = System.Drawing.Color.White;
            this.lbox_emails.FormattingEnabled = true;
            this.lbox_emails.HorizontalScrollbar = true;
            this.lbox_emails.ItemHeight = 20;
            this.lbox_emails.Location = new System.Drawing.Point(24, 112);
            this.lbox_emails.Name = "lbox_emails";
            this.lbox_emails.Size = new System.Drawing.Size(752, 262);
            this.lbox_emails.TabIndex = 6;
            // 
            // lb_postOffice
            // 
            this.lb_postOffice.AutoSize = true;
            this.lb_postOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_postOffice.ForeColor = System.Drawing.Color.White;
            this.lb_postOffice.Location = new System.Drawing.Point(24, 80);
            this.lb_postOffice.Name = "lb_postOffice";
            this.lb_postOffice.Size = new System.Drawing.Size(228, 17);
            this.lb_postOffice.TabIndex = 7;
            this.lb_postOffice.Text = "Почтовое отделение не выбрано";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(bt_exit);
            this.Controls.Add(this.lb_postOffice);
            this.Controls.Add(this.lbox_emails);
            this.Controls.Add(this.lb_nickname);
            this.Controls.Add(this.lb_fio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_fio;
        private System.Windows.Forms.Label lb_nickname;
        private System.Windows.Forms.ListBox lbox_emails;
        private System.Windows.Forms.Button bt_choosePostOffice;
        private System.Windows.Forms.Button bt_sendEmail;
        private System.Windows.Forms.Label lb_postOffice;
    }
}