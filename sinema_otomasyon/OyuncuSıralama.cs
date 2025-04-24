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

namespace WindowsFormsApp7
{
    public partial class OyuncuSıralama : UserControl
    {
        public OyuncuSıralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void btndetay_Click(object sender, EventArgs e)
        {
            baglanti.Open(); // Bağlantıyı aç
            string sorgu = "select * from Tbl_Oyuncular WHERE ID=@P1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti); // Veritabanı sorgusu
            komut.Parameters.AddWithValue("@P1", lblid.Text); // Parametre ekle

            SqlDataReader oku = komut.ExecuteReader(); // Veriyi oku

            if (oku.Read()) // Veri varsa
            {
                // Ad ve Soyadı birleştir
                string adSoyad = $"{oku["AD"]} {oku["SOYAD"]}";

                // Biyografiyi oku ve mesaj kutusunda göster
                MessageBox.Show("Yönetmenin Biyografisi:\n" + oku["BİYOGRAFİ"].ToString(), adSoyad);
            }

            baglanti.Close(); // Bağlantıyı kapat
        }
        

        private void LblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Tbl_Oyuncular WHERE ID=@p1", baglanti); //SQL sorgusudur. Bu sorgu, Tbl_Yonetmenler tablosundan ID değeri eşleşen bir kaydı siler.
            sil.Parameters.AddWithValue("@p1", lblid.Text);   //sql sorgusunda kullanılan p1 parametresine bir değer atar.                        
            sil.ExecuteNonQuery();
            baglanti.Close();
            this.Hide();  //Usercontrol aracımızı gizlemiş oluyoruz ancak hepsi gizlenmeyecektir.

            MessageBox.Show(lblid.Text + "Kişisine Ait Kayıt Başarılı Bir Şekilde Silindi.");
        }
    }
}
