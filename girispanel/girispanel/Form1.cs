namespace girispanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cikislbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void altsekmeindirlbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            frm_yoneticigiris frm_Yoneticigiris = new frm_yoneticigiris();
            frm_Yoneticigiris.Show();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            frm_kullanicigiris frm_Kullanicigiris = new frm_kullanicigiris();
            frm_Kullanicigiris.Show();
        }
    }
}
