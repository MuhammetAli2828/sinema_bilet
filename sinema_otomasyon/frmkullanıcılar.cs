using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class frmkullanıcılar : Form
    {
        // Veritabanı bağlantısı
        private readonly string connectionString = "Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True";

        // DataGridView ve ContextMenuStrip tanımları
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;

        public frmkullanıcılar()
        {
            InitializeComponent();
            DataGridViewOlustur(); // DataGridView oluştur
            ContextMenuOlustur();  // Sağ tık menüsü oluştur
        }

        private void frmkullanıcılar_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void DataGridViewOlustur()
        {
            dataGridView1 = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                BackgroundColor = Color.White
            };

            // DataGridView'i forma ekle
            this.Controls.Add(dataGridView1);
        }

        private void ContextMenuOlustur()
        {
            contextMenuStrip1 = new ContextMenuStrip();

            // Sağ tık menüsüne "Sil" seçeneği ekle
            var silMenuItem = new ToolStripMenuItem("Sil");
            silMenuItem.Click += SilMenuItem_Click;
            contextMenuStrip1.Items.Add(silMenuItem);

            // DataGridView'e sağ tık menüsünü bağla
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void VerileriGetir()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Tbl_kullanicilar";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırdaki KADI sütununu al
                string kadi = dataGridView1.SelectedRows[0].Cells["KADI"].Value.ToString();

                DialogResult result = MessageBox.Show($"'{kadi}' adlı kullanıcıyı silmek istediğinize emin misiniz?",
                                                      "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SilKayit(kadi);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SilKayit(string kadi)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Tbl_kullanicilar WHERE KADI = @KADI";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KADI", kadi);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"'{kadi}' adlı kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerileriGetir(); // Verileri güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
