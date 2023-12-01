using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi_Ödev
{
    public class AmericanExpress : IKart
    {
        public int[] KartNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public byte CVC { get; set; }

        public AmericanExpress()
        {
            KartNo = new int[14];
            System.Windows.Forms.MessageBox.Show("American Express Class'i oluşturuldu");
        }
    }
}
