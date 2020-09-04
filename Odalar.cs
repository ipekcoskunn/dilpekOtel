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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQL_2014;Initial Catalog=DilpekPansiyon;Integrated Security=True");
        private void Odalar_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Odalar fa = new Odalar();
            fa.Close();
            FrmAnaForm fr = new FrmAnaForm();
            this.Hide();
        }

    }
}
