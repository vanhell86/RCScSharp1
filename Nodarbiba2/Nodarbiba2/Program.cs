using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba2
{
    class Program
    {
        static void Main(string[] args)
        {

            Piemers piem = new Piemers();
            Zvaigznite zvaigznite = new Zvaigznite();
            Uzdevumi uzd = new Uzdevumi();
            //piem.TestaIzvade();

            //Piemers.TestaIzvade2();     // izsaucam TestaIzvade() neizveidojot objektu, jo taa ir static metode

            //piem.cikli();
            Zvaigznite.ZvaigznitesIzvade(4, "*");

            //zvaigznite.ZvaigznitesIzvade2(4, "*");
            
            int baze = GetSkaitli("Ievadiet baazes skaitli: ");            
            int pakape = GetSkaitli("Ievadiet pakapi: ");

            Console.WriteLine(uzd.Kapinasana(baze, pakape));


            Console.ReadLine();
        }

        public static int GetSkaitli(String teksts)
        {
            Console.WriteLine(teksts);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
