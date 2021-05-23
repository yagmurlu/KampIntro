using System;

namespace ClassIntro
{
    class Program
    {
       public static void Main(string[] args)
        {
            Kurslar();
            Urunler();
        }

        private static void Urunler()
        {
            Urun urun1 = new Urun();
            urun1.CıltBakımı = "Garnier Yüz Temizleme Jeli";
            urun1.Makyaj = "Göz Farı";
            urun1.SacBakımı = "Elidor Saç Kremi";

            Urun urun2 = new Urun();
            urun2.CıltBakımı = "Sinoz Nemlendirici";
            urun2.Makyaj = "Avon Mat Kırmızı Ruj";
            urun2.SacBakımı = "ClearMan";

            Urun[] uruns = new Urun[]
            {
                urun1,
                urun2
            };


            foreach (var x in uruns)
            {
                Console.WriteLine(x.CıltBakımı + " " + x.Makyaj + " " + x.SacBakımı);
            }
        }

        private static void Kurslar()
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "c#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 50;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Eğitmen = "Murat Yücedağ";
            kurs2.IzlenmeOranı = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Eğitmen = "Atıl Samancılar";
            kurs3.IzlenmeOranı = 45;

            Kurs[] kurslar = new Kurs[]
            {kurs1,kurs2,kurs3
            };
            Console.WriteLine("Kurs Adı" + "|| " + "Eğitmen" + "|| " + "Izlenme oranı");
            foreach (var k in kurslar)
            {

                Console.WriteLine(k.KursAdı + "|| " + k.Eğitmen + "|| " + k.IzlenmeOranı);
            }
        }
    }
    public class Kurs
    {
        public string KursAdı { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
    public class Urun
    {
        public string CıltBakımı { get; set; }
        public string Makyaj { get; set; }
        public string SacBakımı { get; set; }
    }
}
