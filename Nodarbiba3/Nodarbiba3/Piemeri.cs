using System;
using System.Collections.Generic;
using System.Text;

namespace Nodarbiba3
{
    class Piemeri
    {

        public void MasivaPirmaisPiemers()
        {


            int[] masivs = new int[3];
            masivs[0] = 1;
            masivs[1] = 4;
            masivs[2] = 5;

            int garums = masivs.Length;

            for (int i = 0; i < garums; i++)
            {
                masivs[i] = 99;
            }
        }

        public void Zvaigznites(int sk, String teksts)
        {
            String[] masivsZv = new string[sk];

            for (int i = 0; i < masivsZv.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    masivsZv[i] += teksts;
                }
                Console.WriteLine(masivsZv[i]);
            }

            for (int i = masivsZv.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(masivsZv[i]);
            }
        }

        public void SearchNumber(int[] mas, int meklejamais)
        {
            bool check = false;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == meklejamais)
                {
                    Console.WriteLine("Jūsu meklētais skaitlis atrodas masīva " + i + " ajā pozīcijā");
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Tāds skaitlis nav masīvā");
            }
        }

        public void DivDArryPrint (int [,] mas2D)
        {
            for(int i = 0; i < mas2D.GetLength(0); i++)
            {
                for(int j = 0; j < mas2D.GetLength(1); j++)
                {
                    String value = (i+1).ToString() + (j+1).ToString();                   
                    mas2D[i, j] =Convert.ToInt32(value);
                    Console.Write(mas2D[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }


    }
}
