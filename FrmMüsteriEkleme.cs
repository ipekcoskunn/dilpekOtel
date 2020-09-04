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
    public partial class FrmMüsteriEkleme : Form
    {
        public FrmMüsteriEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQL_2014;Initial Catalog=DilpekPansiyon;Integrated Security=True");
        private void TxtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void FrmMüsteriEkleme_Load(object sender, EventArgs e)
        {
            if (FrmAnaForm.yuzbir == true)
            {
                BtnOda101.BackColor = Color.Red;
            }
            if (FrmAnaForm.yuziki == true)
            {
                BtnOda102.BackColor = Color.Red;
            }
            if (FrmAnaForm.yuzuc == true)
            {
                BtnOda103.BackColor = Color.Red;
            }
            if (FrmAnaForm.yuzdort == true)
            {
                BtnOda104.BackColor = Color.Red;
            }
            if (FrmAnaForm.yuzbes == true)
            {
                BtnOda105.BackColor = Color.Red;
            }
            if (FrmAnaForm.yuzalti == true)
            {
                BtnOda106.BackColor = Color.Red;
            }
            if (FrmAnaForm.yuzyedi == true)
            {
                BtnOda107.BackColor = Color.Red;
            }
            if (FrmAnaForm.yuzsekiz == true)
            {
                BtnOda108.BackColor = Color.Red;
            }
            if (FrmAnaForm.yuzdokuz == true)
            {
                BtnOda109.BackColor = Color.Red;
            }

        }

        private void TxtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            if (BtnOda101.BackColor == Color.Gold)
            {
                BtnOda101.BackColor = Color.Red;
            }
            else
            {
                BtnOda101.BackColor = Color.Gold;
                TxtOdaNo.Text = " ";
            }
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            if (BtnOda102.BackColor == Color.Gold)
            {
                BtnOda102.BackColor = Color.Red;
            }
            else
            {
                BtnOda102.BackColor = Color.Gold;
                TxtOdaNo.Text = " ";
            }
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            if (BtnOda103.BackColor == Color.Gold)
            {
                BtnOda103.BackColor = Color.Red;
            }
            else
            {
                BtnOda103.BackColor = Color.Gold;
                TxtOdaNo.Text = " ";
            }
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            if (BtnOda104.BackColor == Color.Gold)
            {
                BtnOda104.BackColor = Color.Red;
            }
            else
            {
                BtnOda104.BackColor = Color.Gold;
                TxtOdaNo.Text = " ";
            }
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            if (BtnOda105.BackColor == Color.Gold)
            {
                BtnOda105.BackColor = Color.Red;
            }
            else
            {
                BtnOda105.BackColor = Color.Gold;
                TxtOdaNo.Text = " ";
            }
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            if (BtnOda106.BackColor == Color.Gold)
            {
                BtnOda106.BackColor = Color.Red;
            }
            else
            {
                BtnOda106.BackColor = Color.Gold;
                TxtOdaNo.Text = " ";
            }
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            if (BtnOda107.BackColor == Color.Gold)
            {
                BtnOda107.BackColor = Color.Red;
            }
            else
            {
                BtnOda107.BackColor = Color.Gold;
                TxtOdaNo.Text = " ";
            }
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            if (BtnOda108.BackColor == Color.Gold)
            {
                BtnOda108.BackColor = Color.Red;
            }
            else
            {
                BtnOda108.BackColor = Color.Gold;
                TxtOdaNo.Text = " ";
            }
                
           
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            if (BtnOda109.BackColor == Color.Gold)
            {
                BtnOda109.BackColor = Color.Red;
            }
            else
            { BtnOda109.BackColor = Color.Gold;
            TxtOdaNo.Text = " ";
            }

        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir!");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sarı renkler butonlar boş odaları gösterir.");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime Ktarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime Btarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = Btarih - Ktarih;

            label12.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label12.Text)*250;
            TxtUcret.Text = Ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MüsteriTablosu (Adi, Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAd.Text + "','" + TxtSoyad.Text + "','" + comboBox1.Text + "','" + MskTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtKimlikNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız başarılı bir şekilde yapıldı.Dilpek ailesi iyi tatiller diler. ");
            if (BtnOda101.BackColor == Color.Red)
            {
                FrmAnaForm.yuzbir = true;
            }
            if (BtnOda102.BackColor == Color.Red)
            {
                FrmAnaForm.yuziki = true;
            }
            if (BtnOda103.BackColor == Color.Red)
            {
                FrmAnaForm.yuzuc = true;
            }
            if (BtnOda104.BackColor == Color.Red)
            {
                FrmAnaForm.yuzdort = true;
            }
            if (BtnOda105.BackColor == Color.Red)
            {
                FrmAnaForm.yuzbes = true;
            }
            if (BtnOda106.BackColor == Color.Red)
            {
                FrmAnaForm.yuzalti = true;
            }
            if (BtnOda107.BackColor == Color.Red)
            {
                FrmAnaForm.yuzyedi = true;
            }
            if (BtnOda108.BackColor == Color.Red)
            {
                FrmAnaForm.yuzsekiz = true;
            }
            if (BtnOda109.BackColor == Color.Red)
            {
                FrmAnaForm.yuzdokuz = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            FrmMüsteriEkleme fa= new FrmMüsteriEkleme();
            fa.Close();
            FrmAnaForm fr = new FrmAnaForm();
            this.Hide();
           
        }

        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
