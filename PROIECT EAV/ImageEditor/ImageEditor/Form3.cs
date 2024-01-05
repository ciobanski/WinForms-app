using System;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;


namespace ImageEditor
{
    public partial class Form3 : Form
    {
        string cnst = @"Data Source=localhost;Initial Catalog=Login;Integrated Security=True";

        public User user { get; private set; }
        private List<string> savedImagePaths;
        private SavedImages savedImages;
        private Form1 form1;
        public Form3()
        {
            InitializeComponent();
            this.form1 = form1;

            // Initialize the savedImages object
            savedImages = new SavedImages();

            // Read the existing JSON file, if it exists
            if (File.Exists("F:\\Documents\\ISM CURSURI\\AN 4 SEM 1\\TEME SEM 1\\EAV\\PROIECT EAV\\PROIECT EAV\\ImageEditor\\ImageEditor\\savedImages.JSON"))
            {
                string jsonString = File.ReadAllText("F:\\Documents\\ISM CURSURI\\AN 4 SEM 1\\TEME SEM 1\\EAV\\PROIECT EAV\\PROIECT EAV\\ImageEditor\\ImageEditor\\savedImages.JSON");
                savedImages = JsonConvert.DeserializeObject<SavedImages>(jsonString);
            }

            // Populate the ComboBox with the saved image paths
            foreach (SavedImage savedImage in savedImages.Images)
            {
                comboBox1.Items.Add(savedImage.Path);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {


                pictureBox1.Image = null;
                ofd.Filter = "images|*.png;*.jpg;*.jpeg;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = new Bitmap(ofd.FileName);


                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(user);
            this.Hide();
            frm4.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 mf = new Form1();
            Hide();
            mf.ShowDialog();
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            // Add the new file path entered in the TextBox to the list of saved images
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                SavedImage newImage = new SavedImage { Path = textBox1.Text };
                savedImages.Add(newImage);

                // Serialize the list to JSON
                string jsonString = JsonConvert.SerializeObject(savedImages);

                // Save the JSON to a file
                File.WriteAllText(@"F:\Documents\ISM CURSURI\AN 4 SEM 1\TEME SEM 1\EAV\PROIECT EAV\PROIECT EAV\ImageEditor\ImageEditor\savedImages.JSON", jsonString);

                // Clear the TextBox after saving the file path
                textBox1.Clear();

                // Add the new path to the ComboBox
                comboBox1.Items.Add(newImage.Path);
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            // Get the selected image path from the ComboBox
            string selectedImagePath = comboBox1.SelectedItem.ToString();


            // Load the image from the file path
            System.Drawing.Image selectedImage = System.Drawing.Image.FromFile(selectedImagePath);

            // Set the loaded image as the PictureBox's image
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = System.Drawing.Image.FromFile(selectedImagePath);
        }
    }
}