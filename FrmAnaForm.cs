using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dilpek_Otel
{
    public partial class FrmAnaForm : Form
    {

        public static Boolean yuzbir =false;
        public static Boolean yuziki = false;
        public static Boolean yuzuc = false;
        public static Boolean yuzdort = false;
        public static Boolean yuzbes = false;
        public static Boolean yuzalti = false;
        public static Boolean yuzyedi = false;
        public static Boolean yuzsekiz = false;
        public static Boolean yuzdokuz = false;
        

        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMüsteriEkleme fr = new FrmMüsteriEkleme();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Müsteriler fr=new Müsteriler();
            fr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmRadyo fr = new FrmRadyo();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmFoto fr = new FrmFoto();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHakkımızda fr=new FrmHakkımızda();
            fr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
