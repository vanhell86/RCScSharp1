using System;
using System.Collections.Generic;
using System.Text;

namespace Desas2
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

        public String[,] CreateDivDMas()    // Izveidojam 2D masīvu ar default vērtībām
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

        public void PrintBoard()        // Izprintē Desu spēles laukumu
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

        public void CheckPlayer(bool player1, bool player2)     // Metode kas pārbauda kuram spēlētājam jāveic gājiens
        {
            int row;
            int col;
        Start:
            Console.Clear();
            Console.WriteLine("--> Uzspelesim Desas <--");
            Console.WriteLine(" Speletajs Nr.1 -> 'X'   ||   Speletajs Nr.2 -> 'O' ");
            Console.WriteLine();
            PrintBoard();
            
            if (player1 == true)        // Parbauda vai 1.spēlētāja gājiens
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
            else if (player2 == true)      // Pārbauda vai 2. spēlētāja gājiens
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

        public bool CheckIfPlayer1Won()         // Metode, kas pārbauda vai 1.spēlētājs nav uzvarējis
        {
            for (int i = 0; i < divD.GetLength(0); i++)
            {               
                    if ((divD[i, 0] == divD[i,1]) && (divD[i,1] == divD[i,2]) && (divD[i, i] == "X"))   // Salīdzina rindiņas
                    {
                        return true;
                    }
                    if ((divD[0, i] == divD[1, i]) && (divD[1, i] == divD[2, i]) && (divD[i, i] == "X"))    //Salīdzina kolonas
                    {
                        return true;
                    }
            }
            if((divD[0,0] == divD[1,1]) && (divD[1,1] == divD[2,2]) && (divD[0,0] == "X"))  //Salīdzina diagonāles
            {
                return true;
            }
            if ((divD[0, 2] == divD[1, 1]) && (divD[1, 1] == divD[2, 0]) && (divD[0, 2] == "X"))    //Salīdzina diagonāles
            {
                return true;
            }
            return false;
        }

        public bool CheckIfPlayer2Won()     // Metode, kas pārbauda vai 2.spēlētājs nav uzvarējis
        {
            for (int i = 0; i < divD.GetLength(0); i++)
            {

                if ((divD[i, 0] == divD[i, 1]) && (divD[i, 1] == divD[i, 2]) && (divD[i, i] == "O"))    // Salīdzina rindiņas
                {
                    return true;
                }
                if ((divD[0, i] == divD[1, i]) && (divD[1, i] == divD[2, i]) && (divD[i, i] == "O"))    //Salīdzina kolonas
                {
                    return true;
                }
            }
            if ((divD[0, 0] == divD[1, 1]) && (divD[1, 1] == divD[2, 2]) && (divD[0, 0] == "O"))    //Salīdzina diagonāles
            {
                return true;
            }
            if ((divD[0, 2] == divD[1, 1]) && (divD[1, 1] == divD[2, 0]) && (divD[0, 2] == "O"))    //Salīdzina diagonāles
            {
                return true;
            }
            return false;
        }

        //private bool CheckRow(int i, String XO)
        //{
        //    if ((divD[i, 0] == divD[i, 1]) && (divD[i, 1] == divD[i, 2]) && (divD[i, i] == "O"))    // Salīdzina rindiņas
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public String GetFill()
        {
            return this.fill;
        }


    }
}
