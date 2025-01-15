using System;

namespace SirketUygulamasi
{
    abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }
        public abstract void Gorev();
    }
    class YazilimGelistirici : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Yazılım geliştirici olarak çalışıyorum.");
        }
    }
    class ProjeYoneticisi : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
        }
    }
    class SatisTemsilcisi : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calisan yazilimci = new YazilimGelistirici
            {
                Ad = "Sertan",
                Soyad = "Bozkus",
                Departman = "Yazılım"
            };

            Calisan projeYoneticisi = new ProjeYoneticisi
            {
                Ad = "Gökay",
                Soyad = "Özlemiş",
                Departman = "Proje Yönetimi"
            };

            Calisan satisTemsilcisi = new SatisTemsilcisi
            {
                Ad = "Görkem",
                Soyad = "Vatansever",
                Departman = "Satış"
            };

            //görev metodu çağırma
            Console.WriteLine($"{yazilimci.Ad} {yazilimci.Soyad} şirketin {yazilimci.Departman} departmanında çalışıyor.");
            yazilimci.Gorev();

            Console.WriteLine($"{projeYoneticisi.Ad} {projeYoneticisi.Soyad} şirketin {projeYoneticisi.Departman} departmanında çalışıyor.");
            projeYoneticisi.Gorev();

            Console.WriteLine($"{satisTemsilcisi.Ad} {satisTemsilcisi.Soyad} şirketin {satisTemsilcisi.Departman} departmanında çalışıyor.");
            satisTemsilcisi.Gorev();
        }
    }
}
