namespace ImageEditor
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            admin = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            btnSavePath = new Button();
            btnload = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 424);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 44);
            label2.Name = "label2";
            label2.Size = new Size(296, 52);
            label2.TabIndex = 20;
            label2.Text = "Image database";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(426, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 427);
            panel1.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(394, 23);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // admin
            // 
            admin.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            admin.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            admin.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 55);
            admin.FlatStyle = FlatStyle.Flat;
            admin.Image = (Image)resources.GetObject("admin.Image");
            admin.Location = new Point(42, 297);
            admin.Name = "admin";
            admin.Size = new Size(65, 61);
            admin.TabIndex = 23;
            admin.UseVisualStyleBackColor = true;
            admin.Click += admin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(123, 304);
            label3.Name = "label3";
            label3.Size = new Size(90, 36);
            label3.TabIndex = 24;
            label3.Text = "USERS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 23);
            textBox1.TabIndex = 25;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 127);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 26;
            label1.Text = "Add path";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 192);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 27;
            label4.Text = "Select";
            // 
            // btnSavePath
            // 
            btnSavePath.FlatStyle = FlatStyle.Flat;
            btnSavePath.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavePath.ForeColor = SystemColors.ButtonFace;
            btnSavePath.Location = new Point(337, 169);
            btnSavePath.Name = "btnSavePath";
            btnSavePath.Size = new Size(81, 35);
            btnSavePath.TabIndex = 28;
            btnSavePath.Text = "ADD";
            btnSavePath.UseVisualStyleBackColor = true;
            btnSavePath.Click += btnSavePath_Click;
            // 
            // btnload
            // 
            btnload.FlatStyle = FlatStyle.Flat;
            btnload.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnload.ForeColor = SystemColors.ButtonFace;
            btnload.Location = new Point(337, 239);
            btnload.Name = "btnload";
            btnload.Size = new Size(81, 35);
            btnload.TabIndex = 29;
            btnload.Text = "LOAD";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(12, 401);
            button2.Name = "button2";
            button2.Size = new Size(81, 35);
            button2.TabIndex = 30;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(968, 442);
            Controls.Add(button2);
            Controls.Add(btnload);
            Controls.Add(btnSavePath);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(admin);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            ForeColor = Color.Transparent;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private ComboBox comboBox1;
        private Button admin;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private Button btnSavePath;
        private Button btnload;
        private Button button2;
    }
}