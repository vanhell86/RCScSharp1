using System;

namespace Desas
{
    class Program
    {
        static void Main(string[] args)
        {
            Desas desas = new Desas(3,3,"-");
            //String[,] divD = new String[3, 3] { { "-", "-", "-" }, { "-", "-", "-" }, { "-", "-", "-" } };
            String[,] divD = desas.CreateDivDMas();
            
            //int row;//= GetNum("Ievadiet rindas numuru: ");
            //int col;// = GetNum("Ievadiet kolonas numuru: ");
            bool player1 = true;
            bool player2 = false;
            
            
            do
            {
                //Start:
                //Console.Clear();
                //Console.WriteLine("--> Uzspelesim Desas <--");
                //Console.WriteLine(" Speletajs Nr.1 -> 'X'   ||   Speletajs Nr.2 -> 'O' ");
                //Console.WriteLine();
                //desas.PrintBoard();

                desas.CheckPlayer(player1,player2);
                player1 = !player1;
                player2 = !player2;

                if(desas.CheckIfPlayer1Won() == true)
                {
                    Console.Clear();
                    desas.PrintBoard();
                    Console.WriteLine(" Uzvarējā spēlētājs Nr.1 ");
                    
                    Console.ReadLine();
                    //break;
                }
                else if(desas.CheckIfPlayer2Won() == true)
                {
                    Console.WriteLine(" Uzvarējā spēlētājs Nr.2 ");
                    Console.ReadLine();
                    //break;
                }
                //desas.CheckIfWon();


                    //if (player1 == true)
                    //{
                    //    Console.WriteLine("Gājiens Spēlētājam Nr.1");
                    //    row = GetNum("Ievadiet rindas numuru: ");
                    //    col = GetNum("Ievadiet kolonas numuru: ");
                    //    if (divD[row, col] != desas.GetFill())
                    //    {
                    //        Console.WriteLine("Šī rūtiņa jau ir aizpildīta!");
                    //        Console.ReadLine();
                    //        goto Start;
                    //    }
                    //    divD[row, col] = "X";
                    //    player1 = false;
                    //    player2 = true;
                    //}
                    //else if (player2 == true)
                    //{
                    //    Console.WriteLine("Gājiens Spēlētājam Nr.2");
                    //    row = GetNum("Ievadiet rindas numuru: ");
                    //    col = GetNum("Ievadiet kolonas numuru: ");
                    //    if (divD[row, col] != desas.GetFill())
                    //    {
                    //        Console.WriteLine("Šī rūtiņa jau ir aizpildīta!");
                    //        Console.ReadLine();
                    //        goto Start;
                    //    }
                    //    divD[row, col] = "O";
                    //    player2 = false;
                    //    player1 = true;
                    //}

            } while (!Exit());


            /*desas.PrintDivDMas(divD);
            divD[1, 1] = "x";
            desas.PrintDivDMas(divD);
            divD[1, 2] = "x";
            desas.PrintDivDMas(divD);*/


            //Console.ReadLine();
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
            Console.WriteLine("Ja nevēlaties turpināt nospiediet 'n', ja vēlaties turpināt nospiediet vnk Enter ");
            String yn = Console.ReadLine();
            if (yn == "n")
            {
                return true;
            }
            return false;
        }

        //private static void CheckPlayer(String[,] divD, Desas desas, bool player1, bool player2)
        //{
        //    int row;
        //    int col;
            

        //    Start:
        //    Console.Clear();
        //    Console.WriteLine("--> Uzspelesim Desas <--");
        //    Console.WriteLine(" Speletajs Nr.1 -> 'X'   ||   Speletajs Nr.2 -> 'O' ");
        //    Console.WriteLine();
        //    desas.PrintBoard();
        //    if (player1 == true)
        //    {
        //        Console.WriteLine("Gājiens Spēlētājam Nr.1");
        //        row = GetNum("Ievadiet rindas numuru: ");
        //        col = GetNum("Ievadiet kolonas numuru: ");
        //        if (divD[row, col] != desas.GetFill())
        //        {
        //            Console.WriteLine("Šī rūtiņa jau ir aizpildīta!");
        //            Console.ReadLine();
        //            goto Start;
        //        }
        //        divD[row, col] = "X";
        //        //player1 = false;
        //        //player2 = true;
        //    }
        //    else if (player2 == true)
        //    {
        //        Console.WriteLine("Gājiens Spēlētājam Nr.2");
        //        row = GetNum("Ievadiet rindas numuru: ");
        //        col = GetNum("Ievadiet kolonas numuru: ");
        //        if (divD[row, col] != desas.GetFill())
        //        {
        //            Console.WriteLine("Šī rūtiņa jau ir aizpildīta!");
        //            Console.ReadLine();
        //            goto Start;
        //        }
        //        divD[row, col] = "O";
        //        //player2 = false;
        //        //player1 = true;
        //    }
        //}

    }
}
