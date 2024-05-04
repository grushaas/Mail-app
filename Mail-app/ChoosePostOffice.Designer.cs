namespace Mail_app
{
    partial class ChoosePostOffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosePostOffice));
            this.lbox_emails = new System.Windows.Forms.ListBox();
            this.bt_choosePostOffice = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_emails
            // 
            this.lbox_emails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lbox_emails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbox_emails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbox_emails.ForeColor = System.Drawing.Color.White;
            this.lbox_emails.FormattingEnabled = true;
            this.lbox_emails.ItemHeight = 20;
            this.lbox_emails.Location = new System.Drawing.Point(32, 72);
            this.lbox_emails.Name = "lbox_emails";
            this.lbox_emails.Size = new System.Drawing.Size(272, 262);
            this.lbox_emails.TabIndex = 7;
            // 
            // bt_choosePostOffice
            // 
            this.bt_choosePostOffice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_choosePostOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.bt_choosePostOffice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_choosePostOffice.FlatAppearance.BorderSize = 0;
            this.bt_choosePostOffice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.bt_choosePostOffice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.bt_choosePostOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_choosePostOffice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_choosePostOffice.ForeColor = System.Drawing.Color.Silver;
            this.bt_choosePostOffice.Location = new System.Drawing.Point(96, 400);
            this.bt_choosePostOffice.Name = "bt_choosePostOffice";
            this.bt_choosePostOffice.Size = new System.Drawing.Size(144, 32);
            this.bt_choosePostOffice.TabIndex = 8;
            this.bt_choosePostOffice.Text = "Выбрать";
            this.bt_choosePostOffice.UseVisualStyleBackColor = false;
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
            this.bt_back.TabIndex = 9;
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // ChoosePostOffice
            // 
            this.AcceptButton = this.bt_choosePostOffice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CancelButton = this.bt_back;
            this.ClientSize = new System.Drawing.Size(337, 481);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_choosePostOffice);
            this.Controls.Add(this.lbox_emails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChoosePostOffice";
            this.Text = "Почта- выбор почтового отделения";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_emails;
        private System.Windows.Forms.Button bt_choosePostOffice;
        private System.Windows.Forms.Button bt_back;
    }
}