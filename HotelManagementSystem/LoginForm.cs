using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    public partial class LoginForm : Form

        
    {

        DBConnect connect = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim().Equals("") || textBoxPassword.Text == "")
            {

                MessageBox.Show("Enter your username and password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { 
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string selectQuery = "SELECT * FROM `users` WHERE `username`= @usn and `password`=@pass";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);



            if (table.Rows.Count > 0) {

                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            } else
            {

                    MessageBox.Show("Your username and password don't exist", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }

        }
       }
    }
}
