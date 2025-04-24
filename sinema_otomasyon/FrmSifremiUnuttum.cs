using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");

        private TextBox txtEmail;

        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            Label lblEmail = new Label
            {
                Text = "E-posta Adresi:",
                Location = new Point(30, 50),
                Size = new Size(100, 20)
            };
            this.Controls.Add(lblEmail);

            txtEmail = new TextBox
            {
                Location = new Point(150, 50),
                Size = new Size(200, 20)
            };
            this.Controls.Add(txtEmail);

            Button btnReset = new Button
            {
                Text = "Şifreyi Sıfırla",
                Location = new Point(150, 100),
                Size = new Size(200, 30)
            };

            btnReset.Click += btnReset_Click;
            this.Controls.Add(btnReset);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("E-posta adresi boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Veritabanı bağlantısını açıyoruz
                baglanti.Open();

                // E-posta adresini kontrol eden SQL sorgusu
                string query = "SELECT * FROM Tbl_kullanicilar WHERE EPOSTA = @email";

                // Sorguyu çalıştırıyoruz
                using (SqlCommand sorgula = new SqlCommand(query, baglanti))
                {
                    sorgula.Parameters.AddWithValue("@email", email);

                    // SqlDataReader nesnesini kullanarak veriyi okuyoruz
                    using (SqlDataReader oku = sorgula.ExecuteReader())
                    {
                        if (oku.Read()) // E-posta adresi veritabanında varsa
                        {
                            string newPassword = GenerateRandomPassword();

                            // Yeni şifreyi veritabanına kaydediyoruz
                            string updateQuery = "UPDATE Tbl_kullanicilar SET KSİFRE = @newPassword WHERE EPOSTA = @email";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, baglanti))
                            {
                                updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                                updateCmd.Parameters.AddWithValue("@email", email);
                                updateCmd.ExecuteNonQuery(); // Şifreyi güncelliyoruz
                            }

                            MessageBox.Show("Yeni şifreniz: " + newPassword, "Şifre Sıfırlama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("E-posta adresi hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        // Rastgele 4 haneli şifre oluşturma metodu
        private string GenerateRandomPassword()
        {
            Random rand = new Random();
            string password = rand.Next(1000, 10000).ToString(); // 4 haneli şifre
            return password;
        }

        // FrmSifremiUnuttum formunda FormClosed olayını kullanarak FrmAcilis'i tekrar açıyoruz
        private void FrmSifremiUnuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            // FrmAcilis formunu tekrar oluştur
            FrmAcilis acilisForm = new FrmAcilis();
            acilisForm.Show();
        }
    }
}
