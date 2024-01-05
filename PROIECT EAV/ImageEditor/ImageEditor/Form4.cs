using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Form4 : Form
    {
        private User user;
        private Users users;

        public Form4(User user)
        {
            InitializeComponent();
            this.user = user;

            users = new Users();

            // Read the existing JSON file, if it exists
            if (File.Exists("F:\\Documents\\ISM CURSURI\\AN 4 SEM 1\\TEME SEM 1\\EAV\\PROIECT EAV\\PROIECT EAV\\ImageEditor\\ImageEditor\\userData.JSON"))
            {
                string jsonString = File.ReadAllText("F:\\Documents\\ISM CURSURI\\AN 4 SEM 1\\TEME SEM 1\\EAV\\PROIECT EAV\\PROIECT EAV\\ImageEditor\\ImageEditor\\userData.JSON");
                users = JsonConvert.DeserializeObject<Users>(jsonString);
            }

            // Populate the ListBox with the stored usernames
            foreach (User u in users.userData)
            {
                listBox1.Items.Add(u.username);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 mf = new Form3();
            Hide();
            mf.ShowDialog();
        }
    }
}