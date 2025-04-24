using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class frmOdemeKısmı : Form
    {
        private Timer paymentTimer;
        private int remainingTime = 60; // 1 dakika
        private Label lblTimer;

        // Ödeme bilgilerini tutmak için değişkenler
        private string salonAdi;
        private string filmAdi;
        private string ad;
        private string soyad;
        private string biletTuru;
        private double imdbPuani;
        private string koltukNo;
        private string kullaniciAd;

        // Ödeme tamamlandığında tetiklenecek olay
        public event Action PaymentCompleted;

        public static bool IsPaymentSuccessful { get; private set; } = false;

        public frmOdemeKısmı(string salonAdi, string filmAdi, string ad, string soyad, string biletTuru, double imdbPuani, string koltukNo, string kullaniciAd)
        {
            InitializeComponent();

            // Gelen bilgileri değişkenlere ata
            this.salonAdi = salonAdi;
            this.filmAdi = filmAdi;
            this.ad = ad;
            this.soyad = soyad;
            this.biletTuru = biletTuru;
            this.imdbPuani = imdbPuani;
            this.koltukNo = koltukNo;
            this.kullaniciAd = kullaniciAd; // Kullanıcı adı da parametre olarak alındı
        }

        private void PaymentTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;
            lblTimer.Text = $"Kalan Süre: {minutes:D2}:{seconds:D2}";

            if (remainingTime <= 0)
            {
                paymentTimer.Stop();
                MessageBox.Show("Süre doldu. Ödeme yapılmadığı için çıkış yapılıyor.", "Zaman Aşımı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Süre bittiğinde sayfa kapanır
            }
        }

        private void SaveToDatabase(string salonAdi, string filmAdi, string ad, string soyad, string biletTuru, double imdbPuani, string koltukNo)
        {
            string connectionString = "Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True";

            // Sadece bilet bilgilerini kaydet
            string query = "INSERT INTO Tbl_İZLEYİCİLER (AD, SOYAD, FiLM, SALONNO, BİLETTÜRÜ, IMDBPUANI, KOLTUKNO, KullaniciAd) " +
                           "VALUES (@Ad, @Soyad, @Film, @SalonNo, @BiletTuru, @IMDBPuani, @KoltukNo, @KullaniciAd)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.Parameters.AddWithValue("@Film", filmAdi);
                        command.Parameters.AddWithValue("@SalonNo", salonAdi);
                        command.Parameters.AddWithValue("@BiletTuru", biletTuru);
                        command.Parameters.AddWithValue("@IMDBPuani", imdbPuani);
                        command.Parameters.AddWithValue("@KoltukNo", koltukNo);
                        command.Parameters.AddWithValue("@KullaniciAd", kullaniciAd);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {
            try
            {
                // Kredi Kartı Numarası, Son Kullanım Tarihi ve CVV Kontrolü
                string cardNumber = txtkartnumarası.Text;
                string expiryDate = msdsonkullnma.Text;
                string cvv = txtCVV.Text;

                // Kart numarası 16 haneli ve sadece rakamlardan oluşmalı
                if (cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
                {
                    MessageBox.Show("Kredi kartı numarası geçerli değil. 16 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // CVV kontrolü (3 haneli)
                if (cvv.Length != 3 || !cvv.All(char.IsDigit))
                {
                    MessageBox.Show("CVV kodu geçerli değil. 3 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kart bilgileri doğrulandıktan sonra bilet bilgilerini veritabanına kaydet
                SaveToDatabase(salonAdi, filmAdi, ad, soyad, biletTuru, imdbPuani, koltukNo);
                IsPaymentSuccessful = true; // Ödeme başarılı olarak işaretlendi

                // Ödeme tamamlandı olayı tetikleniyor
                PaymentCompleted?.Invoke();

                // Kullanıcı adını tanımlayın veya değişken olarak gönderin
                string kullaniciAd = this.kullaniciAd;

                // FrmBiletim formunu açın ve kullanıcı adını iletin
                frmBiletim biletimForm = new frmBiletim(kullaniciAd);
                biletimForm.Show();
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Ödeme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void frmOdemeKısmı_Load_1(object sender, EventArgs e)
        {
            // Timer başlatma
            paymentTimer = new Timer();
            paymentTimer.Interval = 1000; // Her 1 saniyede bir tetiklenecek
            paymentTimer.Tick += PaymentTimer_Tick;
            paymentTimer.Start();

            lblTimer = new Label
            {
                Text = "Kalan Süre: 01:00",
                Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Red,
                Location = new System.Drawing.Point(10, this.ClientSize.Height - 50),
                AutoSize = true
            };

            this.Controls.Add(lblTimer);
            lblTimer.BringToFront();
        }

    }
}

