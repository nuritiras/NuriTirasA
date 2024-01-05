using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuriTirasA
{
    public class Suleyman
    {
        public string isim;
        public string soyisim;
        public byte yas { get; set; }
        public double boy { get; set; }
        public double agirlik  { get; set; }

        public virtual double VcutKitleIndeksi()
        {
            return agirlik / (boy * boy);
        }
    }
    public class Nuri : Suleyman
    {
        public string OkuduguBolum;
        public bool Durum;
        public Nuri()
        {
            Console.WriteLine("Ben bir öğrenciyim şimdilik bu hesaba gerek yoktur.");
        }
        public override double VcutKitleIndeksi()
        {
            return 19.999;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Nuri nuri= new Nuri();
            nuri.isim = "Nuri";
            nuri.OkuduguBolum = "Bilişim Teknolojileri";
            nuri.Durum = true;
            nuri.yas = 46;
            nuri.boy = 1.76;
            nuri.agirlik = 68.99;
            Console.WriteLine("Vücut Kitle İndeks Değeri="+nuri.VcutKitleIndeksi());
        }
    }
}
