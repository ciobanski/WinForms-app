namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            trackBar1 = new TrackBar();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            zoomout = new Button();
            label3 = new Label();
            btn_zoom = new Button();
            btn_rotate = new Button();
            bindingSource1 = new BindingSource(components);
            panel5 = new Panel();
            admin = new Button();
            button1 = new Button();
            btn_resize = new Button();
            btn_reload = new Button();
            btn_save = new Button();
            btn_open = new Button();
            label4 = new Label();
            label5 = new Label();
            lbl_size = new Label();
            txt_imgpath = new TextBox();
            txt_height = new TextBox();
            txt_width = new TextBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg1;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(65, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 406);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(750, 406);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 242);
            trackBar1.Maximum = 5;
            trackBar1.Minimum = -5;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 333);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(819, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 153);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Controls.Add(zoomout);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_zoom);
            panel2.Controls.Add(trackBar1);
            panel2.Controls.Add(btn_rotate);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(12, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(47, 592);
            panel2.TabIndex = 1;
            // 
            // zoomout
            // 
            zoomout.BackColor = Color.FromArgb(50, 50, 50);
            zoomout.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            zoomout.FlatStyle = FlatStyle.Flat;
            zoomout.Image = (Image)resources.GetObject("zoomout.Image");
            zoomout.Location = new Point(2, 135);
            zoomout.Name = "zoomout";
            zoomout.Size = new Size(44, 44);
            zoomout.TabIndex = 19;
            zoomout.UseVisualStyleBackColor = false;
            zoomout.Click += zoomout_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(40, 40, 40);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(2, 197);
            label3.Name = "label3";
            label3.Size = new Size(42, 42);
            label3.TabIndex = 14;
            // 
            // btn_zoom
            // 
            btn_zoom.BackColor = Color.FromArgb(50, 50, 50);
            btn_zoom.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btn_zoom.FlatStyle = FlatStyle.Flat;
            btn_zoom.Image = (Image)resources.GetObject("btn_zoom.Image");
            btn_zoom.Location = new Point(2, 85);
            btn_zoom.Name = "btn_zoom";
            btn_zoom.Size = new Size(44, 44);
            btn_zoom.TabIndex = 18;
            btn_zoom.UseVisualStyleBackColor = false;
            btn_zoom.Click += btn_zoom_Click;
            // 
            // btn_rotate
            // 
            btn_rotate.BackColor = Color.FromArgb(50, 50, 50);
            btn_rotate.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btn_rotate.FlatStyle = FlatStyle.Flat;
            btn_rotate.ForeColor = SystemColors.ControlText;
            btn_rotate.Image = (Image)resources.GetObject("btn_rotate.Image");
            btn_rotate.Location = new Point(1, 32);
            btn_rotate.Name = "btn_rotate";
            btn_rotate.Size = new Size(44, 44);
            btn_rotate.TabIndex = 2;
            btn_rotate.UseVisualStyleBackColor = false;
            btn_rotate.Click += btn_rotate_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 50, 50);
            panel5.Controls.Add(admin);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(btn_resize);
            panel5.Controls.Add(btn_reload);
            panel5.Controls.Add(btn_save);
            panel5.Controls.Add(btn_open);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lbl_size);
            panel5.Controls.Add(txt_imgpath);
            panel5.Controls.Add(txt_height);
            panel5.Controls.Add(txt_width);
            panel5.Location = new Point(17, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(891, 145);
            panel5.TabIndex = 12;
            // 
            // admin
            // 
            admin.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            admin.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            admin.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 55);
            admin.FlatStyle = FlatStyle.Flat;
            admin.Image = (Image)resources.GetObject("admin.Image");
            admin.Location = new Point(743, 77);
            admin.Name = "admin";
            admin.Size = new Size(65, 61);
            admin.TabIndex = 16;
            admin.UseVisualStyleBackColor = true;
            admin.Click += admin_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(70, 70, 70);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(8, 81);
            button1.Name = "button1";
            button1.Size = new Size(53, 57);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_resize
            // 
            btn_resize.FlatStyle = FlatStyle.Flat;
            btn_resize.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_resize.ForeColor = SystemColors.ButtonFace;
            btn_resize.Location = new Point(605, 36);
            btn_resize.Name = "btn_resize";
            btn_resize.Size = new Size(81, 35);
            btn_resize.TabIndex = 14;
            btn_resize.Text = "SET";
            btn_resize.UseVisualStyleBackColor = true;
            btn_resize.Click += btn_resize_Click;
            // 
            // btn_reload
            // 
            btn_reload.FlatStyle = FlatStyle.Flat;
            btn_reload.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reload.ForeColor = SystemColors.ButtonFace;
            btn_reload.Location = new Point(605, 71);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(81, 36);
            btn_reload.TabIndex = 3;
            btn_reload.Text = "RESET";
            btn_reload.UseVisualStyleBackColor = true;
            btn_reload.Click += btn_reload_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Transparent;
            btn_save.Cursor = Cursors.Hand;
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 55);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.FromArgb(50, 50, 50);
            btn_save.Image = (Image)resources.GetObject("btn_save.Image");
            btn_save.Location = new Point(814, 77);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(65, 61);
            btn_save.TabIndex = 13;
            btn_save.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_open
            // 
            btn_open.FlatStyle = FlatStyle.Flat;
            btn_open.Font = new Font("Aileron Heavy", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_open.ForeColor = SystemColors.ButtonFace;
            btn_open.Location = new Point(8, 36);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(30, 23);
            btn_open.TabIndex = 12;
            btn_open.Text = "‎ ...";
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += button9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(50, 50, 50);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(491, 40);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 9;
            label4.Text = "W";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(50, 50, 50);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(492, 81);
            label5.Name = "label5";
            label5.Size = new Size(16, 15);
            label5.TabIndex = 10;
            label5.Text = "H";
            // 
            // lbl_size
            // 
            lbl_size.AutoSize = true;
            lbl_size.BackColor = Color.FromArgb(50, 50, 50);
            lbl_size.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_size.ForeColor = SystemColors.ButtonFace;
            lbl_size.Location = new Point(4, 5);
            lbl_size.Name = "lbl_size";
            lbl_size.Size = new Size(123, 22);
            lbl_size.TabIndex = 11;
            lbl_size.Text = "Image resizer";
            // 
            // txt_imgpath
            // 
            txt_imgpath.BackColor = Color.FromArgb(50, 50, 50);
            txt_imgpath.ForeColor = SystemColors.ButtonFace;
            txt_imgpath.Location = new Point(40, 36);
            txt_imgpath.Name = "txt_imgpath";
            txt_imgpath.Size = new Size(392, 23);
            txt_imgpath.TabIndex = 0;
            txt_imgpath.TextChanged += txt_imgpath_TextChanged;
            // 
            // txt_height
            // 
            txt_height.BackColor = Color.FromArgb(50, 50, 50);
            txt_height.ForeColor = SystemColors.ButtonFace;
            txt_height.Location = new Point(515, 36);
            txt_height.Name = "txt_height";
            txt_height.Size = new Size(60, 23);
            txt_height.TabIndex = 2;
            // 
            // txt_width
            // 
            txt_width.BackColor = Color.FromArgb(50, 50, 50);
            txt_width.ForeColor = SystemColors.ButtonFace;
            txt_width.Location = new Point(515, 77);
            txt_width.Name = "txt_width";
            txt_width.Size = new Size(60, 23);
            txt_width.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 40, 40);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(65, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(927, 180);
            panel3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1004, 618);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImageEditor";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_reload;
        private TextBox txt_height;
        private TextBox txt_width;
        private TextBox txt_imgpath;
        private Label lbl_size;
        private Label label5;
        private Label label4;
        private Panel panel5;
        private Button btn_open;
        private BindingSource bindingSource1;
        private Button btn_save;
        private Button btn_zoom;
        private Button btn_resize;
        private Button btn_rotate;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label6;
        private Button zoomout;
        private TrackBar trackBar1;
        private TrackBar trackBar3;
        private Button button1;
        private Button admin;
        private Label lblWelcome;
    }
}