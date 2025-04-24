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

namespace WindowsFormsApp7
{
    public partial class yonetmenler_Listesi : Form
    {
        public yonetmenler_Listesi()
        {
            InitializeComponent();
        }
        //veritabanı yolu
        // SqlConnection baglanti = new SqlConnection("Data Source=Veritabanının_yolu;Initial Catalog=Veritabanının_adı;Integrated Security=True");  //bağlanmak için nesne oluşturduk
        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yonetmenler_Listesi_Load(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear(); // Var olan tüm kontrolleri temizle

            baglanti.Open();
            string sorgu = "SELECT * FROM Tbl_Yonetmenler "; // Veritabanından veriyi çekme
            SqlCommand komut = new SqlCommand(sorgu, baglanti); // Sorguyu oluşturma

            // lblID.Text kullanmalısınız, Label kontrolüne doğru erişim
            

            SqlDataReader oku = komut.ExecuteReader(); // Sorguyu çalıştırma

            while (oku.Read()) // Veri okunduğu sürece döngü
            {
                Yonetmen_Sıralama arac = new Yonetmen_Sıralama(); // Yeni bir panel oluştur

                // Ad ve Soyad verilerini birleştirip LblAdSoyad'a yazma
                arac.LblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();

                // Diğer işlemler...
                arac.lblid.Text = oku["ID"].ToString(); // ID'yi label'e yazma
                arac.pbrsmdetay.ImageLocation = oku["Resim"].ToString();

                listepaneli.Controls.Add(arac); // Yeni oluşturduğumuz paneli ekliyoruz
            }

            baglanti.Close();
        }

        private void txtARA_TextChanged(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear(); // Paneli temizle

            try
            {
                baglanti.Open();

                // Eğer arama kutusu boşsa tüm kayıtları getir, doluysa Ad ve Soyad'a göre filtrele
                string sorgu = string.IsNullOrEmpty(txtARA.Text)
                    ? "SELECT * FROM Tbl_Yonetmenler"  // Arama kutusu boşsa tüm kayıtları getir
                    : "SELECT * FROM Tbl_Yonetmenler WHERE Ad LIKE '%' + @txtARA + '%' OR Soyad LIKE '%' + @txtARA + '%'";  // Arama kutusundaki metne göre filtrele

                SqlCommand arama = new SqlCommand(sorgu, baglanti);

                // Parametreyi yalnızca arama kutusunda bir metin varsa ekle
                if (!string.IsNullOrEmpty(txtARA.Text))
                {
                    arama.Parameters.AddWithValue("@txtARA", txtARA.Text); // Kullanıcının girdiği metni al
                }

                SqlDataReader oku = arama.ExecuteReader(); // Veritabanından veri oku

                // Verileri okuma ve ekleme işlemi
                while (oku.Read())
                {
                    Yonetmen_Sıralama arac = new Yonetmen_Sıralama(); // Yeni bir panel oluştur

                    // Ad ve Soyad verilerini birleştirip LblAdSoyad'a yazma
                    arac.LblAdSoyad.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();

                    // Diğer işlemler...
                    arac.lblid.Text = oku["ID"].ToString();
                    arac.pbrsmdetay.ImageLocation = oku["Resim"].ToString(); // Resim yolunu al

                    listepaneli.Controls.Add(arac); // Yeni oluşturduğumuz paneli ekliyoruz
                }

                oku.Close();  // SqlDataReader'ı kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);  // Hata durumunda mesaj göster
            }
            finally
            {
                baglanti.Close();  // Veritabanı bağlantısını kapat
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

    

        
    






