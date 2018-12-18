using System;
using System.Collections.Generic;
using System.Text;

namespace Karatavas
{
    class Karatavas
    {
        

        public void PrintMas(char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public void WriteMas(char[] mas, char[] mas2)
        {
            Console.Clear();
            for (int i = 0; i < mas.Length; i++)
            {
                mas2[i] = '_';
                Console.Write(mas2[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public bool CheckForChar(char[] mas, char[] mas2, char burts)
        {
            bool check = false;
                        
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == burts)
                {                   
                    //Console.WriteLine("Jūs atminējāt vienu burtu! " + mas[i] + " kurs atrodas " + Convert.ToInt16(i + 1) + " pozīcijā");
                    mas2[i] = burts;
                    check = true;
                }               
            }
            
            if (check == false)
            {
                Console.WriteLine("Tāds burts nav vārdā");
                Console.Clear();
                return check;
            }
            
            Console.Clear();
            return check;
        }

        public bool CheckifFilled(char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == '_' )
                {
                    return false;
                }                             
            }
            return true;
            
        }

    }
}
