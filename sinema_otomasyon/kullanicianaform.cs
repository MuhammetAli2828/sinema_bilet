using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class kullanicianaform : Form
    {
        private string kullaniciAdi; // Kullanıcı adı

        public kullanicianaform(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi; // Kullanıcı adı parametresiyle formu başlat
        }

        private void kullanicianaform_Load(object sender, EventArgs e)
        {
            // Formun arka planına resim ekle
            this.BackgroundImage = Image.FromFile("C:\\Users\\mgode\\OneDrive\\Masaüstü\\arkaplan.jpg");  // Burada doğru dosya yolunu belirlemelisiniz
            this.BackgroundImageLayout = ImageLayout.Stretch;  // Resmin formu doldurmasını sağla

            // lblkullaniciad ve button1'i sağ üst köşeye yerleştir
            YerlesimAyarla();

            // Kullanıcı adı lblkullaniciad üzerine ekleniyor
            lblkullaniciad.Text = "Hoşgeldin, " + kullaniciAdi; // lblkullaniciad etiketine kullanıcı adı ekleniyor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void YerlesimAyarla()
        {
            int padding = 10; // Sağdan boşluk
            int shift = 200; // Hem buton hem de etiket için sola kaydırma miktarı

            // lblkullaniciad'ı sağa yerleştiriyoruz, biraz sola kaydırdık
            lblkullaniciad.Location = new Point(
                this.ClientSize.Width - lblkullaniciad.Width - button1.Width - (2 * padding) - shift, // Sağdan boşluk ve buton genişliği, biraz sola kaydırdık
                padding // Yukarıdan boşluk
            );

            // Eğer form küçültülmüşse kontroller görünür durumda mı kontrol et
            lblkullaniciad.Visible = true;
            button1.Visible = true;
        }

        private void kullanicianaform_Resize(object sender, EventArgs e)
        {
            // Form yeniden boyutlandırıldığında kontrolleri yeniden düzenle
            YerlesimAyarla();
        }

        private void btn_oyuculiste_Click(object sender, EventArgs e)
        {
            FrmOyuncuListe frm=new FrmOyuncuListe();
            frm.ShowDialog();
        }

        private void btnbiletislem_Click(object sender, EventArgs e)
        {
            frmBiletİslemleri frm=new frmBiletİslemleri(kullaniciAdi);
            frm.ShowDialog();
        }

        private void btngelecekfilm_Click(object sender, EventArgs e)
        {
            frmgelecekfilm frm = new frmgelecekfilm();
            frm.ShowDialog();
        }

        private void btnyontmenliste_Click(object sender, EventArgs e)
        {
            yonetmenler_Listesi frm=new yonetmenler_Listesi();
            frm.ShowDialog();
        }

        private void btntümfilmler_Click(object sender, EventArgs e)
        {
            frmFilmListele frm =new frmFilmListele(kullaniciAdi);
            frm.ShowDialog();
        }

        private void lblbiletim_Click(object sender, EventArgs e)
        {
            frmBiletim frm =new frmBiletim(kullaniciAdi);
            frm.ShowDialog();
        }

        private void lblkoltuklar_Click(object sender, EventArgs e)
        {
           frmKoltukSec frm = new frmKoltukSec();
            frm.ShowDialog();
        }
    }
}
