using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Tests
{
    public class MockData
    {
        public static void AddTestData()
        {
            HastaServis servis = new HastaServis();
            servis.Ekle("Kemal", "Alkan", 1.65f, 85);
            servis.Ekle("Mert", "Günal", 1.90f, 65);
            servis.Ekle("Tuna", "Avcı", 1.55f, 105);
            servis.Ekle("Aslı", "Kolsuz", 1.05f, 85);
            servis.Ekle("Feride", "Gül", 1.90f, 100);
        }
    }
}
