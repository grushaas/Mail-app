namespace Mail_app
{
    partial class CreateEmail
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
            System.Windows.Forms.Button bt_reduceSize;
            System.Windows.Forms.Button bt_sendLetter;
            System.Windows.Forms.Button bt_saveLetter;
            System.Windows.Forms.Button bt_increaseSize;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEmail));
            this.tb_letter = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_createLetter = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            bt_reduceSize = new System.Windows.Forms.Button();
            bt_sendLetter = new System.Windows.Forms.Button();
            bt_saveLetter = new System.Windows.Forms.Button();
            bt_increaseSize = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_reduceSize
            // 
            bt_reduceSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            bt_reduceSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            bt_reduceSize.FlatAppearance.BorderSize = 0;
            bt_reduceSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            bt_reduceSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            bt_reduceSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_reduceSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bt_reduceSize.ForeColor = System.Drawing.Color.Silver;
            bt_reduceSize.Location = new System.Drawing.Point(720, 72);
            bt_reduceSize.Name = "bt_reduceSize";
            bt_reduceSize.Size = new System.Drawing.Size(32, 32);
            bt_reduceSize.TabIndex = 9;
            bt_reduceSize.Text = "-";
            bt_reduceSize.UseVisualStyleBackColor = false;
            bt_reduceSize.Click += new System.EventHandler(this.bt_reduceSize_Click);
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
            bt_sendLetter.Location = new System.Drawing.Point(144, 0);
            bt_sendLetter.Name = "bt_sendLetter";
            bt_sendLetter.Size = new System.Drawing.Size(128, 32);
            bt_sendLetter.TabIndex = 10;
            bt_sendLetter.Text = "Отправить письмо";
            bt_sendLetter.UseVisualStyleBackColor = false;
            bt_sendLetter.Click += new System.EventHandler(this.bt_sendLetter_Click);
            // 
            // bt_saveLetter
            // 
            bt_saveLetter.Anchor = System.Windows.Forms.AnchorStyles.None;
            bt_saveLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            bt_saveLetter.DialogResult = System.Windows.Forms.DialogResult.OK;
            bt_saveLetter.FlatAppearance.BorderSize = 0;
            bt_saveLetter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            bt_saveLetter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            bt_saveLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_saveLetter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bt_saveLetter.ForeColor = System.Drawing.Color.Silver;
            bt_saveLetter.Location = new System.Drawing.Point(0, 0);
            bt_saveLetter.Name = "bt_saveLetter";
            bt_saveLetter.Size = new System.Drawing.Size(136, 32);
            bt_saveLetter.TabIndex = 11;
            bt_saveLetter.Text = "Сохранить письмо";
            bt_saveLetter.UseVisualStyleBackColor = false;
            bt_saveLetter.Click += new System.EventHandler(this.bt_saveLetter_Click);
            // 
            // bt_increaseSize
            // 
            bt_increaseSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            bt_increaseSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            bt_increaseSize.FlatAppearance.BorderSize = 0;
            bt_increaseSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            bt_increaseSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            bt_increaseSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_increaseSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bt_increaseSize.ForeColor = System.Drawing.Color.Silver;
            bt_increaseSize.Location = new System.Drawing.Point(680, 72);
            bt_increaseSize.Name = "bt_increaseSize";
            bt_increaseSize.Size = new System.Drawing.Size(32, 32);
            bt_increaseSize.TabIndex = 19;
            bt_increaseSize.Text = "+";
            bt_increaseSize.UseVisualStyleBackColor = false;
            bt_increaseSize.Click += new System.EventHandler(this.bt_increaseSize_Click);
            // 
            // tb_letter
            // 
            this.tb_letter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tb_letter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_letter.Location = new System.Drawing.Point(48, 112);
            this.tb_letter.Multiline = true;
            this.tb_letter.Name = "tb_letter";
            this.tb_letter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_letter.Size = new System.Drawing.Size(704, 248);
            this.tb_letter.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(bt_saveLetter);
            this.panel2.Controls.Add(bt_sendLetter);
            this.panel2.Location = new System.Drawing.Point(480, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 32);
            this.panel2.TabIndex = 16;
            // 
            // lb_createLetter
            // 
            this.lb_createLetter.AutoSize = true;
            this.lb_createLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_createLetter.ForeColor = System.Drawing.Color.White;
            this.lb_createLetter.Location = new System.Drawing.Point(48, 72);
            this.lb_createLetter.Name = "lb_createLetter";
            this.lb_createLetter.Size = new System.Drawing.Size(227, 25);
            this.lb_createLetter.TabIndex = 17;
            this.lb_createLetter.Text = "Создания сообщение";
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
            this.bt_back.TabIndex = 18;
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(552, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Размер шрифта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(bt_increaseSize);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(bt_reduceSize);
            this.Controls.Add(this.lb_createLetter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_letter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateEmail";
            this.Text = "Почта - Создания сообщения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEmail_FormClosing);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_letter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_createLetter;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Label label1;
    }
}