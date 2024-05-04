﻿using System;
using Npgsql;
using Dapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mail_app
{
    public partial class ChoosePostOffice : Form
    {
        public ChoosePostOffice()
        {
            InitializeComponent();
            var con = new NpgsqlConnection("Host=92.118.170.201;Username=username13;Password=Pt7QLM4F;Database=username13_db");
            var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            List<int> ids = new List<int>();

            try
            {
                con.Open();
                cmd.CommandText = $"SELECT id FROM mail";
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(reader.GetOrdinal("id"));

                    ids.Add(id);
                }
                reader.Close();

            } catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }

            foreach (int id in ids)
            {
                lbox_emails.Items.Add(id);
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            var main = (MainWindow)Tag;
            main.Show();
            Close();
        }
    }
}
