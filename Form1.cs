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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-61RI4169;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabanıDataSet1.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabanıDataSet1.Tbl_Personel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerŞehir,PerMaaş,PerMeslek,PerMedeniDurum) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglantı);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", MskMaas.Text);
            komut.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel Eklendi");
                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked== true)
            {
                label8.Text= "true";

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked ==true)
            {
                label8.Text = "false";

            }

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Txtid.Text = " ";
            TxtAd.Text = " ";
            TxtMeslek.Text = " ";
            TxtSoyad.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            CmbSehir.Text = " ";
            MskMaas.Text = " ";



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
             MskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
          label8.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
           

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;

            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Personel where Perid=@p1",baglantı);
            
            komutsil.Parameters.AddWithValue("@p1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Silindi");

           
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutgünncelle = new SqlCommand("Update Tbl_personel Set PerAd = @p1, PerSoyad = @p2, PerŞehir = @p3, PerMaaş = @p4, PerMeslek=@p5, PerMedeniDurum=@p6 where Perid=@p7", baglantı);
            komutgünncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutgünncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutgünncelle.Parameters.AddWithValue("@p3", CmbSehir.Text);
            komutgünncelle.Parameters.AddWithValue("@p4", MskMaas.Text);
            komutgünncelle.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komutgünncelle.Parameters.AddWithValue("@p6", label8.Text);
            komutgünncelle.Parameters.AddWithValue("@p7", Txtid.Text);
            komutgünncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel Kaydı Güncellenmiştir");
            
        }

        private void Btnistatislik_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();
        }
    }
}
