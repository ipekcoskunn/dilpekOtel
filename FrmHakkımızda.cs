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
    public partial class FrmHakkımızda : Form
    {
        public FrmHakkımızda()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmHakkımızda_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHakkımızda fa = new FrmHakkımızda();
            fa.Close();
            FrmAnaForm fr = new FrmAnaForm();
            this.Hide();
        }
    }
}
