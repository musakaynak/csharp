namespace Müşteri_Bilgileri
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
            button1 = new Button();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            comboBox2 = new ComboBox();
            label21 = new Label();
            label22 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(214, 304);
            button1.Name = "button1";
            button1.Size = new Size(121, 28);
            button1.TabIndex = 50;
            button1.Text = "Müşteri kaydet";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(143, 184);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(182, 81);
            textBox8.TabIndex = 49;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(143, 97);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(182, 23);
            textBox7.TabIndex = 48;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(143, 126);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(182, 23);
            textBox6.TabIndex = 47;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(143, 68);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 23);
            comboBox2.TabIndex = 45;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(45, 184);
            label21.Name = "label21";
            label21.Size = new Size(80, 15);
            label21.TabIndex = 42;
            label21.Text = "Müşteri Adres";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(127, 184);
            label22.Name = "label22";
            label22.Size = new Size(10, 15);
            label22.TabIndex = 43;
            label22.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 158);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 40;
            label11.Text = "Müşteri Mail";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(127, 155);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 41;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(39, 129);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 38;
            label13.Text = "Müşteri Tel No.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(127, 126);
            label14.Name = "label14";
            label14.Size = new Size(10, 15);
            label14.TabIndex = 39;
            label14.Text = ":";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 100);
            label15.Name = "label15";
            label15.Size = new Size(106, 15);
            label15.TabIndex = 36;
            label15.Text = "Müşteri Adı Soyadı";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(127, 100);
            label16.Name = "label16";
            label16.Size = new Size(10, 15);
            label16.TabIndex = 37;
            label16.Text = ":";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(53, 68);
            label17.Name = "label17";
            label17.Size = new Size(72, 15);
            label17.TabIndex = 34;
            label17.Text = "Cihaz Marka";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(127, 68);
            label18.Name = "label18";
            label18.Size = new Size(10, 15);
            label18.TabIndex = 35;
            label18.Text = ":";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(65, 39);
            label19.Name = "label19";
            label19.Size = new Size(60, 15);
            label19.TabIndex = 32;
            label19.Text = "Müşteri id";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(127, 39);
            label20.Name = "label20";
            label20.Size = new Size(10, 15);
            label20.TabIndex = 33;
            label20.Text = ":";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label20);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 348);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri bilgileri";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 51;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 371);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ÖZDİEM";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private ComboBox comboBox2;
        private Label label21;
        private Label label22;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
