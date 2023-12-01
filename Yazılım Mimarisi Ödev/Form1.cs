using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Mimarisi_Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factory f = new Factory();
            int[] KartNumarasi;
            KartNumarasi = new int[txtKartNo.Text.Length];

            for (int i = 0; i < txtKartNo.Text.Length; i++)
            {
                KartNumarasi[i] = Convert.ToInt32(txtKartNo.Text.Substring(i,1));
            }

            f.KartOlustur(KartNumarasi);
            
        }
    }
}
