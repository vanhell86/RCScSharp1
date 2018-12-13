using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba1_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, double, String, bool...
            // Ctrl + C lai izietu no konsoles.


            //PirmaisUzdevums();
            //Console.WriteLine(Piemers());
            //int a = Piemers();
            //Console.WriteLine(Piemers2(3,a));

            //Piemers3();
            Console.WriteLine("Ievadiet pirmo skaitli: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet otro skaitli: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rezultats ir: " + AddOrSubstract(sk1, sk2));



            Console.ReadLine();
        }

        static void PirmaisUzdevums()
        {
            Console.WriteLine("Sveiki ievadiet savu vārdu: ");
            String name = Console.ReadLine();
            Console.WriteLine("Sveiki, " + name);

        }

        static int Piemers()
        {
            return 4 + 3;
        }

        static int Piemers2(int a, int b)
        {
            return a + b;
        }

        static void Piemers3()
        {
            Console.WriteLine("Ievadiet simbolus!");
            String ievade = Console.ReadLine();
            int a = 5;
            if (ievade == "vii" && a > 5)        // C# nevajag izmanto .equals, kā tas ir java
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }

            // <
            // >
            // <=
            // >=
            // ==
            // !=

            // &&
            // ||

        }

        static int AddOrSubstract(int a, int b)
        {
            String darbiba;
            Console.WriteLine("Ko vēlaties darīt, saskaitīt vai atņemt?: '+' vai '-' ");
            darbiba = Console.ReadLine();
            switch (darbiba)
            {
                case "+": return a + b;
                case "-": return a - b;
                default: Console.WriteLine("Jūs neievadījāt '+' vai '-' zīmes");
                break;
            }

            return 0;
        }
    }
}
