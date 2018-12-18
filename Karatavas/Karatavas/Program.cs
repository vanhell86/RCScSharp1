using System;
using System.Text.RegularExpressions;



namespace Karatavas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ievadiet vārdu, kuru būs jāatmin: ");
            String name = Console.ReadLine();
            char[] charMasivs = name.ToCharArray();
            Karatavas karatavas = new Karatavas();
            char[] hiddenMas = new char[charMasivs.Length];
            char burts;
            int count = 0;
           
            karatavas.WriteMas(charMasivs, hiddenMas);

            do
            {      
                Console.WriteLine("Atlikušās dzīvības: " + (5 - count));
                burts = GetChar("Ievadiet burtu. Jums būs 5 iespējas lai atminētu vārdu!");
                karatavas.CheckForChar(charMasivs, hiddenMas, burts);
                
                if (karatavas.CheckifFilled(hiddenMas))
                {
                    karatavas.PrintMas(hiddenMas);
                    Console.WriteLine("Super Jūs uzminējāt vārdu!!!");
                    break;
                }
                if (karatavas.CheckForChar(charMasivs, hiddenMas, burts) == false)
                {
                    Console.WriteLine(" Nav tāda burta vārdā ");
                    count++;
                }
                karatavas.PrintMas(hiddenMas);

            } while (count < 5);

            Console.ReadLine();
        }

        public static char GetChar(String teksts)
        {
        Start:
            Console.WriteLine(teksts);
            try
            {
                String burts = Console.ReadLine();
                if (Char.IsNumber(burts,0) == true || Char.IsWhiteSpace(burts,0) == true || String.IsNullOrEmpty(burts) == true)
                {
                    Console.WriteLine("Jūs ievadījāt skaitli vai tuksumu nevis burtu");
                    goto Start;
                }
                return Convert.ToChar(burts);
            }
            catch (FormatException)
            {
                Console.WriteLine("Jūs neievadījāt burtu vai ievadījāt vairākus simbolus!!!");
                goto Start;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Jūs neko neievadījāt");
                goto Start;
            }
        }
    }
}
