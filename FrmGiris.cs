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


namespace Personel_Kayıt
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-61RI4169;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_YöneticiGiriş where KullanıcıAd=@p1 and Şifre=@p2", baglantı);
            komut.Parameters.AddWithValue("@p1", txtKullanıcıAdı.Text);
            komut.Parameters.AddWithValue("@p2", txtŞifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) 
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
            }
            baglantı.Close();
        }
    }
}
