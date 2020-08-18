using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Domain;

namespace WindowsFormsApp1.Data
{
    public static class HastaContext
    {
        static List<Hasta> hastalar;
        static HastaContext()
        {
            //singleton TASARIM DESENİ --> Bir objenin bellekte bir defa türetilip kullanılmasını sağlar.
            if (hastalar == null)
                hastalar = new List<Hasta>();
        }

        public static List<Hasta> TumHastalar()
        {
            return hastalar;
        }
        public static void Ekle(Hasta hasta)
        {
            hastalar.Add(hasta);
        }
    }
}
