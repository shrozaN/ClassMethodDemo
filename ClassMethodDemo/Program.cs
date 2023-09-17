using ClassMethodDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.Ad = "ABC";
        musteri1.Soyad = "CBA";
        musteri1.Yas = 48;
        musteri1.Id = 1;

        Musteri musteri2 = new Musteri();
        musteri2.Ad = "XYZ";
        musteri2.Soyad = "ZYX";
        musteri2.Yas = 36;
        musteri2.Id = 2;

        Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

        Console.WriteLine("Listeleme İşlemi");

        foreach (Musteri musteri in musteriler)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + ": " + musteri.Yas + " Yaş" + " " + "Id: "  + musteri.Id);
        }

        Console.WriteLine("------------------------");
        
        Console.WriteLine("Ekleme İşlemi");
        MusteriManager musteriManager = new MusteriManager();
        musteriManager.MusteriEkle(musteri1);

        Console.WriteLine("------------------------");

        Console.WriteLine("Silme İşlemi");
        MusteriManager musteriManager1 = new MusteriManager();
        musteriManager1.MusteriSil(musteri2);

    }
}