using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Dilpek_Otel
{
    public partial class Müsteriler : Form
    {
        public Müsteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQL_2014;Initial Catalog=DilpekPansiyon;Integrated Security=True");

        private void verilerigöster()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüsteriTablosu", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text=oku ["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add( oku["Cinsiyet"].ToString());
                ekle.SubItems.Add( oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add( oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

      
        private void Müsteriler_Load(object sender, EventArgs e)
        {

        }
        int Müsteriid = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Müsteriid = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MüsteriTablosu set Adi='" + TxtAd.Text + "',Soyadi='" + TxtSoyad.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + MskTxtTelefon.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtKimlikNo.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ucret='" + TxtUcret.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "'where Müsteriid=" + Müsteriid + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MüsteriTablosu where Müsteriid=(" + Müsteriid + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }


        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtSoyad.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Text = "";
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüsteriTablosu where Adi like '%"+textBox1.Text+"%' ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TxtOdaNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Müsteriler fa = new Müsteriler();
            fa.Close();
            FrmAnaForm fr = new FrmAnaForm();
            this.Hide();
        }
    }
}
