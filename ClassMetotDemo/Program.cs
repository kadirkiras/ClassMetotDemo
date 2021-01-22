using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Sena";
            musteri1.Surname = "Lorem";
            musteri1.Age = 21;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Deniz";
            musteri2.Surname = "Çalışkan";
            musteri2.Age = 65;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Yuri";
            musteri3.Surname = "Yumak";
            musteri3.Age = 1;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};

            MusteriMenager musteriMenager = new MusteriMenager();
            
            musteriMenager.MusteriEkle(musteri1);
            musteriMenager.MusteriListele(musteriler);
            musteriMenager.MusteriSil(musteri3);

        }

         

    }
}
