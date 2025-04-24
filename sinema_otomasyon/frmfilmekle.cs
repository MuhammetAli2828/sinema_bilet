using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class frmfilmekle : Form
    {
        public frmfilmekle()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");

        // Oyuncu arama butonu
        private void btnoyuncuara_Click(object sender, EventArgs e)
        {
            listBoxOYUNCU.Items.Clear(); // Listeyi temizle

            // Oyuncu ID'sini alıyoruz
            int oyuncuID;
            if (!int.TryParse(txtoyuncuID.Text.Trim(), out oyuncuID))
            {
                MessageBox.Show("Lütfen geçerli bir oyuncu ID giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();

                // SQL sorgusu: ID'ye göre oyuncu arama
                string query = "SELECT AD FROM Tbl_Oyuncular WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@id", oyuncuID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBoxOYUNCU.Items.Add(reader["AD"].ToString());
                    }
                    listBoxOYUNCU.SelectedIndex = 0; // Otomatik olarak ilk oyuncuyu seç
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip oyuncu bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        // Yönetmen arama butonu
        private void button1_Click(object sender, EventArgs e)
        {
            listBoxYONETMEN.Items.Clear(); // Listeyi temizle

            // Yönetmen ID'sini alıyoruz
            int yonetmenID;
            if (!int.TryParse(txtyonetmenara.Text.Trim(), out yonetmenID))
            {
                MessageBox.Show("Lütfen geçerli bir yönetmen ID giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();

                // SQL sorgusu: ID'ye göre yönetmen arama
                string query = "SELECT AD FROM Tbl_Yonetmenler WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@id", yonetmenID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBoxYONETMEN.Items.Add(reader["AD"].ToString());
                    }
                    listBoxYONETMEN.SelectedIndex = 0; // Otomatik olarak ilk yönetmeni seç
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip yönetmen bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        // Film ekleme işlemini tamamlama butonu
        private void btnkydtamamla_Click(object sender, EventArgs e)
        {
           // Film ekleme işlemini tamamlama butonu

            try
            {
                // Oyuncu ve yönetmen seçimi kontrolü
                if (listBoxOYUNCU.Items.Count == 0 || listBoxOYUNCU.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir oyuncu seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (listBoxYONETMEN.Items.Count == 0 || listBoxYONETMEN.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir yönetmen seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // IMDb puanını doğrula
                decimal imdbPuan;
                if (!decimal.TryParse(cmbIMBD.SelectedItem?.ToString(), out imdbPuan) || imdbPuan < 0 || imdbPuan > 10)
                {
                    MessageBox.Show("IMDb Puanı geçersiz! Lütfen 0 ile 10 arasında bir değer giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Veritabanına bağlanma ve film verilerini ekleme
                baglanti.Open();

                // SQL sorgusu: Film verilerini ekleme
                string query = @"INSERT INTO Tbl_Filmler (FilmAdı, FilmOyuncular, FilmYonetmenler, FilmVizyon, imdb, FilmAfis)
                         VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";

                SqlCommand cmd = new SqlCommand(query, baglanti);

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@p1", txtfilmadi.Text.Trim()); // Film Adı
                cmd.Parameters.AddWithValue("@p2", listBoxOYUNCU.SelectedItem.ToString()); // Oyuncu
                cmd.Parameters.AddWithValue("@p3", listBoxYONETMEN.SelectedItem.ToString()); // Yönetmen
                cmd.Parameters.AddWithValue("@p4", dtvizyontarihi.Value.Date); // Film Vizyon Tarihi
                cmd.Parameters.AddWithValue("@p5", imdbPuan); // IMDb Puanı
                cmd.Parameters.AddWithValue("@p6", resimyolu); // Resim Yolu

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Film başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Film ekleme başarılı ise Film Listeleme formunu yeniden güncelle
                    frmFilmListele frmListele = (frmFilmListele)Application.OpenForms["frmFilmListele"];
                    if (frmListele != null)
                    {
                        frmListele.AddFilmsToPanel();  // Listeyi güncelle
                    }
                }
                else
                {
                    MessageBox.Show("Film kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }


        // Resim yükleme butonu
        public string resimyolu = "";
      
        private void listBoxOYUNCU_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bu alanda gerekli işlemleri yapabilirsiniz.
            var selectedOyuncu = listBoxOYUNCU.SelectedItem;
            if (selectedOyuncu != null)
            {
                // Seçilen oyuncuya dair işlemler yapılabilir
            }
        }

        private void frmfilmekle_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemleri buraya yazabilirsiniz.
            // Örneğin, comboBoxlara veya listBoxlara başlangıç verileri ekleyebilirsiniz.
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Etiket tıklandığında yapılacak işlemi buraya yazabilirsiniz.
        }

        private void btnyukleresim_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seçme Ekranı";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg; *.jpeg | All Files | *.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbresim.Image = new Bitmap(ofd.FileName); // Resmi yükler
                resimyolu = ofd.FileName; // Resim yolunu al
            }
        }

        private void frmfilmekle_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

