using System;

namespace Desas2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Desas desas = new Desas(3, 3, "-");
                String[,] divD = desas.CreateDivDMas();

                bool player1 = true;
                bool player2 = false;
                int count = 0;


                do
                {
                    count++;
                    desas.CheckPlayer(player1, player2);
                    player1 = !player1;
                    player2 = !player2;

                    if (desas.CheckIfPlayer1Won() == true)
                    {
                        Result(desas);
                        Console.WriteLine(" Uzvarējā spēlētājs Nr.1 ");
                        Console.ReadLine();
                        break;
                    }
                    else if (desas.CheckIfPlayer2Won() == true)
                    {
                        Result(desas);
                        Console.WriteLine(" Uzvarējā spēlētājs Nr.2 ");
                        Console.ReadLine();
                        break;
                    }
                    if (count == 9)
                    {
                        Result(desas);
                        Console.WriteLine("Ir neizšķirts");
                        Console.ReadLine();
                        break;
                    }

                } while (count < 9);

            } while (!Exit());

        }
        public static int GetNum(String text)
        {
        Start:
            Console.WriteLine(text);
            try
            {
                int pos = Convert.ToInt32(Console.ReadLine()) - 1;
                if (pos > 2 || pos < 0)
                {
                    Console.WriteLine("Jūs ievadījāt nepareizu pozīciju!");
                    goto Start;
                }
                return pos;
            }
            catch (FormatException)
            {
                Console.WriteLine("Jūs neievadījāt skaitli!!!");
                goto Start;
            }
        }

        private static bool Exit()
        {
            Console.WriteLine("Uzspēlēsim vēlreiz? Ja negribat spiediet 'n'.");
            String yn = Console.ReadLine();
            if (yn == "n")
            {
                return true;
            }
            return false;
        }

        public static void Result(Desas desas)
        {
            Console.Clear();
            Console.WriteLine("  -> Beigu Rezultāts <- ");
            Console.WriteLine("----------------------");
            desas.PrintBoard();
        }
    }
}
