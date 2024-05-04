using System;
using Npgsql;
using System.Windows.Forms;

namespace Mail_app
{
    public partial class LoginForm : Form
    {
        private bool closeThisForm = true;
        public string login = "";
        public string password = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void CheckLoginPasswordRecords()
        {
            var con = new NpgsqlConnection(
                connectionString: "Host=92.118.170.201;Username=username13;Password=Pt7QLM4F;Database=username13_db"
                );

            try
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"SELECT login, passwordd FROM Peoples WHERE login = @login OR Passwordd = @password";
                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("password", password);

                if(cmd.ExecuteScalar() != null)
                {
                    MainWindow main = new MainWindow(password, login);
                    main.Tag = this;
                    main.Show(this);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            closeThisForm = false;
            var form1 = (Form1)Tag;
            form1.Show();
            Close();
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            login = tb_login.Text;
            password = tb_password.Text;

            CheckLoginPasswordRecords();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeThisForm)
            {
                Application.Exit();
            }
        }
    }
}
