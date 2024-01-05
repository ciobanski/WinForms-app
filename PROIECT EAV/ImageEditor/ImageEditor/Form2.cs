using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Newtonsoft.Json;
namespace ImageEditor
{


    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Connection String

        private void login_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                StreamReader reader = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"F:\Documents\ISM CURSURI\AN 4 SEM 1\TEME SEM 1\EAV\PROIECT EAV\PROIECT EAV\ImageEditor\ImageEditor\userData.JSON"));
                string jsonString = reader.ReadToEnd();

                Users users = JsonConvert.DeserializeObject<Users>(jsonString);

                bool foundUser = false;
                foreach (User user in users.userData)
                {
                    if (user.username == textBox1.Text && user.password == textBox2.Text)
                    {
                        foundUser = true;

                        Form1 frm = new Form1();
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                if (!foundUser) MessageBox.Show("Invalid Credentials");
            }

        }
        



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm = new Form5();
            frm.ShowDialog();
            this.Close();
        }
    }
}
