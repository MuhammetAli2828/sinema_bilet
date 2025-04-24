using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;//sql i kullanmak için

namespace WindowsFormsApp7
{
    public partial class FrmYonetmenKayit1 : Form
    {
        public FrmYonetmenKayit1()
        {
            InitializeComponent();
        }
        //veritabanı yolu
        // SqlConnection baglanti = new SqlConnection("Data Source=Veritabanının_yolu;Initial Catalog=Veritabanının_adı;Integrated Security=True");  //bağlanmak için nesne oluşturduk
        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");

        private void btnyukleresim_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "resim seçme ekrani";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg; *.jpeg | All Files | *.*";
           // ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda yapicaz
                pbresim.Image=new Bitmap(ofd.FileName);//resim burda yüklenir
                  resimyolu = ofd.FileName.ToString();

            }

        }

        private void rbkadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }

        private void rberkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet="0";
        }
        public string cinsiyet = "1";


        public string byas = "0";
        public string resimyolu = "";
        private void btnkydtamamla_Click(object sender, EventArgs e)
        {
            
            // YasHesaplama();

            String Adi = txtad.Text.ToString().ToUpper();
            String Soyadi = txtsoyad.Text.ToString().ToUpper();
            string biyografi = txtbiyografi.Text.ToString();
            if (txtad.Text != "" && txtsoyad.Text != "" && txtbiyografi.Text != "" && resimyolu != "")
            {

                baglanti.Open();//sql i kullanmak için bir baglanti nesnesi oluşturduk

                SqlCommand kayit = new SqlCommand("insert into Tbl_Yonetmenler (Ad,Soyad,Cinsiyet,Yas,Biyografi,Resim) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                kayit.Parameters.AddWithValue("@p1", Adi);
                kayit.Parameters.AddWithValue("@p2", Soyadi);
                kayit.Parameters.AddWithValue("@p3", cinsiyet);
                kayit.Parameters.AddWithValue("@p4", byas);
                kayit.Parameters.AddWithValue("@p5", biyografi);
                kayit.Parameters.AddWithValue("@p6", resimyolu);
                kayit.ExecuteNonQuery();

                MessageBox.Show("KAYIT BAŞARILI");
                baglanti.Close();

            }
            else
            {
                MessageBox.Show("alanlar boş");

            }
            Araçtemizle();



            void Araçtemizle()
            {
                txtad.Text= string.Empty;
                txtsoyad.Text = string.Empty;
                txtbiyografi.Text = string.Empty;
                numgun.Value = 1;
                numay.Value = 1;
                numyil.Value = 2023;
                pbresim.Image = null; // Resmi kaldırır
                rberkek.Checked = true;
                rbkadin.Checked = true;
                lblkarakter.Text= "300";
                cinsiyet = "0";
                byas = "00";
                txtad.Focus();//tekrar imleci ad kısmından başlatıyor
            }
            
        }

        void YasHesaplama()
        {
            string dogum=numgun.Value.ToString()+"-"+numay.Value.ToString()+"-"+numyil.Value.ToString();
            DateTime dogumTarihi=Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Today;
            int yas=bugun.Year-dogumTarihi.Year;

            if (yas < 0)
            {
                MessageBox.Show("yaşınız 0 dan küçük olamaz");
            }
            else if (yas < 18)
            {
                MessageBox.Show("yasınız 18 den kucuktur");

            }
            else
            {
                MessageBox.Show(yas.ToString());
            }
            byas = yas.ToString();
        }

        private void txtbiyografi_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi=txtbiyografi.Text.Length;
            int gerikalan=300-karaktersayisi;
            lblkarakter.Text = gerikalan.ToString();
        }

        private void FrmYonetmenKayit1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
