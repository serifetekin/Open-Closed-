using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Klasik
{
    class Odeme
    {
        enum ETip
        {
            Havale = 1,
            KrediKartı = 2,
            Paypall = 3
        }
        public void OdemeYap(ETip tip)
        {
            switch (tip)
            {
                case ETip.Havale:
                    Console.WriteLine("Havale ile ödeme yapıldı.");
                    break;
                case ETip.KrediKartı:
                    Console.WriteLine("Kredi Kartı ile ödeme yapıldı.");
                    break;
                case ETip.Paypall:
                    Console.WriteLine("Paypall ile ödeme yapıldı.");
                    break;
                default:
                    Console.WriteLine("Yok böyle bir ödeme.");
                    break;
            }
            

        }
    }
}
