using System;
using System.Collections.Generic;
using System.Text;

namespace Musteri
{
   
    class MusteriManager
    {
        private Musteri musteri = new Musteri(); 
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" {0} {1} {2} Eklendi :",musteri.FirstName, musteri.LastName,musteri.Id);
        }
        public void Listeleme(Musteri[] musteris)
        {
            foreach (var musteri in musteris )
            {
                Console.WriteLine(" {0} {1} {2} Listelendi", musteri.FirstName,musteri.LastName,musteri.Id);

            }
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(" {0} Silindi", musteri.FirstName);
        }
    }
}
