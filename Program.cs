using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Hamza";
            int yasi = 24;
            //class değşkeni oluşturmak
            kurs  kurs1=new kurs();
            kurs1.kursadi = "C#";
            kurs1.kursegitmeni = "Engin Demiroğ";
            kurs1.izlenmeorani = 68;
            //class değişkeni oluşturmak
            kurs kurs2 = new kurs();
            kurs2.kursadi = "java";
            kurs2.kursegitmeni = "emre";
            kurs2.izlenmeorani = 68;
            //class değişkeni oluşturmak
            kurs kurs3 = new kurs();
            kurs3.kursadi = "python";
            kurs3.kursegitmeni = "Engin Demiroğ";
            kurs3.izlenmeorani = 68;
            //Console.WriteLine(kurs1.kursadi+":"+kurs1.kursegitmeni);
            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 };
            foreach (var xyz in kurslar)
            {
                Console.WriteLine(xyz.kursadi+":"+xyz.kursegitmeni);
            }
            Console.WriteLine("Hello World!");
        }
    }//class oluşturmak
    class kurs
    {
        public string kursadi { get; set; }
        public string kursegitmeni { get; set; }
        public int izlenmeorani { get; set; }

    }
}
