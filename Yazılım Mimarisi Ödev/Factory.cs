using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi_Ödev
{
    public class Factory
    {
        public IKart KartOlustur(int[] KartNo)
        {
            

            switch (KartNo.Length)
            {
                case 16:
                    if (KartNo[0] == 5 && KartNo[1]<=5 && KartNo[1]!=0 )
                    {
                        return new Mastercard();
                    }
                    else if (KartNo[0] == 4)
                    {
                        return new Visa();
                    }
                    else
                    System.Windows.Forms.MessageBox.Show("Hatalı Kart Numarası");
                    return null;
                case 13:
                    if (KartNo[0] == 4)
                    {
                        return new Visa();
                    }
                    else
                    System.Windows.Forms.MessageBox.Show("Hatalı Kart Numarası");
                    return null;

                case 15:
                    if (KartNo[0] == 3 && (KartNo[1] == 4 || KartNo[1] == 7))
                    {
                        return new AmericanExpress();
                    }
                    else
                    System.Windows.Forms.MessageBox.Show("Hatalı Kart Numarası");
                    return null;

                default:
                    
                    System.Windows.Forms.MessageBox.Show("Hatalı Kart Numarası");
                    return null;


            }
        }
    }
}
