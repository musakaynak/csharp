namespace girispanel
{
    partial class frm_kullanicigiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kullanicigiris));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtboxsifre = new TextBox();
            txtboxkullaniciadi = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 64);
            label2.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(366, 9);
            label2.Name = "label2";
            label2.Size = new Size(29, 27);
            label2.TabIndex = 6;
            label2.Text = "_";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(405, 9);
            label1.Name = "label1";
            label1.Size = new Size(32, 27);
            label1.TabIndex = 5;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Green;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 192, 128);
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(221, 20);
            label3.TabIndex = 7;
            label3.Text = "KULLANICI GİRİŞ EKRANI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(302, 364);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 17;
            label4.Text = "Şifremi Unuttum!";
            // 
            // txtboxsifre
            // 
            txtboxsifre.Location = new Point(210, 314);
            txtboxsifre.Multiline = true;
            txtboxsifre.Name = "txtboxsifre";
            txtboxsifre.PasswordChar = '*';
            txtboxsifre.Size = new Size(213, 38);
            txtboxsifre.TabIndex = 16;
            // 
            // txtboxkullaniciadi
            // 
            txtboxkullaniciadi.Location = new Point(210, 256);
            txtboxkullaniciadi.Multiline = true;
            txtboxkullaniciadi.Name = "txtboxkullaniciadi";
            txtboxkullaniciadi.Size = new Size(213, 38);
            txtboxkullaniciadi.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(122, 320);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 14;
            label5.Text = "ŞİFRE :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(25, 261);
            label6.Name = "label6";
            label6.Size = new Size(181, 23);
            label6.TabIndex = 13;
            label6.Text = "KULLANICI ADI  : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(189, 408);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 18;
            label7.Text = "Hesabınız Mı Yok?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(324, 408);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 19;
            label8.Text = "Hesap Oluştur.";
            label8.Click += label8_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.mnkyclose;
            pictureBox2.Location = new Point(383, 314);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frm_kullanicigiris
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Green;
            ClientSize = new Size(455, 528);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtboxsifre);
            Controls.Add(txtboxkullaniciadi);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_kullanicigiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_kullanicigiris";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtboxsifre;
        private TextBox txtboxkullaniciadi;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
    }
}