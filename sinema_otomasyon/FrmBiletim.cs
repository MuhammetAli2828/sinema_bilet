using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class frmBiletim : Form
    {
        private string kullaniciAd; // Kullanıcı adı bilgisi
        private DataGridView dataGridView1; // DataGridView kontrolü
        private ContextMenuStrip contextMenu; // Sağ tıklama menüsü

        public frmBiletim(string kullaniciAd)
        {
            InitializeComponent();
            this.kullaniciAd = kullaniciAd; // Kullanıcı adı parametre olarak alındı
        }

        private void CreateDataGridView()
        {
            // DataGridView'i oluştur
            dataGridView1 = new DataGridView
            {
                AutoGenerateColumns = true, // Sütunları otomatik oluştur
                SelectionMode = DataGridViewSelectionMode.FullRowSelect, // Tüm satırı seç
                AllowUserToAddRows = false, // Boş satır eklenmesini engelle
                ReadOnly = true, // Sadece okunabilir
                Dock = DockStyle.Fill, // Formun tamamını kapla
            };

            // DataGridView'e sağ tıklama menüsü ekleyelim
            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem cancelItem = new ToolStripMenuItem("İptal Et");
            cancelItem.Click += CancelItem_Click;
            contextMenu.Items.Add(cancelItem);

            // DataGridView'e sağ tıklama menüsünü atayın
            dataGridView1.ContextMenuStrip = contextMenu;

            // DataGridView'i forma ekle
            this.Controls.Add(dataGridView1);
        }

        private void LoadTickets()
        {
            string connectionString = "Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True";

            string query = @"
                SELECT 
                    AD AS [Ad], 
                    SOYAD AS [Soyad], 
                    FiLM AS [Film], 
                    SALONNO AS [Salon No], 
                    BİLETTÜRÜ AS [Bilet Türü], 
                    IMDBPUANI AS [IMDB Puanı], 
                    KOLTUKNO AS [Koltuk No]
                FROM 
                    Tbl_İZLEYİCİLER
                WHERE 
                    (@KullaniciAdi = 'admin' OR 
                    EXISTS (SELECT 1 FROM Tbl_Kullanicilar WHERE KullaniciAd = @KullaniciAdi AND Role = 'Admin') OR 
                    KullaniciAd = @KullaniciAdi)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Kullanıcı adını parametre olarak ekle
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAd);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // DataGridView'e verileri bağla
                        dataGridView1.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Biletler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmBiletim_Load_1(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'i dinamik olarak oluştur
                CreateDataGridView();

                // Veritabanından biletleri yükle
                LoadTickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelItem_Click(object sender, EventArgs e)
        {
            // Sağ tıklanan satırı kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // İptal edilecek biletin KoltukNo ve Film bilgilerini al
                string koltukNo = dataGridView1.SelectedRows[0].Cells["Koltuk No"]?.Value?.ToString();
                string film = dataGridView1.SelectedRows[0].Cells["Film"]?.Value?.ToString();

                if (string.IsNullOrEmpty(koltukNo) || string.IsNullOrEmpty(film))
                {
                    MessageBox.Show("Bilet bilgileri eksik.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Bu bileti iptal etmek istediğinizden emin misiniz?", "Bilet İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Bileti veritabanından sil
                    CancelTicket(koltukNo, film);
                }
            }
        }

        private void CancelTicket(string koltukNo, string film)
        {
            if (string.IsNullOrEmpty(koltukNo) || string.IsNullOrEmpty(film))
            {
                MessageBox.Show("Silinecek bilet bilgileri eksik.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True";

            string query = "DELETE FROM Tbl_İZLEYİCİLER WHERE KOLTUKNO = @KoltukNo AND FiLM = @Film"; // KoltukNo ve Film bilgilerine göre silme işlemi

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KoltukNo", koltukNo); // Silinecek biletin KoltukNo'su
                        command.Parameters.AddWithValue("@Film", film); // Silinecek biletin Film adı
                        command.ExecuteNonQuery(); // Silme işlemini uygula

                        MessageBox.Show("Bilet başarıyla iptal edildi.", "Bilet İptali", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Biletler tekrar yüklensin
                        LoadTickets();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilet iptal edilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
