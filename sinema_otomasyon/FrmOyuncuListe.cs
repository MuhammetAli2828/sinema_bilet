using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    public partial class FrmOyuncuListe : Form
    {
        public FrmOyuncuListe()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtARA_TextChanged(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear(); // Paneli temizle

            try
            {
                baglanti.Open();

                // Eğer arama kutusu boşsa tüm kayıtları getir, doluysa Ad ve Soyad'a göre filtrele
                string sorgu = string.IsNullOrEmpty(txtARA.Text)
                    ? "SELECT * FROM Tbl_Oyuncular"  // Arama kutusu boşsa tüm kayıtları getir
                    : "SELECT * FROM Tbl_Oyuncular WHERE Ad LIKE '%' + @txtARA + '%' OR Soyad LIKE '%' + @txtARA + '%'";  // Arama kutusundaki metne göre filtrele

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
                    OyuncuSıralama arac = new OyuncuSıralama(); // Yeni bir panel oluştur

                    // Ad ve Soyad verilerini birleştirip LblAdSoyad'a yazma
                    arac.LblAdSoyad.Text = oku["AD"].ToString() + " " + oku["SOYAD"].ToString();

                    // Diğer işlemler...
                    arac.lblid.Text = oku["ID"].ToString();
                    arac.pbrsmdetay.ImageLocation = oku["RESİM"].ToString(); // Resim yolunu al

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
        


        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");
        private void FrmOyuncuListe_Load(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear(); // Var olan tüm kontrolleri temizle

            try
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Tbl_Oyuncular"; // Veritabanından veriyi çekme
                SqlCommand komut = new SqlCommand(sorgu, baglanti); // Sorguyu oluşturma

                SqlDataReader oku = komut.ExecuteReader(); // Sorguyu çalıştırma

                while (oku.Read()) // Veri okunduğu sürece döngü
                {
                    OyuncuSıralama arac = new OyuncuSıralama(); // Yeni bir panel oluştur

                    // Ad ve Soyad verilerini al, soyadın boş olup olmadığını kontrol et
                    string soyad = oku["SOYAD"] == DBNull.Value ? "" : oku["SOYAD"].ToString(); // Eğer Soyad boşsa, "" olarak al
                    arac.LblAdSoyad.Text = oku["AD"].ToString() + " " + soyad; // Ad ve Soyadı birleştirip yazma

                    // Diğer işlemler...
                    arac.lblid.Text = oku["ID"].ToString(); // ID'yi label'e yazma
                    arac.pbrsmdetay.ImageLocation = oku["RESİM"].ToString(); // Resim yolunu al

                    listepaneli.Controls.Add(arac); // Yeni oluşturduğumuz paneli ekliyoruz
                }
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


    }
}

