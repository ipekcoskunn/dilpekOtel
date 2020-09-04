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
    public partial class FrmFoto : Form
    {
        public FrmFoto()
        {
            InitializeComponent();
        }

        private void FrmFoto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Oda-1":
                    {
                        pictureBox1.Image = Properties.Resources.oda1;
                        break;
                    }
                case "Oda-2":
                    {
                        pictureBox1.Image = Properties.Resources.oda5;
                        break;
                    }
                case "Mutfak":
                    {
                        pictureBox1.Image = Properties.Resources.mutfak;
                        break;
                    }
                case "Restaurant":
                    {
                        pictureBox1.Image = Properties.Resources.restaurant;
                        break;
                    }
                case "Toplantı Odası":
                    {
                        pictureBox1.Image = Properties.Resources.toplantı_odası;
                        break;
                    }
                case "Spor Salonu":
                    {
                        pictureBox1.Image = Properties.Resources.Spa_Fitness_Center;
                        break;
                    }
                case "Pansiyon":
                    {
                        pictureBox1.Image = Properties.Resources.pansiyon;
                        break;
                    }
                case "Sahil":
                    {
                        pictureBox1.Image = Properties.Resources.sahil;
                        break;
                    }
                case "Manzara":
                    {
                        pictureBox1.Image = Properties.Resources.manzara;
                        break;
                    }
                case "Resepsiyon":
                    {
                        pictureBox1.Image = Properties.Resources.recepcion;
                        break;
                    }
                     
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFoto fa = new FrmFoto();
            fa.Close();
            FrmAnaForm fr = new FrmAnaForm();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
