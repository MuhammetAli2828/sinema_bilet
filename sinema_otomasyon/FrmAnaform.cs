using System;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FrmAnaform : Form
    {
        private string kullaniciRol;
        private string kullaniciAd;  // Kullanıcı adı için bir değişken ekleniyor

        // FrmAnaform constructor'ı, rol bilgisi ve kullanıcı adını alacak şekilde güncelleniyor.
        public FrmAnaform(string rol, string kullaniciAd)
        {
            InitializeComponent();
            this.kullaniciRol = rol; // Kullanıcı rolünü al
            this.kullaniciAd = kullaniciAd; // Kullanıcı adını al
        }

        private void FrmAnaform_Load(object sender, EventArgs e)
        {

            // Kullanıcı adını ekranda göstermek için
            lblkullaniciad.Text = "Hoşgeldiniz, " + kullaniciAd; // Label kontrolüne kullanıcı adını yazdırıyoruz.

            // Kullanıcı rolüne göre butonların durumunu ayarlama
            if (kullaniciRol == "Admin")
            {
                // Admin için tüm butonlar aktif
                btnyönetmenkaydett.Enabled = true;
                btnyontmenliste.Enabled = true;
                btnoyuncukyt.Enabled = true;
                btn_oyuculiste.Enabled = true;
                btnsalonkayit.Enabled = true;
                button2.Enabled = true;
                btnbiletislem.Enabled = true;
            }
            else if (kullaniciRol == "Yönetici")
            {
                // Yönetici için bazı butonlar aktif
                btnyönetmenkaydett.Enabled = true;
                btnyontmenliste.Enabled = true;
                btnoyuncukyt.Enabled = true;
                btn_oyuculiste.Enabled = true;
                btnsalonkayit.Enabled = true;
                button2.Enabled = true;
                btnbiletislem.Enabled = false; // Yönetici bilet işlemi yapmaz
            }
            else if (kullaniciRol == "Kullanıcı")
            {
                // Kullanıcı için sadece belirli butonlar aktif
                btnyönetmenkaydett.Enabled = false;
                btnyontmenliste.Enabled = true; // Yönetmen Liste
                btnoyuncukyt.Enabled = false;  // Oyuncu Kayıt
                btn_oyuculiste.Enabled = true; // Oyuncu Liste
                btnsalonkayit.Enabled = false; // Salon Kayıt
                button2.Enabled = false;   // Film Kayıt
                btnbiletislem.Enabled = true;  // Bilet İşlemleri
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbiletislem_Click_1(object sender, EventArgs e)
        {
            frmBiletİslemleri frm = new frmBiletİslemleri(kullaniciAd);
            frm.ShowDialog();
        }

        private void Btn_YontmnKyt_Click(object sender, EventArgs e)
        {
            FrmYonetmenKayit1 frm = new FrmYonetmenKayit1();
            frm.ShowDialog();
        }

        private void btn_oyuculiste_Click(object sender, EventArgs e)
        {
            FrmOyuncuListe frm = new FrmOyuncuListe();
            frm.ShowDialog();
        }

        private void btnyontmenliste_Click(object sender, EventArgs e)
        {
            yonetmenler_Listesi frm = new yonetmenler_Listesi();
            frm.ShowDialog();
        }

        private void btnoyuncukyt_Click(object sender, EventArgs e)
        {
            FrmOyuncuKayit frm = new FrmOyuncuKayit();
            frm.ShowDialog();
        }

        private void btnsalonkayit_Click(object sender, EventArgs e)
        {
            FrmSalonKayit frm = new FrmSalonKayit();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmfilmekle frmfilmekle = new frmfilmekle();
            frmfilmekle.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmYonetmenKayit1 frm = new FrmYonetmenKayit1();
            frm.ShowDialog();
        }

        private void btntümfilmler_Click(object sender, EventArgs e)
        {
            frmFilmListele frm = new frmFilmListele(kullaniciRol);
            frm.ShowDialog();
        }

        private void lblkullaniciad_Click(object sender, EventArgs e)
        {

        }

        private void btnbiletim_Click(object sender, EventArgs e)
        {

            // Bu formda, gerekli parametreleri almanız gerekiyor.
            // Örneğin, burada varsayalım ki filmAdi, salonAdi, ad, soyad, biletTuru, imdbPuani, koltukNo gibi verileri alıyorsunuz.

            // Bu parametreleri uygun şekilde tanımlayın
            string filmAdi = "Film Adı";  // Bu değerler gerçek verilere göre ayarlanmalıdır.
            string salonAdi = "Salon 1";  // Örnek veriler
            string ad = "Adınız";
            string soyad = "Soyadınız";
            string biletTuru = "VIP";
            double imdbPuani = 8.5;
            string koltukNo = "A1";
            //string kullaniciAd = ;

            // FrmBİLETİM formunu parametrelerle açma
           // FrmBİLETİM frm = new FrmBİLETİM(kullaniciAd, filmAdi, salonAdi, ad, soyad, biletTuru, imdbPuani, koltukNo);
            //frm.ShowDialog(); // ShowDialog ile modal olarak açıyoruz
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btngelecekfilm_Click(object sender, EventArgs e)
        {
            frmgelecekfilm frmgelecekfilm = new frmgelecekfilm();
            frmgelecekfilm.ShowDialog();
        }

        private void lblbiletim_Click(object sender, EventArgs e)
        {
            frmBiletim frm=new frmBiletim(kullaniciAd);
            frm.ShowDialog();
        }

        private void btnkullanıcılar_Click(object sender, EventArgs e)
        {
            frmkullanıcılar frm =new frmkullanıcılar();
            frm.ShowDialog();
        }
    }
}
