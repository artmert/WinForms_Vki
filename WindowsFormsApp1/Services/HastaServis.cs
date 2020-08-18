using System;
using System.Collections.Generic;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Domain;

namespace WindowsFormsApp1.Services
{
    public class HastaServis
    {
        public void Ekle(string ad, string soyad, float boy, float kilo)
        {
            Hasta h = new Hasta(boy, kilo)
            {
                Ad = ad,
                Soyad = soyad,
            };

            HastaContext.Ekle(h);
        }

        public List<Hasta> Filtrele(string filter, bool adaGore)
        {
            if (!String.IsNullOrEmpty(filter))
            {
                List<Hasta> filtrelenen = new List<Hasta>();

                if (adaGore)
                {
                    filtrelenen = HastaContext.TumHastalar().FindAll(h => h.Ad.StartsWith(filter, StringComparison.OrdinalIgnoreCase));

                }
                else
                {
                    filtrelenen = HastaContext.TumHastalar().FindAll(h => h.Soyad.StartsWith(filter, StringComparison.OrdinalIgnoreCase));
                }


                return filtrelenen;
            }
            return HastaContext.TumHastalar();
        }

        public Hasta IdDenHastaAl(string id)
        {
            return HastaContext.TumHastalar().Find(h => h.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

            public void HastaGuncelle(string id, string ad, string soyad, float boy, float kilo)
        { 


        var hasta = HastaContext.TumHastalar().Find(h => h.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
            hasta.VkiDegisti += Hasta_VkiDegisti;      
           hasta.Ad = ad;
           hasta.Soyad = soyad;
           hasta.Boy = boy;
           hasta.Kilo = kilo;

        }

        private void Hasta_VkiDegisti(Hasta h, VkiGuncelleEventArgs e)
        {
            
        }
    }

}
