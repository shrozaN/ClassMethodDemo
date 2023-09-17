using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine("Başarıyla eklenen Müşteri = " + musteri.Ad + " " + musteri.Soyad + ": " + musteri.Yas + " Yaş" + " Id: " + musteri.Id);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Başarıyla silinen Müşteri = " + musteri.Ad + " " + musteri.Soyad + ": " + musteri.Yas + " Yaş" + " Id: " + musteri.Id);
        }
    }
}
