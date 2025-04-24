using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace WindowsFormsApp7
{
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtkullanici.Text))
                {
                    MessageBox.Show("Kullanıcı adı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtkullanici.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtsifre.Text))
                {
                    MessageBox.Show("Şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsifre.Focus();
                    return;
                }

                using (baglanti) // Bağlantı açma
                {
                    baglanti.Open();
                    string query = "SELECT * FROM Tbl_kullanicilar WHERE KADI = @username AND KSİFRE = @password";

                    using (SqlCommand sorgula = new SqlCommand(query, baglanti)) // Komut nesnesi
                    {
                        sorgula.Parameters.AddWithValue("@username", txtkullanici.Text.Trim());
                        sorgula.Parameters.AddWithValue("@password", txtsifre.Text.Trim());

                        // SqlDataReader'ı using bloğuna aldık
                        using (SqlDataReader oku = sorgula.ExecuteReader()) // SqlDataReader nesnesi
                        {
                            if (oku.Read())
                            {
                                string role = oku["Role"].ToString();
                                string kullaniciAd = oku["KADI"].ToString();

                                if (role == "Admin")
                                {
                                    FrmAnaform adminForm = new FrmAnaform(role, kullaniciAd);
                                    adminForm.Show();
                                }
                                else if (role == "Kullanıcı")
                                {
                                    kullanicianaform frm = new kullanicianaform(kullaniciAd);
                                    frm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Bilinmeyen bir rol tespit edildi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı kaydı bulunamadı. Adı ya da şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                txtkullanici.Text = "";
                txtsifre.Text = "";
                txtkullanici.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_uyeol_Click(object sender, EventArgs e)
        {
            frmüyeol frm = new frmüyeol();
            frm.ShowDialog();
        }

        private void FrmAcilis_Load(object sender, EventArgs e)
        {
            // Şifremi Unuttum LinkLabel
            LinkLabel linkSifremiUnuttum = new LinkLabel
            {
                Text = "",
                Location = new Point(360, this.ClientSize.Height - 80), // Moves it slightly up
                Size = new Size(200, 50),
                LinkColor = Color.Gray, // Makes the link gray (grayed out)
                VisitedLinkColor = Color.Gray, // Makes visited links gray as well
                ActiveLinkColor = Color.Gray, // Active state will also be gray
                BackColor = Color.Transparent, // Removes any background color
                LinkBehavior = LinkBehavior.NeverUnderline, // Removes the underline on the link
                Font = new Font("Arial", 8.25f) // Reduces the font size (you can adjust the size)
            };
            linkSifremiUnuttum.LinkClicked += LinkSifremiUnuttum_LinkClicked;
            this.Controls.Add(linkSifremiUnuttum);

            // Enter tuşu ile giriş
            this.txtkullanici.KeyDown += OnKeyDown;
            this.txtsifre.KeyDown += OnKeyDown;

            // Buton ayarları
            SetButtonStyle(btngiris1, "login2.png", "Giriş Yap");
            SetButtonStyle(btn_uyeol, "üyeoll.jpg", "Üye Ol");
        }

        private void SetButtonStyle(Button button, string imagePath, string text = "")
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.BackColor = Color.Transparent;
            // button.Image = ResizeImage(Image.FromFile(Application.StartupPath + "\\Images\\" + imagePath), 38, 35);
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.Text = text;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Login();
            }
        }

        private void LinkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifremiUnuttum frmSifremiUnuttum = new FrmSifremiUnuttum();
            frmSifremiUnuttum.ShowDialog();
            this.Hide();
            baglanti.Close();
        }

        // Form kapanmadan önce bağlantıyı kapat
        private void FrmAcilis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                baglanti.Close(); // Bağlantıyı kapatıyoruz
            }
        }
    }
}
