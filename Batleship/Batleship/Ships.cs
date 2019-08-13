using System;
using System.Collections.Generic;
using System.Text;

namespace Batleship
{
    class Ships
    {
        //private String[] Destroyer = new String[2] { "D", "D" };
        //private String[] Submarine = new String[3] { "Sub", "Sub", "Sub" };
        //private String[] Battleship = new String[4] { "B", "B", "B", "B" };


        public bool CheckBattleField(String[,] board, String[] ship, int x, int y, String direction)// Metode kas pārbauda vai kuģi var novietot
        {                                                                           //novietot laukumā pēc spēlētāja koord. un virziena

            x = x - 1;
            y = y - 1;
            bool test = false;
            if (direction == "8")
            {
                //test = CheckUp(board, ship, x, y);
                for (int i = 0; i < ship.Length; i++)
                {
                    //Console.WriteLine("i: " + i);
                    if (x - ship.Length < -1)       // Pārbauda vai kuģis nepārsniedz laukuma robežas
                    {
                        Console.WriteLine("Kuģi nevar novietot ārpus laukuma robežām");
                        Console.ReadLine();
                        test = false;
                        break;
                    }
                    else if ((x - ship.Length >= -1) && (y > 0) && (y < 9))     //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) 
                    {                                                           //un kuģis nav ne pirmajā ne pēdējā kolonā, tad pārbaudām visu apkārtejos
                                                                                // lauciņus izņemot uz augšu. Ja viss Ok, tad sakam ka var novietot kuģi.

                        if (x == 9)
                        {
                            if ((board[x - i, y] == " ") && (board[x - i - 1, y] == " ") && (board[x - i, y - 1] == " ") && (board[x - i, y + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            if (x - ship.Length < 0)
                            {
                                if ((board[x - i, y] == " ") && (board[x - i + 1, y] == " ") && (board[x - i, y - 1] == " ") && (board[x - i, y + 1] == " "))
                                {
                                    test = true;
                                }
                                else
                                {
                                    test = false;
                                    Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            else if ((board[x - i, y] == " ") && (board[x - i - 1, y] == " ") && (board[x - i + 1, y] == " ") && (board[x - i, y - 1] == " ") && (board[x - i, y + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else if ((x - ship.Length >= -1) && y == 0)              //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) 
                    {                                                       // un atrodas 1. kolonā, tad pārbaudām visu apkārtejos izņemot uz augšu
                                                                            // un pa kreisi    
                        if (x == 9)
                        {
                            if ((board[x - i, y] == " ") && (board[x - i, y + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            if ((board[x - i, y] == " ") && (board[x - i + 1, y] == " ") && (board[x - i, y + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else if ((x - ship.Length >= -1) && y == 9)         //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) 
                    {                                                   // un atrodas 10. kolonā, tad pārbaudām visu apkārtejos izņemot uz augšu
                                                                        //// un pa labi
                        if (x == 9)
                        {
                            if ((board[x - i, y] == " ") && (board[x - i, y - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            if ((board[x - i, y] == " ") && (board[x - i + 1, y] == " ") && (board[x - i, y - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else                                // Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) un neatrodas
                                                        // pie laukuma augšējām malām tad pārbauda visu apkārt vai ir brīvi lauciņi
                    {
                        if ((board[x - i, y] == " ") && (board[x - i - 1, y] == " ") && (board[x - i + 1, y] == " ") && (board[x - i, y - 1] == " ") && (board[x - i, y + 1] == " "))
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                            Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }



            else if (direction == "2")
            {
                for (int i = 0; i < ship.Length; i++)
                {
                    if (x + ship.Length > 10)       // Pārbauda vai kuģis nepārsniedz laukuma robežas
                    {
                        Console.WriteLine("Kuģi nevar novietot ārpus laukuma robežām");
                        Console.ReadLine();
                        test = false;
                        break;
                    }
                    else if ((x + ship.Length <= 10) && (y > 0) && (y < 9))     //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) 
                    {                                                           //un kuģis nav ne pirmajā ne pēdējā kolonā, tad pārbaudām visu apkārtejos
                                                                                // lauciņus izņemot uz leju. Ja viss Ok, tad sakam ka var novietot kuģi.

                        if (x == 0)
                        {
                            if ((board[x + i, y] == " ") && (board[x + i + 1, y] == " ") && (board[x + i, y - 1] == " ") && (board[x + i, y + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {

                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            if (x + ship.Length > 9)
                            {
                                if ((board[x + i, y] == " ") && (board[x + i - 1, y] == " ") && (board[x + i, y - 1] == " ") && (board[x + i, y + 1] == " "))
                                {
                                    test = true;
                                }
                                else
                                {
                                    test = false;
                                    Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            else if ((board[x + i, y] == " ") && (board[x + i + 1, y] == " ") && (board[x + i - 1, y] == " ") && (board[x + i, y - 1] == " ") && (board[x + i, y + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else if ((x + ship.Length <= 10) && y == 0)              //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) 
                    {                                                       // un atrodas 1. kolonā, tad pārbaudām visu apkārtejos izņemot uz leju
                                                                            // un pa kreisi   
                        if (x == 0)
                        {
                            if ((board[x + i, y] == " ") && (board[x + i, y + 1] == " ") && (board[x + (i + 1), y] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            if ((board[x + i, y] == " ") && (board[x + i - 1, y] == " ") && (board[x + i, y + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else if ((x + ship.Length <= 10) && y == 9)         //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) 
                    {                                                   // un atrodas 10. kolonā, tad pārbaudām visu apkārtejos izņemot uz leju
                                                                        //// un pa labi                                                                        

                        if (x == 0)
                        {
                            if ((board[x + i, y] == " ") && (board[x + i, y - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            if ((board[x + i, y] == " ") && (board[x + i - 1, y] == " ") && (board[x + i, y - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else
                    {
                        if ((board[x + i, y] == " ") && (board[x + i - 1, y] == " ") && (board[x + i + 1, y] == " ") && (board[x + i, y - 1] == " ") && (board[x + i, y + 1] == " "))
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                            Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }



            else if (direction == "4")
            {
                for (int i = 0; i < ship.Length; i++)
                {
                    if (y - ship.Length < -1)       // Pārbauda vai kuģis nepārsniedz laukuma robežas
                    {
                        Console.WriteLine("Kuģi nevar novietot ārpus laukuma robežām");
                        Console.ReadLine();
                        test = false;
                        break;
                    }

                    else if ((y - ship.Length >= -1) && (x > 0) && (x < 9))     //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām y coord.) 
                    {                                                           //un kuģis nav ne pirmajā ne pēdējā rindiņā, tad pārbaudām visu apkārtejos
                                                                                // lauciņus izņemot pa kreisi. Ja viss Ok, tad sakam ka var novietot kuģi.

                        if (y == 0)
                        {
                            if ((board[x, y - i] == " ") && (board[x + 1, y - i] == " ") && (board[x - 1, y - i] == " ") && (board[x, y - i + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {

                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                        else if (y == 9)
                        {

                            if ((board[x, y - i] == " ") && (board[x + 1, y - i] == " ") && (board[x - 1, y - i] == " ") && (board[x, y - i - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {

                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }

                        else
                        {
                            if (y - ship.Length < 0)
                            {
                                if ((board[x, y - i] == " ") && (board[x + 1, y - i] == " ") && (board[x - 1, y - i] == " ") && (board[x, y - i + 1] == " "))
                                {
                                    test = true;
                                }
                                else
                                {
                                    test = false;
                                    Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            else if ((board[x, y - i] == " ") && (board[x + 1, y - i] == " ") && (board[x - 1, y - i] == " ") && (board[x, y - i - 1] == " ") && (board[x, y - i + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {

                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else if ((y - ship.Length >= -1) && x == 0)              //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām y coord.) 
                    {                                                       // un atrodas 1. rindiņā, tad pārbaudām visu apkārtejos izņemot uz augšu
                                                                            // un pa kreisi    
                        if (y == 9)
                        {
                            if ((board[x, y - i] == " ") && (board[x + 1, y - i] == " "))
                            {
                                test = true;
                            }
                            else
                            {

                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            if ((board[x, y - i] == " ") && (board[x + 1, y - i] == " ") && (board[x, y - i + 1] == " ") && (board[x, y - i - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {

                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else if ((y - ship.Length >= -1) && x == 9)         //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām y coord.) 
                    {                                                   // un atrodas 10. rindiņā, tad pārbaudām visu apkārtejos izņemot uz leju
                                                                        //// un pa kreisi
                        if (y == 9)
                        {
                            if ((board[x, y - i] == " ") && (board[x - 1, y - i] == " ") && (board[x - 1, y - i - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {

                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            if ((board[x, y - i] == " ") && (board[x - 1, y - i] == " ") && (board[x, y - i + 1] == " ") && (board[x, y - i - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {

                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else
                    {
                        if ((board[x, y - i] == " ") && (board[x - 1, y - i] == " ") && (board[x + 1, y - i] == " ") && (board[x, y - i - 1] == " ") && (board[x, y - i + 1] == " "))
                        {
                            test = true;
                        }
                        else
                        {

                            Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                            test = false;
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }



            else if (direction == "6")
            {
                for (int i = 0; i < ship.Length; i++)
                {
                    if (y + ship.Length > 10)       // Pārbauda vai kuģis nepārsniedz laukuma robežas
                    {
                        Console.WriteLine("Kuģi nevar novietot ārpus laukuma robežām");
                        Console.ReadLine();
                        test = false;
                        break;
                    }
                    else if ((y + ship.Length <= 10) && (x > 0) && (x < 9))     //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām y coord.) 
                    {                                                           //un kuģis nav ne pirmajā ne pēdējā rindiņā, tad pārbaudām visu apkārtejos
                                                                                // lauciņus izņemot pa kreisi. Ja viss Ok, tad sakam ka var novietot kuģi.
                        if (y == 9)
                        {
                            if ((board[x, y + i] == " ") && (board[x + 1, y + i] == " ") && (board[x - 1, y + i] == " ") && (board[x, y + i - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {

                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                        else if (y == 0)
                        {
                            if ((board[x, y + i] == " ") && (board[x + 1, y + i] == " ") && (board[x - 1, y + i] == " ") && (board[x, y + i + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }

                        else
                        {
                            if (y + ship.Length > 9)
                            {
                                if ((board[x, y + i] == " ") && (board[x + 1, y + i] == " ") && (board[x - 1, y + i] == " ") && (board[x, y + i - 1] == " "))
                                {
                                    test = true;
                                }
                                else
                                {
                                    test = false;
                                    Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            else if ((board[x, y + i] == " ") && (board[x + 1, y + i] == " ") && (board[x - 1, y + i] == " ") && (board[x, y + i + 1] == " ") && (board[x, y + i - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else if ((y + ship.Length <= 10) && x == 0)              //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām y coord.) 
                    {                                                       // un atrodas 1. rindiņā, tad pārbaudām visu apkārtejos izņemot uz augšu
                                                                            // un pa kreisi    
                        if (y == 0)
                        {
                            if ((board[x, y + i] == " ") && (board[x + 1, y + i] == " ") && (board[x, y + i + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            if ((board[x, y + i] == " ") && (board[x + 1, y + i] == " ") && (board[x, y + i - 1] == " ") && (board[x, y + i + 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else if ((y + ship.Length <= 10) && x == 9)         //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām y coord.) 
                    {                                                   // un atrodas 10. rindiņā, tad pārbaudām visu apkārtejos izņemot uz leju
                                                                        //// un pa kreisi
                        if (y == 0)
                        {
                            if ((board[x, y + i] == " ") && (board[x - 1, y + i] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            if ((board[x, y + i] == " ") && (board[x - 1, y + i] == " ") && (board[x, y + i - 1] == " "))
                            {
                                test = true;
                            }
                            else
                            {
                                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                                test = false;
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    else
                    {
                        if ((board[x, y + i] == " ") && (board[x - 1, y + i] == " ") && (board[x + 1, y + i] == " ") && (board[x, y + i - 1] == " ") && (board[x, y + i + 1] == " "))
                        {
                            test = true;
                        }
                        else
                        {
                            Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
                            test = false;
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }
            return test;
        }


        public void AddShip(String[,] board, String[] ship, int x, int y, String direction) // Metode kas veic kuģa pievienošanu laukumam
        {
            x = x - 1;
            y = y - 1;
            if (direction == "8")
            {
                for (int i = 0; i < ship.Length; i++)
                {
                    board[x - i, y] = ship[i];
                }
            }
            if (direction == "2")
            {
                for (int i = 0; i < ship.Length; i++)
                {
                    board[x + i, y] = ship[i];
                }
            }
            if (direction == "4")
            {
                for (int i = 0; i < ship.Length; i++)
                {
                    board[x, y - i] = ship[i];
                }
            }
            if (direction == "6")
            {
                for (int i = 0; i < ship.Length; i++)
                {
                    board[x, y + i] = ship[i];
                }
            }

        }

        //public bool CheckUp(String[,] board, String[] ship, int x ,int y)
        //{
        //    x = x - 1;
        //    y = y - 1;

        //    for (int i = 0; i < ship.Length; i++)
        //    {
        //        if (x - ship.Length < -1)       // Pārbauda vai kuģis nepārsniedz laukuma robežas
        //        {
        //            Console.WriteLine("Kuģi nevar novietot ārpus laukuma robežām");
        //            return false;
        //            //test = false;
        //            //break;
        //        }
        //        else if ((x - ship.Length == -1) && (y > 0) && (y < 9))     //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) 
        //        {                                                           //un kuģis nav ne pirmajā ne pēdējā kolonā, tad pārbaudām visu apkārtejos
        //                                                                    // lauciņus izņemot uz augšu. Ja viss Ok, tad sakam ka var novietot kuģi.
        //            if ((board[x - i, y] == " ") && (board[x - i + 1, y] == " ") && (board[x - i, y - 1] == " ") && (board[x - i, y + 1] == " "))
        //            {
        //                return true;
        //                //test = true;
        //            }
        //            else
        //            {
        //                //test = false;
        //                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
        //                //break;
        //            }
        //            return false;
        //        }
        //        else if ((x - ship.Length == -1) && y == 0)              //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) 
        //        {                                                       // un atrodas 1. kolonā, tad pārbaudām visu apkārtejos izņemot uz augšu
        //                                                                // un pa kreisi    
        //            if ((board[x - i, y] == " ") && (board[x - i + 1, y] == " ") && (board[x - i, y + 1] == " "))
        //            {
        //                return true;
        //                //test = true;
        //            }
        //            else
        //            {
        //                //test = false;
        //                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
        //                //break;
        //            }
        //            return false;
        //        }
        //        else if ((x - ship.Length == -1) && y == 9)         //Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) 
        //        {                                                   // un atrodas 10. kolonā, tad pārbaudām visu apkārtejos izņemot uz augšu
        //                                                            //// un pa labi
        //            if ((board[x - i, y] == " ") && (board[x - i + 1, y] == " ") && (board[x - i, y - 1] == " "))
        //            {
        //                return true;
        //                //test = true;
        //            }
        //            else
        //            {
        //                //test = false;
        //                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
        //                //break;
        //            }
        //            return false;
        //        }
        //        else                                // Ja kuģis nēpārsniedz laukuma robežas (pēc ievadītajām x coord.) un neatrodas
        //                                            // pie laukuma augšējām malām tad pārbauda visu apkārt vai ir brīvi lauciņi
        //        {
        //            if ((board[x - i, y] == " ") && (board[x - i - 1, y] == " ") && (board[x - i + 1, y] == " ") && (board[x - i, y - 1] == " ") && (board[x - i, y + 1] == " "))
        //            {
        //                //test = true;
        //                return true;
        //            }
        //            else
        //            {
        //                //test = false;
        //                Console.WriteLine("Šajā pozīcijā kuģi nevar novietot");
        //                //break;
        //            }
        //            return false;
        //        }
        //    }
        //    return false;
        //}





        //public void AddSubmarine(String[,] board, int x, int y, String direction)
        //{
        //    if (direction == "8")
        //    {
        //        for (int i = 0; i < Submarine.Length; i++)
        //        {
        //            board[x - i, y] = Submarine[i];
        //        }
        //    }
        //    else if (direction == "2")
        //    {
        //        for (int i = 0; i < Submarine.Length; i++)
        //        {
        //            board[x + i, y] = Submarine[i];
        //        }
        //    }
        //    else if (direction == "4")
        //    {
        //        for (int i = 0; i < Submarine.Length; i++)
        //        {
        //            board[x, y - i] = Submarine[i];
        //        }
        //    }
        //    else if (direction == "6")
        //    {
        //        for (int i = 0; i < Submarine.Length; i++)
        //        {
        //            board[x, y + i] = Submarine[i];
        //        }
        //    }
        //}

        //public void AddBattleShip(String[,] board, int x, int y, String direction)
        //{
        //    if (direction == "8")
        //    {
        //        for (int i = 0; i < Battleship.Length; i++)
        //        {
        //            board[x - i, y] = Battleship[i];
        //        }
        //    }
        //    else if (direction == "2")
        //    {
        //        for (int i = 0; i < Battleship.Length; i++)
        //        {
        //            board[x + i, y] = Battleship[i];
        //        }
        //    }
        //    else if (direction == "4")
        //    {
        //        for (int i = 0; i < Battleship.Length; i++)
        //        {
        //            board[x, y - i] = Battleship[i];
        //        }
        //    }
        //    else if (direction == "6")
        //    {
        //        for (int i = 0; i < Battleship.Length; i++)
        //        {
        //            board[x, y + i] = Battleship[i];
        //        }
        //    }
        //}


    }
}
