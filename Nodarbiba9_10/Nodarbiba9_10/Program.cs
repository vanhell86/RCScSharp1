using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Nodarbiba9_10
{

    class Program
    {
        static JokuFails jokuFails = new JokuFails();
        //static String[] fails = jokuFails.Lasit();
        static List<String> fails = jokuFails.Lasit();
        static void Main(string[] args)
        {

            Menu();

        }

       

        public static void Menu()
        {
            //String ievade = "";
            int choice = -1;
            //var choice1 = Console.ReadKey();
            while (choice != 0)
            {
           // Start:
                Console.WriteLine("1. Izvadīt visus jokus no faila");
                Console.WriteLine("2. Izvadīt konkrētu jokus no faila");
                Console.WriteLine("3. Pievienot joku no failam");
                Console.WriteLine("4. Random joks no faila");
                Console.WriteLine("5. Iztīrīt visus jokus no faila");
                Console.WriteLine("0. Iziet");

                Console.WriteLine("Ievadiet ko vēlaties darīt: ");

                //ievade = Console.ReadLine();    

                //try
                //{
                //    if (Regex.IsMatch(ievade, "[0-9]"))
                //    {
                //        choice = Convert.ToInt32(ievade);
                //    }
                //    if (choice < 0 || choice > 4)
                //    {
                //        Console.WriteLine("Tāda izvēlne neeksistē. Spiediet jebkuru taustiņu lai turpinātu");
                //        Console.ReadLine();
                //        goto Start;
                //    }
                //}
                //catch
                //{

                //}

                var choice1 = Console.ReadKey();
                switch (choice1.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            Console.Clear();
                            //fails = jokuFails.Lasit();
                            jokuFails.Izvadit(fails);
                            break;
                        }
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        {
                            Console.Clear();
                            //fails = jokuFails.Lasit();
                            int rindina = GetNr("Lūdzu izvēlēties kuru joku izvadīt no 1 - " + Convert.ToInt32(jokuFails.GetMasLength()));
                            jokuFails.izvaditIzveleto(fails, rindina);
                            break;
                        }
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        {
                            Console.Clear();
                            String joks = IevaidiJoku("Lūdzu ievadi Joku, ko vēlies pievienot.");
                            jokuFails.PievienotJoku(fails, joks);
                            break;
                        }
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        {
                            Console.Clear();
                            //fails = jokuFails.Lasit();
                            jokuFails.izvaditIzveleto(fails, RandomNumber());
                            break;
                        }
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        {
                            jokuFails.Tirit();
                            break;
                        }
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        {
                            Environment.Exit(0);
                            break;
                        }                   
                    default:
                        {
                            Console.WriteLine("\nNav tādas izvēlnes\n");
                            //Console.ReadLine();
                            break;
                            
                        }
                }
            }
        }

        public static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(1, jokuFails.GetMasLength());
        }

        static int GetNr(String teksts)
        {
        Start:
            int nr = -1;
            Console.WriteLine(teksts);
            String ievade = Console.ReadLine();
            if (Regex.IsMatch(ievade, "[0-9]"))
            {
                nr = Convert.ToInt32(ievade);
            }

            else
            {
                Console.WriteLine("Jūs neievadījāt skaitli!");
                goto Start;
            }
            return nr;
        }

        static String IevaidiJoku(String teksts)
        {
            Console.WriteLine(teksts);
            return Console.ReadLine();
        }

    }
}
