using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi_Ödev
{
    public interface IKart
    {

          int[] KartNo { get; set; }
          string Ad { get; set; }
          string Soyad { get; set; }
          DateTime SonKullanmaTarihi { get; set; }
          byte CVC { get; set; }

         

    }
}
