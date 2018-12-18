using System;
using System.Collections.Generic;
using System.Text;

namespace Nodarbiba3
{
    class Desas
    {
        private String[,] divD = new String[3, 3];
    
        public void PrintDivDMas()
        {
            for (int i = 0; i < divD.GetLength(0); i++)
            {
                for (int j = 0; j < divD.GetLength(1); j++)
                {
                    Console.Write("{0} ", divD[i, j] = "-");
                }
                Console.WriteLine();
            }
        }

    }
}
