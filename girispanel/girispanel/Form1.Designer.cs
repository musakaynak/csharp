namespace girispanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cikislbl = new Label();
            altsekmeindirlbl = new Label();
            pictureBox1 = new PictureBox();
            btnYoneticiGiris = new Button();
            btnKullaniciGiris = new Button();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // cikislbl
            // 
            cikislbl.AutoSize = true;
            cikislbl.BackColor = Color.Red;
            cikislbl.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cikislbl.ForeColor = Color.Black;
            cikislbl.Location = new Point(411, 9);
            cikislbl.Name = "cikislbl";
            cikislbl.Size = new Size(32, 27);
            cikislbl.TabIndex = 1;
            cikislbl.Text = "X";
            cikislbl.Click += cikislbl_Click;
            // 
            // altsekmeindirlbl
            // 
            altsekmeindirlbl.AutoSize = true;
            altsekmeindirlbl.BackColor = Color.Blue;
            altsekmeindirlbl.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            altsekmeindirlbl.ForeColor = Color.Black;
            altsekmeindirlbl.Location = new Point(372, 9);
            altsekmeindirlbl.Name = "altsekmeindirlbl";
            altsekmeindirlbl.Size = new Size(29, 27);
            altsekmeindirlbl.TabIndex = 2;
            altsekmeindirlbl.Text = "_";
            altsekmeindirlbl.Click += altsekmeindirlbl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnYoneticiGiris
            // 
            btnYoneticiGiris.Location = new Point(97, 269);
            btnYoneticiGiris.Name = "btnYoneticiGiris";
            btnYoneticiGiris.Size = new Size(271, 67);
            btnYoneticiGiris.TabIndex = 4;
            btnYoneticiGiris.Text = "Yönetici Giriş";
            btnYoneticiGiris.UseVisualStyleBackColor = true;
            btnYoneticiGiris.Click += btnYoneticiGiris_Click;
            // 
            // btnKullaniciGiris
            // 
            btnKullaniciGiris.Location = new Point(97, 365);
            btnKullaniciGiris.Name = "btnKullaniciGiris";
            btnKullaniciGiris.Size = new Size(271, 67);
            btnKullaniciGiris.TabIndex = 5;
            btnKullaniciGiris.Text = "Kullanıcı Giriş";
            btnKullaniciGiris.UseVisualStyleBackColor = true;
            btnKullaniciGiris.Click += btnKullaniciGiris_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(101, 276);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(101, 372);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(458, 528);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(btnKullaniciGiris);
            Controls.Add(btnYoneticiGiris);
            Controls.Add(pictureBox1);
            Controls.Add(altsekmeindirlbl);
            Controls.Add(cikislbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label cikislbl;
        private Label altsekmeindirlbl;
        private PictureBox pictureBox1;
        private Button btnYoneticiGiris;
        private Button btnKullaniciGiris;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}
