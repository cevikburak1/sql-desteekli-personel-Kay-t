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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-61RI4169;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");


        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) From Tbl_Personel", baglantı);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString();

            }
            
            baglantı.Close();

            //Evli Personel Sayısı
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) From Tbl_Personel where PerMedeniDurum=1", baglantı);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvliPersonel.Text = dr2[0].ToString();
            }
            baglantı.Close();

            //Bekar Personel Sayısı
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) From Tbl_Personel where PerMedeniDurum=0", baglantı);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString();
            }
            baglantı.Close();

            //Şehir Sayısı
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerŞehir)) From Tbl_Personel", baglantı);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblŞehir.Text = dr4[0].ToString();
            }
            baglantı.Close();

            //Toplam Maaş
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select sum(PerMaaş) From Tbl_Personel", baglantı);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblMaaş.Text = dr5[0].ToString();
            }
            baglantı.Close();

            //Ortalama Maaş
            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select Avg(PerMaaş) From Tbl_Personel", baglantı);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblOrtalamaMaaş.Text = dr6[0].ToString();
            }
            baglantı.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
