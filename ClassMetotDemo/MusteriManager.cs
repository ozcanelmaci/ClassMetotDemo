using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        ArrayList eklenenMusteriler = new ArrayList();
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " has been added as a costumer!!!");
            eklenenMusteriler.Add(musteri);
        }

        public void List()
        {
            if (eklenenMusteriler.Count > 0)
            {
                Console.WriteLine("Müşterilerinizin Listesi");
                Console.WriteLine("------------------------");
                foreach (Musteri musteri in eklenenMusteriler)
                {
                    Console.WriteLine(musteri.Name + " " + musteri.Surname);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Müşteri eklemediniz!!!" + "\n");
            }
           
        }

        public void Delete(Musteri musteri)
        {
            if (eklenenMusteriler.Contains(musteri))
            {
                eklenenMusteriler.Remove(musteri);
            }
        }

    }
}
