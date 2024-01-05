
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Diagnostics.Contracts;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace ImageEditor
{
    public partial class Form1 : Form
    {
        Image img;
        OpenFileDialog ofd = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_imgpath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            ofd.Filter = "images|*.png;*.jpg;*.jpeg;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox2.Image = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                txt_imgpath.Text = ofd.FileName;
                img = Image.FromFile(ofd.FileName);
                lbl_size.Text = pictureBox1.Image.Size.ToString(); // To displaye the image size//
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG|*.JPG|PNG|*.PNG|GIF|*.GIF|BMP|*.BMP|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Bitmap bitmap = new Bitmap(pictureBox2.Image))
                    {
                        bitmap.Save(sfd.FileName, ImageFormat.Jpeg);
                    }
                    MessageBox.Show("Image Saved Successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error ");
                }

            }


        }
        new Image Resize(Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, width, height);
            graphic.Dispose();
            return bmp;
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(txt_width.Text), height = Convert.ToInt32(txt_height.Text);
            img = Resize(img, width, height);
            pictureBox2.Image = img;
            txt_width.Text = "";
            txt_height.Text = "";
        }

        void reload()
        {
            img = Image.FromFile(ofd.FileName);
            pictureBox2.Image = img;
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            txt_width.Text = "";
            txt_height.Text = "";
            trackBar1.Value = 0;
            reload();
        }


        private void btn_rotate_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox2.Refresh();
        }

        private void btn_zoom_Click(object sender, EventArgs e)
        {

            // Get the current size of the PictureBox
            Size currentSize = pictureBox2.Size;
            // Get the current location of the PictureBox
            Point currentLocation = pictureBox2.Location;

            // Increase the size of the PictureBox by 10%
            currentSize.Width += (int)(currentSize.Width * 0.1);
            currentSize.Height += (int)(currentSize.Height * 0.1);

            // Calculate the new location of the PictureBox to keep it centered
            currentLocation.X -= (int)(currentSize.Width * 0.05);
            currentLocation.Y -= (int)(currentSize.Height * 0.05);

            // Set the new size and location of the PictureBox
            pictureBox2.Size = currentSize;
            pictureBox2.Location = currentLocation;

            pictureBox2.Refresh();

        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            // Get the current size of the PictureBox
            Size currentSize = pictureBox2.Size;
            // Get the current location of the PictureBox
            Point currentLocation = pictureBox2.Location;

            // Decrease the size of the PictureBox by 10%
            currentSize.Width -= (int)(currentSize.Width * 0.1);
            currentSize.Height -= (int)(currentSize.Height * 0.1);

            // Calculate the new location of the PictureBox to keep it centered
            currentLocation.X += (int)(currentSize.Width * 0.05);
            currentLocation.Y += (int)(currentSize.Height * 0.05);

            // Set the new size and location of the PictureBox
            pictureBox2.Size = currentSize;
            pictureBox2.Location = currentLocation;

            pictureBox2.Refresh();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            UpdateBrightness();
        }
        private void UpdateBrightness()
        {
            // Get the current value of the TrackBar
            int brightness = trackBar1.Value;

            // Create a Bitmap object from the image file
            Bitmap bmp = new Bitmap(ofd.FileName);

            // Create a Graphics object from the Bitmap
            Graphics g = Graphics.FromImage(bmp);

            // Create a ColorMatrix object and set the brightness value
            ColorMatrix cm = new ColorMatrix(new float[][]
            {
        new float[] { 1, 0, 0, 0, 0},
        new float[] {0, 1, 0, 0, 0},
        new float[] {0, 0, 1, 0, 0},
        new float[] {0, 0, 0, 1, 0},
        new float[] {brightness/255f * 25.5f, brightness/255f * 25.5f, brightness/255f * 25.5f, 0, -100}
            });

            // Create an ImageAttributes object and set the ColorMatrix
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cm);

            // Draw the image using the ImageAttributes
            g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, ia);

            // Display the modified image
            pictureBox2.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                Application.Exit();
            }
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Form3 mf = new Form3();
            Hide();
            mf.ShowDialog();
        }
    }
}

