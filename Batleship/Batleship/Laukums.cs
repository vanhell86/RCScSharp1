using System;
using System.Collections.Generic;
using System.Text;

namespace Batleship
{
    class Laukums
    {

        public void CreateBoard(String[,] board)    // Metode kas aizpilda laukuma lauciņus ar tukšumiem
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = " ";      // aizpilda spēļu lauciņu ar tukšumiem
                }
            }
        }

        public void PrintBoard(String[,] board, String nos) // Metode kas izprintē 2D masīvu kā spēles laukumu
        {
            Console.WriteLine(" Spēlētēja  " + nos);
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        1      2      3      4      5      6      7      8      9     10");      // izvada kolonu numurus
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("{0}", " " + (Convert.ToInt32(i) + 1) + "  ");            // izvada rindiņu numurus
                Console.Write(" |");                                            // izvada linijas pirms masīva rindiņām
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write("  ");
                    Console.Write("{0} ", board[i, j] + "  |");     // izvada linijas starp masīva elem.(lauciņiem)
                }
                Console.WriteLine();
                if (i < board.GetLength(1))
                {                           // izvada līnijās starp masīva rindiņām
                    Console.Write("{0}", "     _______________________________________________________________________");
                }
                Console.WriteLine();
            }
        }



    }
}
