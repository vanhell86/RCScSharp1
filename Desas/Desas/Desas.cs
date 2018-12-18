using System;
using System.Collections.Generic;
using System.Text;

namespace Desas
{
    class Desas
    {

        private String[,] divD;
        private int row;
        private int col;
        private String fill;


        public Desas(int row, int col, String fill)
        {
            this.row = row;
            this.col = col;
            this.fill = fill;
            divD = new String[row, col];
        }

        public String[,] CreateDivDMas()
        {
            for (int i = 0; i < divD.GetLength(0); i++)
            {
                for (int j = 0; j < divD.GetLength(1); j++)
                {
                    divD[i, j] = fill;
                }
            }
            return divD;
        }

        public void PrintBoard()
        {
            for (int i = 0; i < divD.GetLength(0); i++)
            {
                for (int j = 0; j < divD.GetLength(1); j++)
                {
                    Console.Write("   ");
                    Console.Write("{0} ", divD[i, j]);
                    Console.Write("  ");
                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("  ====================  ");
                }
            }
            Console.WriteLine();
        }

        public void CheckPlayer(bool player1, bool player2)
        {
            int row;
            int col;

        Start:
            Console.Clear();
            Console.WriteLine("--> Uzspelesim Desas <--");
            Console.WriteLine(" Speletajs Nr.1 -> 'X'   ||   Speletajs Nr.2 -> 'O' ");
            Console.WriteLine();
            PrintBoard();
            if (player1 == true)
            {
                Console.WriteLine("Gājiens Spēlētājam Nr.1");
                row = Program.GetNum("Ievadiet rindas numuru: ");
                col = Program.GetNum("Ievadiet kolonas numuru: ");
                if (divD[row, col] != fill)
                {
                    Console.WriteLine("Šī rūtiņa jau ir aizpildīta!");
                    Console.ReadLine();
                    goto Start;
                }
                divD[row, col] = "X";
            }
            else if (player2 == true)
            {
                Console.WriteLine("Gājiens Spēlētājam Nr.2");
                row = Program.GetNum("Ievadiet rindas numuru: ");
                col = Program.GetNum("Ievadiet kolonas numuru: ");
                if (divD[row, col] != fill)
                {
                    Console.WriteLine("Šī rūtiņa jau ir aizpildīta!");
                    Console.ReadLine();
                    goto Start;
                }
                divD[row, col] = "O";
            }
        }

        public bool CheckIfPlayer1Won()
        {
            //bool player1Won = false;
            //bool player2Won = false;
            //bool ifFilled = false;
            for (int i = 0; i < divD.GetLength(0); i++)
            {
                for(int j = i+1; j < divD.GetLength(1)-1; j++)
                {
                    if ((divD[i,j-1] == divD[i,j]) && divD[i,j] == "X")
                    {
                        //player1Won = true;
                        return true;
                    }
                    if ((divD[j-1, i+1] == divD[j,i]) && divD[j-1, i] == "X")
                    {
                        //player1Won = true;
                        return true;
                    }

                    //else if((divD[i, j] == divD[i, j + 1]) && divD[i, j] == "O")
                    //{
                    //    player2Won = true;
                    //    return player2Won;
                    //}
                }              
            }
            //for (int i = 1; i < divD.GetLength(1)-1; i++)
            //{
            //    for (int j = i-1; j < divD.GetLength(0); j++)
            //    {
            //        if ((divD[i, j] == divD[i + 1, j]) && divD[i, j] == "X")
            //        {
            //            return true;
            //        }
            //    }
            //}

                return false;
        }
        public bool CheckIfPlayer2Won()
        {
            //bool player2Won = false;
            //bool ifFilled = false;
            for (int i = 0; i < divD.GetLength(0); i++)
            {
                for (int j = i + 1; j < divD.GetLength(1) - 1; j++)
                {
                    if ((divD[i, j] == divD[i, j + 1]) && divD[i, j] == "O")
                    {
                        //player2Won = true;
                        return true;
                    }


                }
                //for (int j = i; j < divD.GetLength(0); j++)
                //{
                //    if ((divD[i, j] == divD[i + 1, j]) && divD[i, j] == "O")
                //    {
                //        return true;
                //    }
                //}

            }
            return false;
        }



        public String GetFill()
        {
            return this.fill;
        }
    }
}
