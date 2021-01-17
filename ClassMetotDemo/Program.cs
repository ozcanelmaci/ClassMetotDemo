using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriIslemleri = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Name = "Özcan";
            musteri1.Surname = "Elmacı";
            musteri1.Id = "Id123";
            musteri1.Age = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "İsim2";
            musteri2.Surname = "Soyisim2";
            musteri2.Id = "Id345";
            musteri2.Age = 22;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "İsim3";
            musteri3.Surname = "Soyisim3";
            musteri3.Id = "Id678";
            musteri3.Age = 23;

            Musteri musteri4 = new Musteri();
            musteri4.Name = "İsim4";
            musteri4.Surname = "Soyisim4";
            musteri4.Id = "Id891";
            musteri4.Age = 24;

            Musteri musteri5 = new Musteri();
            musteri5.Name = "İsim5";
            musteri5.Surname = "Soyisim5";
            musteri5.Id = "Id011";
            musteri5.Age = 25;

            Musteri musteri6 = new Musteri();
            musteri6.Name = "İsim6";
            musteri6.Surname = "Soyisim6";
            musteri6.Id = "Id121";
            musteri6.Age = 26;

            //müşteri ekleme
            musteriIslemleri.Add(musteri1);
            musteriIslemleri.Add(musteri2);
            musteriIslemleri.Add(musteri3);
            musteriIslemleri.Add(musteri4);
            musteriIslemleri.Add(musteri5);
            musteriIslemleri.Add(musteri6);
            Console.WriteLine();

            //müşterileri listeleme
            musteriIslemleri.List();

            //bir müşteri sildikten sonra listeleme
            musteriIslemleri.Delete(musteri3);
            musteriIslemleri.List();

            Console.ReadLine();
        }
    }
}
