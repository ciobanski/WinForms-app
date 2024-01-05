namespace ImageEditor
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            login = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(158, 45);
            label4.Name = "label4";
            label4.Size = new Size(158, 111);
            label4.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 50, 50);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(101, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 39);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(50, 50, 50);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.ButtonFace;
            textBox2.Location = new Point(101, 277);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(272, 39);
            textBox2.TabIndex = 10;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(50, 50, 50);
            login.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            login.FlatStyle = FlatStyle.Flat;
            login.ForeColor = SystemColors.ButtonFace;
            login.Location = new Point(101, 367);
            login.Name = "login";
            login.Size = new Size(117, 36);
            login.TabIndex = 11;
            login.Text = "Register";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 50);
            button1.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(256, 367);
            button1.Name = "button1";
            button1.Size = new Size(117, 36);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 129);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 13;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(46, 216);
            label2.Name = "label2";
            label2.Size = new Size(24, 19);
            label2.TabIndex = 14;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(19, 290);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(458, 514);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button login;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}