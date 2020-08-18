namespace WindowsFormsApp1.Domain
{
    public class Hasta
    {
        //Aşağıdaki ID, Ad vs.'ye PROPERTY adı veriliyor. (Porperties)
        public string Id { get; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        //public float Boy { get; set; }

        private float boy;

        public float Boy
        {
            get { return boy; }
            set
            {
                var eski = boy;
                boy = value;
                VkiHesap();
                TeshisSonuc();
                VkiDegisti?.Invoke(this, new VkiGuncelleEventArgs("boy", eski, value));
            }
        }

        //public float Kilo { get; set; }
        private float kilo;

        public float Kilo
        {
            get { return kilo; }
            set
            {
                var eski = kilo;
                kilo = value;
                VkiHesap();
                TeshisSonuc();
                VkiDegisti?.Invoke(this, new VkiGuncelleEventArgs("kilo", eski, value));
            }
        }

        public event VkiGuncelleEventHandler VkiDegisti;

        public float Vki { get; set; }
        public string Teshis { get; set; }

        public Hasta(float _boy, float _kilo)
        {
            Boy = _boy;
            Kilo = _kilo;
            VkiHesap();
            TeshisSonuc();
            //unique identifier: dünyada bir eşi daha olmayan bir ID üretir
            //construct(yapıcı metod) ile System name space'nin içinde Guid adında bir yapı var ve Guid tipinden bir ID üretiyor. Ben ID'yi strin olarak kullandığım için bu Guid'i stringe çevirip kullanıyorum.
            Id = System.Guid.NewGuid().ToString();
        }


        private void VkiHesap()
        {
            Vki = Kilo / (Boy * Boy);

        }
        private void TeshisSonuc()
        {
            if (Vki <= 18.4f)
            {
                Teshis = "Zayıf";
            }
            else if (Vki < 24.9f && Vki >= 18.5f)
            {
                Teshis = "Normal";
            }
            else if (Vki < 29.9f && Vki >= 25f)
            {
                Teshis = "Hafif Kilolu";
            }
            else if (Vki >= 30f)
            {
                Teshis = "Obez";
            }
        }
    }
}
