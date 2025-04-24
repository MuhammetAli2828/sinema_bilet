using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    public partial class frmKoltukSec : Form
    {
        public string SecilenKoltuk { get; private set; } // Seçilen koltuğu saklamak için
        private Button oncekiSeciliKoltuk; // Önceki seçilen koltuğu saklamak için
        private bool[] koltukDurumlari; // Koltukların durumlarını saklamak için
        private SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True"); // Veritabanı bağlantısı

        public frmKoltukSec()
        {
            InitializeComponent();
        }

        private void frmKoltukSec_Load(object sender, EventArgs e)
        { 

            int toplamKoltukSayisi = 70;   // Toplam koltuk sayısı
            int koltukSayisiBirSatirda = 10; // Her satırdaki koltuk sayısı
            int butonGenislik = 30;       // Buton genişliği
            int butonYukseklik = 30;      // Buton yüksekliği
            int aralik = 5;               // Butonlar arası boşluk

            int satirSayisi = (int)Math.Ceiling((double)toplamKoltukSayisi / koltukSayisiBirSatirda);

            this.Width = (koltukSayisiBirSatirda * (butonGenislik + aralik)) + 100;
            this.Height = ((satirSayisi * (butonYukseklik + aralik)) + 150);

            int xBaslangic = (this.ClientSize.Width - (koltukSayisiBirSatirda * (butonGenislik + aralik))) / 2;
            int yBaslangic = 20;

            int x = xBaslangic;
            int y = yBaslangic;

            // Koltukların durumlarını başlat
            koltukDurumlari = new bool[toplamKoltukSayisi]; // Başlangıçta tüm koltuklar boş (false)

            // Veritabanından rezerve edilen koltukları al
            LoadReservedSeats();

            for (int i = 1; i <= toplamKoltukSayisi; i++)
            {
                Button koltuk = new Button
                {
                    Width = butonGenislik,
                    Height = butonYukseklik,
                    Left = x,
                    Top = y,
                    Text = i.ToString(), // Koltuk numarası
                    BackColor = koltukDurumlari[i - 1] ? Color.Green : Color.Red, // Dolu ise yeşil, boş ise kırmızı
                    Enabled = !koltukDurumlari[i - 1] // Dolu koltuklar seçilemez
                };

                koltuk.Click += Koltuk_Click;

                this.Controls.Add(koltuk);

                x += butonGenislik + aralik;

                if (i % koltukSayisiBirSatirda == 0)
                {
                    x = xBaslangic;
                    y += butonYukseklik + aralik;
                }
            }

            // Alt kısma "Kırmızı: Boş, Yeşil: Dolu" açıklama butonları ekle
            Button aciklamaKirmizi = new Button
            {
                Width = 20,
                Height = 20,
                BackColor = Color.Red,
                Left = this.ClientSize.Width / 2 - 60,
                Top = this.ClientSize.Height - 60,
                Enabled = false
            };
            this.Controls.Add(aciklamaKirmizi);

            Label kirmiziAciklama = new Label
            {
                Text = "Boş",
                Left = aciklamaKirmizi.Right + 5,
                Top = aciklamaKirmizi.Top + 2,
                AutoSize = true
            };
            this.Controls.Add(kirmiziAciklama);

            Button aciklamaYesil = new Button
            {
                Width = 20,
                Height = 20,
                BackColor = Color.Green,
                Left = kirmiziAciklama.Right + 20,
                Top = aciklamaKirmizi.Top,
                Enabled = false
            };
            this.Controls.Add(aciklamaYesil);

            Label yesilAciklama = new Label
            {
                Text = "Dolu",
                Left = aciklamaYesil.Right + 5,
                Top = aciklamaYesil.Top + 2,
                AutoSize = true
            };
            this.Controls.Add(yesilAciklama);
        }

        // Veritabanından rezerve edilen koltukları al
        private void LoadReservedSeats()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(baglanti.ConnectionString))
                {
                    conn.Open();
                    // Veritabanındaki rezerve edilmiş koltukları almak için KOLTUKNO'yu sorguluyoruz
                    string query = "SELECT KOLTUKNO FROM Tbl_İZLEYİCİLER"; // Bu sorgu tüm rezerve edilmiş koltukları alacak
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Veritabanından rezerve edilmiş koltukları al
                    while (reader.Read())
                    {
                        int koltukNo = Convert.ToInt32(reader["KOLTUKNO"]);
                        if (koltukNo <= koltukDurumlari.Length)
                        {
                            koltukDurumlari[koltukNo - 1] = true; // Koltuk rezerve edilmişse true yap
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından rezerve koltukları yüklerken hata oluştu: " + ex.Message);
            }
        }

        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button tiklananKoltuk = sender as Button;

            if (tiklananKoltuk != null)
            {
                // Eğer koltuk zaten rezerve edilmişse, kullanıcıyı uyar
                if (tiklananKoltuk.BackColor == Color.Green)
                {
                    MessageBox.Show("Bu koltuk zaten rezerve edilmiştir.", "Koltuk Dolu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kullanıcıya seçim için onay sorusu
                DialogResult sonuc = MessageBox.Show(
                    $"Koltuk {tiklananKoltuk.Text} seçmek istediğinize emin misiniz?",
                    "Koltuk Seçimi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    // Eğer daha önce bir koltuk seçildiyse, önceki seçilen koltuğu kırmızı yap
                    if (oncekiSeciliKoltuk != null)
                    {
                        oncekiSeciliKoltuk.BackColor = Color.Red;
                    }

                    // Tıklanan koltuğu seçili hale getir
                    tiklananKoltuk.BackColor = Color.Green;
                    SecilenKoltuk = tiklananKoltuk.Text; // Seçilen koltuk numarasını sakla
                    oncekiSeciliKoltuk = tiklananKoltuk; // Bu koltuğu önceki seçili koltuk olarak belirle
                }
                else
                {
                    MessageBox.Show("Seçim işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
