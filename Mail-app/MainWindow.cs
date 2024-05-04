using System;
using Npgsql;
using Dapper;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Mail_app
{
    public partial class MainWindow : Form
    {
        public MainWindow(string password, string login)
        {
            InitializeComponent();

            var user = GetDataForUser(password, login);

            if (user != null)
            {
                lb_fio.Text = user.ToString();
                lb_nickname.Text = user.login;
            }
        }

        private User GetDataForUser(string password, string login) // Получение данных пользователя
        {
            var con = new NpgsqlConnection("Host=92.118.170.201;Username=username13;Password=Pt7QLM4F;Database=username13_db");

            try
            {
                string firstname = string.Empty;
                string lastname = string.Empty;
                string patronymic = string.Empty;
                con.Open();

                var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"SELECT firstname, lastname, patronymic FROM Peoples WHERE passwordd = '{password}' AND login = '{login}'";
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        firstname = reader.GetString(reader.GetOrdinal("firstname"));
                        lastname = reader.GetString(reader.GetOrdinal("lastname"));
                        patronymic = reader.GetString(reader.GetOrdinal("patronymic"));
                    }
                    return new User(firstname, lastname, patronymic, login, password);
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_choosePostOffice_Click(object sender, EventArgs e)
        {
            ChoosePostOffice postOffice = new ChoosePostOffice();
            postOffice.Tag = this;
            postOffice.Show(this);
            Hide();
        }
    }

    public class User
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string patronymic { get; set; }
        public string login { get; private set; }
        public string password { get; private set; }
        public string postOffice { get; private set; }

        public User(string firstname, string lastname, string patronymic, string login, string password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.patronymic = patronymic;
            this.login = login;
            this.password = password;
        }
        public User() { }

        public override string ToString()
        {
            return $"{lastname} {firstname} {patronymic}";
        }

        public void ChoosePostOffice(int id)
        {

        }
    }
}
