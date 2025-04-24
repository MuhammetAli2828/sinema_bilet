using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class frmFilmListele : Form
    {
        private string kullaniciRol;
        private TextBox txtSearch;
        private Button btnSearch;

        public frmFilmListele(string rol)
        {
            InitializeComponent();
            kullaniciRol = rol;

            // Arama TextBox ve Button eklemek
            txtSearch = new TextBox
            {
                Size = new Size(300, 40), // Arama çubuğunun boyutunu büyüttük
                Location = new Point(10, 50), // Arama çubuğunu biraz daha aşağı taşıdık (Y: 50)
                ForeColor = Color.Gray,
                Font = new Font("Arial", 12, FontStyle.Italic)
            };
            txtSearch.Text = "Film Ara..."; // Placeholder metni
            txtSearch.Enter += TxtSearch_Enter;
            txtSearch.Leave += TxtSearch_Leave;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            btnSearch = new Button
            {
                Size = new Size(40, 40), // Daha küçük boyut
                Location = new Point(txtSearch.Right + 10, txtSearch.Top), // Arama çubuğuyla aynı hizaya getirildi
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = Image.FromFile(@"C:\Users\mgode\OneDrive\Masaüstü\arama.jpg"), // Arama ikonunun tam yolu
                BackgroundImageLayout = ImageLayout.Stretch // İkonu buton boyutuna göre ayarla
            };
            btnSearch.FlatAppearance.BorderSize = 0; // Buton çerçevesini kaldır
            btnSearch.Click += BtnSearch_Click;

            this.Controls.Add(txtSearch);
            this.Controls.Add(btnSearch);
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");

        public void AddFilmsToPanel(string searchQuery = "")
        {
            try
            {
                PanelFilmler.Controls.Clear();
                baglanti.Open();

                string query = @"
                    SELECT FilmAdı, FilmOyuncular, FilmYonetmenler, imdb, FilmAfis 
                    FROM Tbl_Filmler 
                    WHERE 
                        FilmAdı LIKE @searchQuery OR 
                        FilmOyuncular LIKE @searchQuery OR 
                        FilmYonetmenler LIKE @searchQuery";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string filmAdı = reader["FilmAdı"].ToString();
                    string filmOyuncular = reader["FilmOyuncular"].ToString();
                    string filmYonetmenler = reader["FilmYonetmenler"].ToString();
                    decimal imdb = Convert.ToDecimal(reader["imdb"]);
                    string afis = reader["FilmAfis"].ToString();

                    Panel filmPanel = new Panel
                    {
                        Size = new Size(350, 200),
                        Margin = new Padding(10)
                    };

                    PictureBox pbAfis = new PictureBox
                    {
                        Size = new Size(100, 150),
                        ImageLocation = afis,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    Label lblFilmAdı = new Label
                    {
                        Text = "Film Adı: " + filmAdı,
                        Location = new Point(110, 10),
                        Size = new Size(200, 20)
                    };

                    Label lblOyuncular = new Label
                    {
                        Text = "Başrol Oyuncu: " + filmOyuncular,
                        Location = new Point(110, 40),
                        Size = new Size(200, 20)
                    };

                    Label lblYonetmenler = new Label
                    {
                        Text = "Yönetmenler: " + filmYonetmenler,
                        Location = new Point(110, 70),
                        Size = new Size(200, 20)
                    };

                    Label lblIMDB = new Label
                    {
                        Text = "IMDb: " + imdb.ToString("0.0"),
                        Location = new Point(110, 100),
                        Size = new Size(200, 20)
                    };

                    if (kullaniciRol == "Admin")
                    {
                        Button btnSil = new Button
                        {
                            Size = new Size(30, 30),
                            Location = new Point(35, 160),
                            FlatStyle = FlatStyle.Flat,
                            BackgroundImage = Image.FromFile(@"C:\Users\mgode\OneDrive\Masaüstü\silmeikon.png"),
                            BackgroundImageLayout = ImageLayout.Stretch
                        };

                        btnSil.FlatAppearance.BorderSize = 0;
                        btnSil.Click += (s, e) => DeleteFilm(filmAdı);
                        filmPanel.Controls.Add(btnSil);
                    }

                    filmPanel.Controls.Add(pbAfis);
                    filmPanel.Controls.Add(lblFilmAdı);
                    filmPanel.Controls.Add(lblOyuncular);
                    filmPanel.Controls.Add(lblYonetmenler);
                    filmPanel.Controls.Add(lblIMDB);

                    PanelFilmler.Controls.Add(filmPanel);
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            AddFilmsToPanel(txtSearch.Text);
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Film Ara...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Film Ara...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (searchText.Length >= 3)
            {
                AddFilmsToPanel(searchText);
            }
            else if (searchText.Length == 0)
            {
                AddFilmsToPanel();
            }
        }

        private void DeleteFilm(string filmAdı)
        {
            try
            {
                DialogResult result = MessageBox.Show($"'{filmAdı}' adlı filmi silmek istediğinizden emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    baglanti.Open();
                    string query = "DELETE FROM Tbl_Filmler WHERE FilmAdı = @filmAdı";
                    SqlCommand cmd = new SqlCommand(query, baglanti);
                    cmd.Parameters.AddWithValue("@filmAdı", filmAdı);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Film başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddFilmsToPanel();
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

        private void frmFilmListele_Load_1(object sender, EventArgs e)
        {
            AddFilmsToPanel();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
