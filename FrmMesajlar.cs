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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQL_2014;Initial Catalog=DilpekPansiyon;Integrated Security=True");

        private void verilerigöster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüsteriMesajlari", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MüsteriMesajlari (AdSoyad,Mesaj) values ('" + textBox1.Text + "','" + richTextBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMesajlar fa = new FrmMesajlar();
            fa.Close();
            FrmAnaForm fr = new FrmAnaForm();
            this.Hide();
        }
    }
}
