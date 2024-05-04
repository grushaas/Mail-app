using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mail_app
{
    public partial class CreateEmail : Form
    {
        public string letter { get; private set; }
        public bool sendMessage { get; private set; }
        private bool closeThisForm = true;

        public CreateEmail()
        {
            InitializeComponent();
        }

        private void bt_increaseSize_Click(object sender, EventArgs e)
        {
            if(tb_letter.Font.Size < 32)
            {
                Font font = new Font(tb_letter.Font.FontFamily, tb_letter.Font.Size + 1);
                tb_letter.Font = font;
            }
            else
            {
                MessageBox.Show("Вы достигли уже максимального размера шрифта");
            }
        }

        private void bt_reduceSize_Click(object sender, EventArgs e)
        {
            if(tb_letter.Font.Size > 7)
            {
                Font font = new Font(tb_letter.Font.FontFamily, tb_letter.Font.Size - 1);
                tb_letter.Font = font;
            }
            else
            {
                MessageBox.Show("Вы достигли уже минимального размера шрифта");
            }
            
        }

        private void bt_saveLetter_Click(object sender, EventArgs e)
        {
            sendMessage = false;
            foreach(var msg in tb_letter.Lines)
            {
                letter += msg;
            }

            bt_back_Click(sender, e);
        }

        private void bt_sendLetter_Click(object sender, EventArgs e)
        {
            sendMessage = true;
            foreach (var msg in tb_letter.Lines)
            {
                letter += msg;
            }
            bt_back_Click(sender, e);
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            closeThisForm = false;
            var mainWindow = (MainWindow)Tag;
            mainWindow.Show();
            Close();
        }

        private void CreateEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeThisForm)
            {
                Application.Exit();
            }
        }
    }
}
