using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace Mail_app
{
    public partial class SendEmail : Form
    {
        private int idPeople = 0;
        private Letter letter;
        private int idMail = 0;
        private string toAddress = "";
        private bool closeThisForm = true;

        public SendEmail(Letter letter, int idMail, int idPeople)
        {
            InitializeComponent();

            this.idPeople = idPeople;
            this.letter = letter;
            this.idMail = idMail;

            lb_letter.Text = ShowMessage();
        }

        private string ShowMessage()
        {
            string msg = letter.msg;
            if (letter.msg.Length > 40)
            {
                msg = letter.msg.Remove(40, letter.msg.Length - 40) + "...";

                return msg;
            }
            else
            {
                return msg;
            }
        }

        private string GetAddressMail()
        {
            NpgsqlConnection con = new NpgsqlConnection("Host=92.118.170.201;Username=username13;Password=Pt7QLM4F;Database=username13_db");
            NpgsqlCommand cmd = new NpgsqlCommand();

            try
            {
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = $"SELECT address FROM mail WHERE id = @idMail";
                cmd.Parameters.AddWithValue("idMail", idMail);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        return (string)reader["address"];
                    }
                }

                return null;
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        private void bt_sendLetter_Click(object sender, EventArgs e)
        {
            toAddress = tb_address.Text;
            string fromAddress = GetAddressMail();

            NpgsqlConnection con = new NpgsqlConnection("Host=92.118.170.201;Username=username13;Password=Pt7QLM4F;Database=username13_db");
            NpgsqlCommand cmd = new NpgsqlCommand();

            try
            {
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = $"INSERT INTO ordering (id_people, id_package, fromaddress, toaddress, id_mail) VALUES " +
                    $"({idPeople}, {letter.id}, '{fromAddress}', '{toAddress}', {idMail})";

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch(NpgsqlException ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

            bt_back_Click(sender, e);
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            closeThisForm = false;
            var main = (MainWindow)Tag;
            main.Show();
            Close();
        }

        private void SendEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeThisForm)
            {
                Application.Exit();
            }
        }
    }
}
