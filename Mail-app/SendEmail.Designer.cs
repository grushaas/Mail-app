namespace Mail_app
{
    partial class SendEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEmail));
            System.Windows.Forms.Button bt_sendLetter;
            this.lb_letter = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.lb_where = new System.Windows.Forms.Label();
            bt_sendLetter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_letter
            // 
            this.lb_letter.AutoSize = true;
            this.lb_letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_letter.ForeColor = System.Drawing.Color.White;
            this.lb_letter.Location = new System.Drawing.Point(24, 64);
            this.lb_letter.Name = "lb_letter";
            this.lb_letter.Size = new System.Drawing.Size(62, 16);
            this.lb_letter.TabIndex = 0;
            this.lb_letter.Text = "Письмо: ";
            // 
            // bt_back
            // 
            this.bt_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_back.BackgroundImage")));
            this.bt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_back.FlatAppearance.BorderSize = 0;
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back.Location = new System.Drawing.Point(24, 16);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(32, 24);
            this.bt_back.TabIndex = 19;
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // tb_address
            // 
            this.tb_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.tb_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_address.ForeColor = System.Drawing.Color.Silver;
            this.tb_address.Location = new System.Drawing.Point(256, 176);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(136, 26);
            this.tb_address.TabIndex = 21;
            // 
            // lb_where
            // 
            this.lb_where.AutoSize = true;
            this.lb_where.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_where.ForeColor = System.Drawing.Color.White;
            this.lb_where.Location = new System.Drawing.Point(24, 184);
            this.lb_where.Name = "lb_where";
            this.lb_where.Size = new System.Drawing.Size(223, 16);
            this.lb_where.TabIndex = 22;
            this.lb_where.Text = "Введите адрес(куда отправить?)";
            // 
            // bt_sendLetter
            // 
            bt_sendLetter.Anchor = System.Windows.Forms.AnchorStyles.None;
            bt_sendLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            bt_sendLetter.DialogResult = System.Windows.Forms.DialogResult.OK;
            bt_sendLetter.FlatAppearance.BorderSize = 0;
            bt_sendLetter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            bt_sendLetter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            bt_sendLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_sendLetter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bt_sendLetter.ForeColor = System.Drawing.Color.Silver;
            bt_sendLetter.Location = new System.Drawing.Point(139, 288);
            bt_sendLetter.Name = "bt_sendLetter";
            bt_sendLetter.Size = new System.Drawing.Size(128, 32);
            bt_sendLetter.TabIndex = 23;
            bt_sendLetter.Text = "Отправить письмо";
            bt_sendLetter.UseVisualStyleBackColor = false;
            bt_sendLetter.Click += new System.EventHandler(this.bt_sendLetter_Click);
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(410, 340);
            this.Controls.Add(bt_sendLetter);
            this.Controls.Add(this.lb_where);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.lb_letter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendEmail";
            this.Text = "Почта - отправка сообщения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendEmail_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_letter;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label lb_where;
    }
}