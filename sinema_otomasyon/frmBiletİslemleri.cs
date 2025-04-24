using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class frmBiletİslemleri : Form
    {
        private SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");
        private bool isPaymentMade = false; // Ödeme yapılıp yapılmadığını kontrol etmek için
        private string kullaniciAdi;  // Kullanıcı adı değişkeni

        // frmBiletİslemleri constructor'ı, kullanıcı adını alacak şekilde güncelleniyor.
        public frmBiletİslemleri(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;  // Kullanıcı adını formda kullanabilmek için alıyoruz
        }

        private void frmBiletİslemleri_Load(object sender, EventArgs e)
        {

            // Formun arka planına resim ekle
            this.BackgroundImage = Image.FromFile("C:\\Users\\mgode\\Downloads\\arka-removebg-preview.png");  // Burada doğru dosya yolunu belirlemelisiniz
            this.BackgroundImageLayout = ImageLayout.Stretch;  // Resmin formu doldurmasını sağla

            button3.FlatStyle = FlatStyle.Flat; // Çerçeveyi kaldır
            button3.FlatAppearance.BorderSize = 0; // Çerçeve kalınlığını sıfırla
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent; // Tıklandığında arka plan
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent; // Üzerine gelindiğinde arka plan
            button3.BackColor = Color.Transparent; // Genel arka planı şeffaf yap

            // Butona resim ekleme (Boyutlandırılmış resim)
            button3.Image = ResizeImage(Image.FromFile("C:\\Users\\mgode\\Downloads\\kolttuk2-removebg-preview (1).png"), 50, 50); // Resim boyutlandırıldı
            button3.ImageAlign = ContentAlignment.MiddleLeft; // Resim sola hizalandı
            button3.Text = ""; // Butonun metni kaldırıldı
            button3.TextImageRelation = TextImageRelation.ImageBeforeText; // Resim, metinden önce görüntülenecek

        }
        private Image ResizeImage(Image imgToResize, int width, int height)
        {
            return new Bitmap(imgToResize, new Size(width, height));
        }


        // Sayfadan çıkarken uyarı vermek için
        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    if (!isPaymentMade)
        //    {
        //        var result = MessageBox.Show("Ödeme yapmadan çıkmak üzeresiniz. Verileriniz silinebilir. Çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        if (result == DialogResult.No)
        //        {
        //            e.Cancel = true; // Form kapanmasını engeller
        //        }
        //    }

        //    base.OnFormClosing(e);
        //}

        // Koltuk seçimini yapma
        private void button3_Click_1(object sender, EventArgs e)
        {
            frmKoltukSec frm = new frmKoltukSec();
            frm.ShowDialog();

            if (!string.IsNullOrEmpty(frm.SecilenKoltuk))
            {
                txtkoltukno.Text = frm.SecilenKoltuk; // Seçilen koltuğu TextBox'a yaz
            }
            else
            {
                MessageBox.Show("Herhangi bir koltuk seçilmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Film listelerini yükleme
        private void button4_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(baglanti.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT FilmAdı FROM Tbl_Filmler"; // Veritabanındaki doğru tablonun adını kontrol et
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Eğer veriler varsa, ListBox'a ekle
                        while (reader.Read())
                        {
                            string filmAdi = reader["FilmAdı"].ToString();
                            listBox2.Items.Add(filmAdi);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veritabanında hiç film bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı daha ayrıntılı bir şekilde yazdırılıyor
                MessageBox.Show("Veri çekilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Salon listelerini yükleme
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(baglanti.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT SALONADI FROM Tbl_Salonlar";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader["SALONADI"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Formu kapama
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ödeme butonuna tıklama
        private void button6_Click(object sender, EventArgs e)
        {
            // Formdaki gerekli alanları kontrol et
            if (string.IsNullOrEmpty(txtkoltukno.Text) || listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1 || string.IsNullOrEmpty(txtbiletadi.Text) || string.IsNullOrEmpty(txtbiletsoyadi.Text) || cmbbilettürü.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ListBox'tan yalnızca bir seçim yapıldığından emin ol
            if (listBox1.SelectedItems.Count != 1 || listBox2.SelectedItems.Count != 1)
            {
                MessageBox.Show("Lütfen her ListBox'tan sadece bir seçenek seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen salon, film ve diğer bilgileri al
            string SalonAdi = listBox1.SelectedItem.ToString();
            string FilmAdi = listBox2.SelectedItem.ToString();
            string koltukNo = txtkoltukno.Text;
            string ad = txtbiletadi.Text;  // Ad
            string soyad = txtbiletsoyadi.Text;  // Soyad
            string biletTuru = cmbbilettürü.SelectedItem?.ToString();

            // `kullaniciAdi`yi constructor'dan alıyoruz
            double imdbPuani = 7.5; // Örneğin sabit bir IMDb puanı, bunu veritabanından alabilirsiniz

            // Ödeme formunu oluştur
            frmOdemeKısmı frm = new frmOdemeKısmı(SalonAdi, FilmAdi, ad, soyad, biletTuru, imdbPuani, koltukNo, kullaniciAdi);

            // Ödeme formunu göster
            frm.ShowDialog();
        }
    }
}
