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
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MuhammetAli;Initial Catalog=Sinema_Bilet;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {

        }



        private void btnekle_Click(object sender, EventArgs e)
        {
     
            
            if (txtsalonadi.Text != "" && cmbkoltuksayisi.Text != "")
            {
                     
              baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Tbl_Salonlar(SALONADI,KOLTUKSAYISI) Values (@p1,@p2)",baglanti);
                ekle.Parameters.AddWithValue("@p1",txtsalonadi.Text);
                ekle.Parameters.AddWithValue("@p2",cmbkoltuksayisi.Text);
                ekle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("işlem tamamlandi");
                temizle();
               
            }
            else {

                MessageBox.Show("lütfen boş alanları doldurunuz"); 
            }

            void temizle()
            {
                txtsalonadi.Text = "";
                cmbkoltuksayisi.Text = "";
                txtsalonadi.Focus();

            }
        }
    }
}
