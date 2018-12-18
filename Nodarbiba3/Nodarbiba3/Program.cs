using System;

namespace Nodarbiba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemeri piem = new Piemeri();
            Desas desas = new Desas();
            //Console.WriteLine("Lūdzu ievadiet cik garu masīvu vēlaties: ")
            //int sk = GetNum("Lūdzu ievadiet cik garu masīvu vēlaties: ");
            //int sk2 = GetNum("Lūdzu ievadiet kādu skaitli vēlaties sameklēt masīvā: ");

            int[] masivs = new int[] { 5, 6, 4, 7, 8, 5 };
            int[,] divDmasivs = new int[3,3];

            //piem.DivDArryPrint(divDmasivs);
            //piem.SearchNumber(masivs, sk2);
            //piem.Zvaigznites(sk, "*");

            desas.PrintDivDMas();

            Console.ReadLine();
        }

        private static int GetNum(String text)
        {
        Start:
            Console.WriteLine(text);
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Jūs neievadījāt skaitli!!!");
                goto Start;
            }
        }

    }
}
