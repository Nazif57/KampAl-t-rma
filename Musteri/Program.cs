using System;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.FirstName = "Nazif";
            musteri.LastName = "Balcı";
            musteri.Id = "1";

            Musteri musteri1 = new Musteri();
            musteri1.FirstName = "Ahmet";
            musteri1.LastName = "Uzun";
            musteri1.Id = "2";

            Musteri musteri2 = new Musteri();
            musteri2.FirstName = "Hilmi";
            musteri2.LastName = "Kara";
            musteri2.Id = "3";

            Musteri[] musteris = new Musteri[] { musteri, musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Listeleme(musteris);
            musteriManager.Silme(musteri);

            Console.ReadLine();
        }
    }
}
