using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    public partial class frmüyeol : Form
    {
        public frmüyeol()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");
        private void frmüyeol_Load(object sender, EventArgs e)
        {
        
            // Formun arka planına resim ekle
            this.BackgroundImage = Image.FromFile("C:\\Users\\mgode\\OneDrive\\Masaüstü\\üyeol.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

   
            // Kaydet butonu için ayarlar
            btnüyekaydet.FlatStyle = FlatStyle.Flat; // Çerçeveyi kaldır
            btnüyekaydet.FlatAppearance.BorderSize = 0; // Çerçeve kalınlığını sıfırla
            btnüyekaydet.FlatAppearance.MouseDownBackColor = Color.Transparent; // Tıklandığında arka plan
            btnüyekaydet.FlatAppearance.MouseOverBackColor = Color.Transparent; // Üzerine gelindiğinde arka plan
            btnüyekaydet.BackColor = Color.Transparent; // Genel arka planı şeffaf yap
            //btnüyekaydet.Image = ResizeImage(Image.FromFile("C:\\Users\\mgode\\OneDrive\\Masaüstü\\kaydet.jpg"), 24, 24);
            btnüyekaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnüyekaydet.Text = "Kaydet";
            btnüyekaydet.TextImageRelation = TextImageRelation.ImageBeforeText;

            // İptal butonu için ayarlar
            btnüyeiptal.FlatStyle = FlatStyle.Flat; // Çerçeveyi kaldır
            btnüyeiptal.FlatAppearance.BorderSize = 0; // Çerçeve kalınlığını sıfırla
            btnüyeiptal.FlatAppearance.MouseDownBackColor = Color.Transparent; // Tıklandığında arka plan
            btnüyeiptal.FlatAppearance.MouseOverBackColor = Color.Transparent; // Üzerine gelindiğinde arka plan
            btnüyeiptal.BackColor = Color.Transparent; // Genel arka planı şeffaf yap
            btnüyeiptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnüyeiptal.Text = "İptal";
            btnüyeiptal.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        // Resmi boyutlandıran fonksiyon
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }



        private void btnüyekaydet_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifreyi al
            string kullaniciAdi = txtüyekadı.Text;
            string sifre = txtüyeksifre.Text;
            string rol = "Kullanıcı"; // Varsayılan rol "Kullanıcı"
            string eposta = txteposta.Text;

            // SQL komutunu oluştur
            string sorgu = "INSERT INTO tbl_kullanicilar (KADI, KSİFRE, Role,EPOSTA) VALUES (@KullaniciAdi, @Sifre, @Rol, @EPOSTA)";

            // Bağlantıyı aç
            try
            {
                baglanti.Open();

                // SqlCommand nesnesi oluştur
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                // Parametreleri ekle
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@Sifre", sifre);
                komut.Parameters.AddWithValue("@Rol", rol); // Rolü "Kullanıcı" olarak ekle
                komut.Parameters.AddWithValue("@EPOSTA", eposta);

                // Sorguyu çalıştır
                komut.ExecuteNonQuery();

                // Başarı mesajı
                MessageBox.Show("Üye kaydedildi!");

                // Formu kapat
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();

            }
            txtüyekadı.Focus();
        }

        private void btnüyeiptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}