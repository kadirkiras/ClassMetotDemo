using System;
namespace ClassMetotDemo
{
    public class MusteriMenager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + ".Müşteri \n" +"Müşteri Ad ve Soyad : " +musteri.Name + " " + musteri.Surname + "\nMüşterinin yaşı : " +musteri.Age +"\nDurum : Başarıyla Eklenmiştir.");
            Console.WriteLine("-------------------");
            
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + ". Müşteri \n" +"Müşteri Ad ve Soyad : " +musteri.Name + " " + musteri.Surname + "\nMüşterinin yaşı : " +musteri.Age);
                Console.WriteLine("-------------------");

            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + ".Müşteri \n" +"Müşteri Ad ve Soyad : " +musteri.Name + " " + musteri.Surname + "\nMüşterinin yaşı : " +musteri.Age +"\nDurum : Başarıyla Silinmiştir.");
            Console.WriteLine("-------------------");
        }
    }
}
