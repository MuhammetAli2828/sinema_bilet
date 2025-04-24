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

namespace WindowsFormsApp7
{
    public partial class FrmOyuncuKayit : Form
    {
        public FrmOyuncuKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");
        private void FrmOyuncuKayit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string resimyolu = "";

        private void btnyukleresim_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "resim seçme ekrani";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg; *.jpeg | All Files | *.*";
            // ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemini bu alanda yapicaz
                pbresim.Image = new Bitmap(ofd.FileName);//resim burda yüklenir
                resimyolu = ofd.FileName.ToString();

            }
        }
        public string cinsiyet = "0";
        private void rbkadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void rberkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }



        private void btnkydtamamla_Click(object sender, EventArgs e)
        {

            yas_hesaplama();

            String Adi = txtad.Text.ToString().ToUpper();
            String Soyadi = txtsoyad.Text.ToString().ToUpper();
            string biyografi = txtbiyografi.Text.ToString();

            if (txtad.Text != "" && txtsoyad.Text != "" && txtbiyografi.Text != "" && resimyolu != "")
            {
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("insert into Tbl_Oyuncular (AD,SOYAD,YAS,BİYOGRAFİ,RESİM,CİNSİYET) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);  //insert into veri eklemek için kullanılır
                kayit.Parameters.AddWithValue("@p1", Adi);                                                                   // select tablodan veriçekmek için kullanılır
                kayit.Parameters.AddWithValue("@p2", Soyadi);
                kayit.Parameters.AddWithValue("@p6", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", byas);
                kayit.Parameters.AddWithValue("@p4", biyografi);
                kayit.Parameters.AddWithValue("@p5", resimyolu);
                kayit.ExecuteNonQuery();

                MessageBox.Show("KAYIT BAŞARILI");
                baglanti.Close();

                Araçtemizle();

            }
            else
            {
                MessageBox.Show("bütün alanları eksiksiz doldurun ");
            }


        }
      

        private void txtbiyografi_TextChanged(object sender, EventArgs e)
        {
            int karakter_sayisi = txtbiyografi.Text.Length;
            int geri=300-karakter_sayisi;
            lblkarakter.Text=geri.ToString();

        }
        public string byas = "00";
        void yas_hesaplama()
        {
            string dogum=numgun.Value.ToString()+"-"+numay.Value.ToString()+"-"+numyil.Value.ToString();
            DateTime dogumTarihi=Convert.ToDateTime(dogum); //string olan doğum değerini datetime a çevirir
            DateTime bugun=DateTime.Now;
            int yas=bugun.Year-dogumTarihi.Year;

            byas=yas.ToString();


        }

        void Araçtemizle()
        {
            txtad.Text = string.Empty;
            txtsoyad.Text = string.Empty;
            txtbiyografi.Text = string.Empty;
            numgun.Value = 1;
            numay.Value = 1;
            numyil.Value = 2023;
            pbresim.Image = null; // Resmi kaldırır
            rberkek.Checked = true;
            rbkadin.Checked = true;
            lblkarakter.Text = "300";
            cinsiyet = "0";
            byas = "00";
            txtad.Focus();//tekrar imleci ad kısmından başlatıyor
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbresim_Click(object sender, EventArgs e)
        {

        }
    }
}
