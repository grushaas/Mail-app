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
        private List<string> saveLetters = new List<string>();
        public List<Letter> letters = new List<Letter>();
        private NpgsqlConnection con = new NpgsqlConnection("Host=92.118.170.201;Username=username13;Password=Pt7QLM4F;Database=username13_db");
        private NpgsqlCommand cmd = new NpgsqlCommand();

        public User user { get; private set; }

        public MainWindow(string password, string login)
        {
            InitializeComponent();

            var user = GetDataForUser(password, login);
            GetPackage();

            if (user != null)
            {
                lb_fio.Text = user.ToString();
                lb_nickname.Text = user.login;
            }
        }

        private void GetPackage()
        {
            lbox_emails.Items.Clear();
            lbox_emails.Items.Add("Черновики: ");
            letters.Clear();
            try
            {
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = $"SELECT * FROM package";
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(reader.GetOrdinal("id"));
                    double weight = reader.GetDouble(reader.GetOrdinal("weight"));
                    string type = reader.GetString(reader.GetOrdinal("type"));
                    string msg = reader.GetString(reader.GetOrdinal("message"));

                    Letter letter = new Letter(id, weight, type, msg);
                    letters.Add(letter);
                }
                con.Close();
            }
            catch (NpgsqlException ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

            SetLetters();
        }

        private void SetLetters()
        {
            foreach (Letter msg in letters)
            {
                lbox_emails.Items.Add(msg);
            }
        }

        private void SaveLetter() // Сохранения письма в бд
        {
            try
            {
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = $"INSERT INTO package (weight, type, message) VALUES (0.25, 'letter', '{saveLetters[saveLetters.Count - 1]}')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (NpgsqlException ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }

            GetPackage();
        }

        private User GetDataForUser(string password, string login) // Получение данных пользователя
        {
            try
            {
                int id = 0;
                string firstname = string.Empty;
                string lastname = string.Empty;
                string patronymic = string.Empty;
                con.Open();

                cmd.Connection = con;

                cmd.CommandText = $"SELECT id, firstname, lastname, patronymic FROM Peoples WHERE passwordd = '{password}' AND login = '{login}'";
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    con.Close();
                    return null;
                }
                while (reader.Read())
                {
                    id = reader.GetInt32(reader.GetOrdinal("id"));
                    firstname = reader.GetString(reader.GetOrdinal("firstname"));
                    lastname = reader.GetString(reader.GetOrdinal("lastname"));
                    patronymic = reader.GetString(reader.GetOrdinal("patronymic"));
                }
                con.Close();
                user = new User(id, firstname, lastname, patronymic, login, password);
                return user;
            }
            catch (NpgsqlException ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        private void bt_choosePostOffice_Click(object sender, EventArgs e)
        {
            using (ChoosePostOffice postOffice = new ChoosePostOffice())
            {
                postOffice.Tag = this;
                Hide();

                if (postOffice.ShowDialog() == DialogResult.OK)
                {
                    user.ChoosePostOffice(postOffice.chooseId.Trim());
                    lb_postOffice.Text = $"Почтовое отделение: {postOffice.chooseId}";
                }
            }
        }

        private void bt_sendEmail_Click(object sender, EventArgs e)
        {
            if (user.postOffice == 0)
            {
                MessageBox.Show("Выберите почтовое отделение!");
            }
            else if (lbox_emails.SelectedItems.Count == 0)
            {
                MessageBox.Show("Для начала, выберите письмо");
            }
            else
            {
                using (SendEmail sendEmail = new SendEmail((Letter)lbox_emails.SelectedItem, user.postOffice, user.id))
                {
                    sendEmail.Tag = this;
                    Hide();

                    if (sendEmail.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
        }

        private void bt_createEmail_Click(object sender, EventArgs e)
        {
            using (CreateEmail createEmail = new CreateEmail())
            {
                createEmail.Tag = this;
                Hide();

                if (createEmail.ShowDialog() == DialogResult.OK)
                {
                    if (createEmail.sendMessage)
                    {
                        bt_sendEmail_Click(sender, e);
                    }
                    else
                    {
                        saveLetters.Add(createEmail.letter);
                        SaveLetter();
                    }
                }
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class User
    {
        public int id { get; private set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string patronymic { get; set; }
        public string login { get; private set; }
        public string password { get; private set; }
        public int postOffice { get; private set; }

        public User(int id, string firstname, string lastname, string patronymic, string login, string password)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.patronymic = patronymic;
            this.login = login;
            this.password = password;
            postOffice = 0;
        }
        public User() { }

        public override string ToString()
        {
            return $"{lastname} {firstname} {patronymic}";
        }

        public void ChoosePostOffice(string id)
        {
            postOffice = Convert.ToInt32(id);
        }
    }

    public class Letter
    {
        public int id { get; private set; }
        public double weight {  get; set; }
        public string type {  get; set; }
        public string msg {  get; private set; }

        public Letter(int id, double weight, string type, string msg)
        {
            this.id = id;
            this.weight = weight;
            this.type = type;
            this.msg = msg;
        }

        public override string ToString()
        {
            return $"ID: {id}    | Вес: {weight}    | Тип пакета: {type}    | Письмо: {msg}";
        }
    }
}
