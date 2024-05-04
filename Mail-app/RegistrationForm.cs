using System;
using Npgsql;
using System.Windows.Forms;

namespace Mail_app
{
    public partial class RegistrationForm : Form
    {
        private bool closeMainForm = true;

        private string firstName = "";
        private string lastName = "";
        private string patronymic = "";
        private string login = "";
        private string password = "";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void EnteringData()
        {
            var con = new NpgsqlConnection("Host=92.118.170.201;Username=username13;Password=Pt7QLM4F;Database=username13_db");

            try
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"INSERT INTO Peoples (firstname, lastname, patronymic, login, passwordd) VALUES (@firstname, @lastname, @patronymic, @login, @passwordd)";
                cmd.Parameters.AddWithValue("firstname", firstName);
                cmd.Parameters.AddWithValue("lastname", lastName);
                cmd.Parameters.AddWithValue("patronymic", patronymic);
                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("passwordd", password);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckLoginPasswordRecords()
        {
            var con = new NpgsqlConnection(
                connectionString: "Host=92.118.170.201;Username=username13;Password=Pt7QLM4F;Database=username13_db"
                );

            try
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                MessageBox.Show("Мы тут!");
                cmd.CommandText = $"SELECT login, passwordd FROM Peoples WHERE login = @login OR Passwordd = @password";
                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("password", password);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Rows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            closeMainForm = false;
            var form1 = (Form1)Tag;
            form1.Show();
            Close();
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Show();
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            if (tb_firstName.Text == "" || tb_lastName.Text == "" || tb_patronymic.Text == "" || tb_password.Text == "" || tb_login.Text == "")
            {
                MessageBox.Show("Заполните все текстовые поля");
            }
            else
            {
                firstName = tb_firstName.Text;
                lastName = tb_lastName.Text;
                patronymic = tb_patronymic.Text;
                login = tb_login.Text;
                password = tb_password.Text;

                if(CheckLoginPasswordRecords())
                {
                    MessageBox.Show("Такой логин и пароль уже существует");
                    tb_login.Clear();
                    tb_password.Clear();
                }
                else
                {
                    EnteringData();
                }
            }
        }
    }
}
