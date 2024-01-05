using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Microsoft.VisualBasic.Logging;

namespace ImageEditor
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("All field are required");
            }
            else
            {
                User user = new User();
                user.username = textBox1.Text;
                user.password = textBox2.Text;



                StreamReader reader = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"F:\Documents\ISM CURSURI\AN 4 SEM 1\TEME SEM 1\EAV\PROIECT EAV\PROIECT EAV\ImageEditor\ImageEditor\userData.JSON"));
                string jsonString = reader.ReadToEnd();
                Users users = JsonConvert.DeserializeObject<Users>(jsonString);
                reader.Close();

                users.Add(user);

                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"F:\Documents\ISM CURSURI\AN 4 SEM 1\TEME SEM 1\EAV\PROIECT EAV\PROIECT EAV\ImageEditor\ImageEditor\userData.JSON"),
                    JsonConvert.SerializeObject(users, Formatting.Indented));


                MessageBox.Show("User created!");
                Form2 frm = new Form2();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}