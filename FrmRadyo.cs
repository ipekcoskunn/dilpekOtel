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
    public partial class FrmRadyo : Form
    {
        public FrmRadyo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.13.51:1240";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://canliradyodinle.gen.tr/powerturk.htm";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://provisioning.streamtheworld.com/pls/JOY_TURKAAC.pls";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRadyo fa = new FrmRadyo();
            fa.Close();
            FrmAnaForm fr = new FrmAnaForm();
            this.Hide();
        }

        private void FrmRadyo_Load(object sender, EventArgs e)
        {

        }

    }
}
