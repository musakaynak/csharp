using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girispanel
{
    public partial class frm_kullanicihesapolustur : Form
    {
        // Şifre göster/gizle durumu
        private bool isPasswordVisible = false;
        public frm_kullanicihesapolustur()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Şifre göster/gizle durumunu kontrol et
            if (isPasswordVisible)
            {
                txtboxsifre.PasswordChar = '*'; // Şifreyi gizle
                pictureBox2.Image = Properties.Resources.mnkyclose; // Kapalı göz simgesini göster
            }
            else
            {
                txtboxsifre.PasswordChar = '\0'; // Şifreyi göster
                pictureBox2.Image = Properties.Resources.mnkyopen; // Açık göz simgesini göster
            }
            // Durumu tersine çevir
            isPasswordVisible = !isPasswordVisible;
        }
    }
}
