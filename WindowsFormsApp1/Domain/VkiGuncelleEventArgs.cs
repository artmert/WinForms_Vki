using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Domain

{
    public class VkiGuncelleEventArgs : EventArgs
    {

        public VkiGuncelleEventArgs(string ozellikAdi, float eskiDeger, float yeniDeger)

            {
            OzellikAdi = ozellikAdi;
            EskiDeger = eskiDeger;
            YeniDeger = yeniDeger;
            }

        public string OzellikAdi { get; }
        public float EskiDeger { get;  }
        public float YeniDeger { get;  }

    }
}


