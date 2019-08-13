using System;
using System.Collections.Generic;
using System.Text;

namespace MdReadFromFile
{
    class Dzejolis
    {
       

        public void LasitUnIzvadit()
        {
            
            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\maare\Downloads\dzejolis.txt");
            Console.WriteLine(lines.Length);

            foreach (string line in lines)
            {               
                Console.WriteLine(line);
            }
            Console.WriteLine("\n\n");

            //String[] reverseLines = new String[lines.Length];
            //for (int i = 0; i < lines.Length ; i++)
            //{
            //    reverseLines[i] = lines[lines.Length - 1 - i];
            //    Console.WriteLine(reverseLines[i]);
            //}
            Console.ReadLine();

            for ( int i = lines.Length - 1; i > -1; i--)
            {
                Console.WriteLine(lines[i]);
            } 
            Console.ReadLine();
        }

        public String[] LasitUnApgriezt()
        {
            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\maare\Downloads\dzejolis.txt");
            String temp;
            
            temp = lines[0];
            lines[0] = lines[3];
            lines[3] = temp;         
            return lines;
        }

        public void Rakstit(String[] lines)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\maare\Downloads\dzejolis_edited.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}
