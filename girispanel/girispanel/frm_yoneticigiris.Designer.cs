namespace girispanel
{
    partial class frm_yoneticigiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_yoneticigiris));
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            txtboxsifre = new TextBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 0, 64);
            label6.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(420, 9);
            label6.Name = "label6";
            label6.Size = new Size(29, 27);
            label6.TabIndex = 4;
            label6.Text = "_";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 64);
            label5.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(459, 9);
            label5.Name = "label5";
            label5.Size = new Size(32, 27);
            label5.TabIndex = 3;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 5;
            label1.Text = "YÖNETİCİ GİRİŞ EKRANI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(49, 290);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 7;
            label2.Text = "KULLANICI ID  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(133, 349);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 8;
            label3.Text = "ŞİFRE :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 281);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 38);
            textBox1.TabIndex = 9;
            // 
            // txtboxsifre
            // 
            txtboxsifre.Location = new Point(225, 343);
            txtboxsifre.Multiline = true;
            txtboxsifre.Name = "txtboxsifre";
            txtboxsifre.PasswordChar = '*';
            txtboxsifre.Size = new Size(246, 38);
            txtboxsifre.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(336, 411);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 11;
            label4.Text = "Şifremi Unuttum!";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.mnkyclose;
            pictureBox2.Location = new Point(431, 343);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frm_yoneticigiris
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(501, 539);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(txtboxsifre);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_yoneticigiris";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox txtboxsifre;
        private Label label4;
        private PictureBox pictureBox2;
    }
}