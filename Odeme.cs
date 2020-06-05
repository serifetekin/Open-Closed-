using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    interface IOdemeTipi
    {
        void OdemeYap();
    }

    class Havale : IOdemeTipi
    {
        public void OdemeYap()
        {
            Console.WriteLine("Havale yapıldı");
        }
    }
    class KrediKarti : IOdemeTipi
    {
        public void OdemeYap()
        {
            Console.WriteLine("KrediKarti yapıldı");
        }
    }
    class Paypall : IOdemeTipi
    {
        public void OdemeYap()
        {
            Console.WriteLine("Paypall yapıldı");
        }
    }

    class Odeme
    {
        public void Ode(IOdemeTipi tip)
        {
            tip.OdemeYap();
        }
    }
}
