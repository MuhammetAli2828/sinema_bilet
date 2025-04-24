using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class frmgelecekfilm : Form
    {
        public frmgelecekfilm()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");

        private void frmgelecekfilm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;  // Çerçeveyi kaldır
            this.WindowState = FormWindowState.Maximized;  // Tam ekran yap
            LoadGelecekFilmler();
        }

        private void LoadGelecekFilmler()
        {
            try
            {
                // Paneli temizle
                panel1.Controls.Clear();

                // Veritabanından filmleri çek
                baglanti.Open();
                string query = "SELECT FilmAdi, FilmAfis, IMDBPuanı, VizyonTarihi FROM GelecekFilmler";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                SqlDataReader reader = cmd.ExecuteReader();

                int xPosition = 10; // İlk film için başlangıç yatay konumu
                int yPosition = 10; // Yükseklik aynı kalacak

                while (reader.Read())
                {
                    // Veritabanı bilgilerini oku
                    string filmAdi = reader["FilmAdi"].ToString();
                    string afisYolu = reader["FilmAfis"].ToString();
                    decimal imdbPuani = Convert.ToDecimal(reader["IMDBPuanı"]);
                    string vizyonTarihi = Convert.ToDateTime(reader["VizyonTarihi"]).ToString("dd MMMM yyyy");

                    // Afiş resmi
                    PictureBox pbAfis = new PictureBox
                    {
                        Size = new Size(180, 200), // Resim boyutu
                        Location = new Point(xPosition, yPosition), // Panel içinde konum
                        ImageLocation = afisYolu, // Veritabanından afiş yolu
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Film adı etiketi
                    Label lblFilmAdi = new Label
                    {
                        Text = "Film: " + filmAdi,
                        Location = new Point(xPosition, yPosition + 210),
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        AutoSize = true
                    };

                    // IMDb puanı etiketi
                    Label lblIMDBPuani = new Label
                    {
                        Text = "IMDB: " + imdbPuani.ToString("0.0"),
                        Location = new Point(xPosition, yPosition + 230),
                        Font = new Font("Arial", 9),
                        AutoSize = true
                    };

                    // Vizyon tarihi etiketi
                    Label lblVizyonTarihi = new Label
                    {
                        Text = "Vizyon: " + vizyonTarihi,
                        Location = new Point(xPosition, yPosition + 250),
                        Font = new Font("Arial", 9),
                        AutoSize = true
                    };

                    // Ana panele ekle
                    panel1.Controls.Add(pbAfis);
                    panel1.Controls.Add(lblFilmAdi);
                    panel1.Controls.Add(lblIMDBPuani);
                    panel1.Controls.Add(lblVizyonTarihi);

                    // X pozisyonunu artır (yeni film yanda yer alsın)
                    xPosition += pbAfis.Width + 20; // Resim genişliği + boşluk
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
