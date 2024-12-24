namespace Ödeme_ve_bilgi_işlemleri
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label22 = new Label();
            textBox12 = new TextBox();
            label16 = new Label();
            textBox11 = new TextBox();
            comboBox4 = new ComboBox();
            textBox10 = new TextBox();
            panel1 = new Panel();
            button13 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox9 = new TextBox();
            button17 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            ımageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(753, 356);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme ve işlemler kontrol bilgileri";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(textBox12);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(textBox11);
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(502, 327);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label22.Location = new Point(34, 170);
            label22.Name = "label22";
            label22.Size = new Size(162, 17);
            label22.TabIndex = 3;
            label22.Text = "Kullanılan malzeme bilgisi";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(34, 190);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(422, 99);
            textBox12.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label16.Location = new Point(34, 38);
            label16.Name = "label16";
            label16.Size = new Size(119, 17);
            label16.TabIndex = 1;
            label16.Text = "Cihaz arızası bilgisi";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(34, 58);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(422, 99);
            textBox11.TabIndex = 0;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "ÖDENDİ", "ÖDENMEDİ" });
            comboBox4.Location = new Point(526, 317);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(200, 23);
            comboBox4.TabIndex = 11;
            comboBox4.Text = "Ödeme bilgisi";
            comboBox4.UseWaitCursor = true;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(526, 288);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Toplam Tutar";
            textBox10.RightToLeft = RightToLeft.Yes;
            textBox10.Size = new Size(200, 23);
            textBox10.TabIndex = 10;
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button18);
            panel1.Controls.Add(button19);
            panel1.Controls.Add(button20);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(button17);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(button16);
            panel1.Location = new Point(520, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 251);
            panel1.TabIndex = 9;
            // 
            // button13
            // 
            button13.BackColor = Color.Coral;
            button13.BackgroundImageLayout = ImageLayout.Center;
            button13.Cursor = Cursors.Hand;
            button13.FlatAppearance.BorderSize = 8;
            button13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button13.Location = new Point(106, 197);
            button13.Name = "button13";
            button13.Size = new Size(50, 50);
            button13.TabIndex = 25;
            button13.Text = "=";
            button13.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = Color.DimGray;
            button18.BackgroundImageLayout = ImageLayout.Center;
            button18.Cursor = Cursors.Hand;
            button18.FlatAppearance.BorderSize = 8;
            button18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button18.Location = new Point(106, 148);
            button18.Name = "button18";
            button18.Size = new Size(50, 50);
            button18.TabIndex = 24;
            button18.Text = "3";
            button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = Color.DimGray;
            button19.BackgroundImageLayout = ImageLayout.Center;
            button19.Cursor = Cursors.Hand;
            button19.FlatAppearance.BorderSize = 8;
            button19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button19.Location = new Point(106, 99);
            button19.Name = "button19";
            button19.Size = new Size(50, 50);
            button19.TabIndex = 23;
            button19.Text = "6";
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = Color.DimGray;
            button20.BackgroundImageLayout = ImageLayout.Center;
            button20.Cursor = Cursors.Hand;
            button20.FlatAppearance.BorderSize = 8;
            button20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button20.Location = new Point(106, 50);
            button20.Name = "button20";
            button20.Size = new Size(50, 50);
            button20.TabIndex = 22;
            button20.Text = "9";
            button20.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkSalmon;
            button9.BackgroundImageLayout = ImageLayout.Center;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 8;
            button9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button9.Location = new Point(56, 197);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 21;
            button9.Text = ",";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.DimGray;
            button10.BackgroundImageLayout = ImageLayout.Center;
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderSize = 8;
            button10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button10.Location = new Point(56, 148);
            button10.Name = "button10";
            button10.Size = new Size(50, 50);
            button10.TabIndex = 20;
            button10.Text = "2";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.DimGray;
            button11.BackgroundImageLayout = ImageLayout.Center;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderSize = 8;
            button11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button11.Location = new Point(56, 99);
            button11.Name = "button11";
            button11.Size = new Size(50, 50);
            button11.TabIndex = 19;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.DimGray;
            button12.BackgroundImageLayout = ImageLayout.Center;
            button12.Cursor = Cursors.Hand;
            button12.FlatAppearance.BorderSize = 8;
            button12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button12.Location = new Point(56, 50);
            button12.Name = "button12";
            button12.Size = new Size(50, 50);
            button12.TabIndex = 18;
            button12.Text = "8";
            button12.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 8;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button5.Location = new Point(6, 197);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 17;
            button5.Text = "0";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 8;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button6.Location = new Point(6, 148);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 16;
            button6.Text = "1";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 8;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button7.Location = new Point(6, 99);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 15;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.BackgroundImageLayout = ImageLayout.Center;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderSize = 8;
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button8.Location = new Point(6, 50);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 14;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = false;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Coral;
            textBox9.Location = new Point(6, 5);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(200, 43);
            textBox9.TabIndex = 13;
            // 
            // button17
            // 
            button17.BackColor = Color.DarkSalmon;
            button17.BackgroundImageLayout = ImageLayout.Center;
            button17.Cursor = Cursors.Hand;
            button17.FlatAppearance.BorderSize = 8;
            button17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button17.Location = new Point(156, 197);
            button17.Name = "button17";
            button17.Size = new Size(50, 50);
            button17.TabIndex = 12;
            button17.Text = "+";
            button17.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.DarkSalmon;
            button14.BackgroundImageLayout = ImageLayout.Center;
            button14.Cursor = Cursors.Hand;
            button14.FlatAppearance.BorderSize = 8;
            button14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button14.Location = new Point(156, 148);
            button14.Name = "button14";
            button14.Size = new Size(50, 50);
            button14.TabIndex = 11;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.DarkSalmon;
            button15.BackgroundImageLayout = ImageLayout.Center;
            button15.Cursor = Cursors.Hand;
            button15.FlatAppearance.BorderSize = 8;
            button15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button15.Location = new Point(156, 99);
            button15.Name = "button15";
            button15.Size = new Size(50, 50);
            button15.TabIndex = 10;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.DarkSalmon;
            button16.BackgroundImageLayout = ImageLayout.Center;
            button16.Cursor = Cursors.Hand;
            button16.FlatAppearance.BorderSize = 8;
            button16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button16.Location = new Point(156, 50);
            button16.Name = "button16";
            button16.Size = new Size(50, 50);
            button16.TabIndex = 9;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "1000_F_258719217_WsizL21A8gtLJypWYs1vuVUDMhCTa1Tw.jpg");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 379);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ÖZDİEM";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label22;
        private TextBox textBox12;
        private Label label16;
        private TextBox textBox11;
        private ComboBox comboBox4;
        private TextBox textBox10;
        private Panel panel1;
        private Button button13;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox9;
        private Button button17;
        private Button button14;
        private Button button15;
        private Button button16;
        private ImageList ımageList1;
    }
}
