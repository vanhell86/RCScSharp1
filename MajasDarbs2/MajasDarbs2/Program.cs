using System;

namespace MajasDarbs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc;

            do
            {
                Console.Clear();
                double n1 = GetNum("Ievadiet pirmo skaitli: ");
                double n2 = GetNum("Ievadiet otro skaitli: ");
                String choice = GetChoice();

                calc = new Calc(n1, n2, choice);
                calc.WhatToDo();
                
            }
            while (!Exit());

        }

        private static double GetNum(String text)
        {
        Start:
            Console.WriteLine(text);
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Jūs neievadījāt skaitli!!!");
                goto Start;
            }            
        }

        private static String GetChoice()
        {
            Console.WriteLine("Ko vēlaties darīt? Ievadiet vai nu ciparu vai darbības zīmi.");
            Console.WriteLine("1. Saskaitīt '+' .");
            Console.WriteLine("2. Saskaitīt '-' .");
            Console.WriteLine("3. Reizināt '*' .");
            Console.WriteLine("4. Dalīt '/' .");
            Console.WriteLine("5. Kāpināt '^' .");
            return Console.ReadLine();
        }

        private static bool Exit()
        {
            Console.WriteLine("Ja nevēlaties turpināt nospiediet 'n', ja vēlaties turpināt nospiediet vnk Enter ");
            String yn = Console.ReadLine();
            if (yn == "n")
            {
                return true;
            }
            return false;
        }
    }
}
