using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Nodarbiba9_10
{
    class JokuFails
    {
        List<String> joki = new List<String>();

        public List<String> Lasit()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\maare\Downloads\Joki.txt"))
            {
                //List<String> joki = new List<String>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        joki.Add(line); // Add to list.
                    }                        
                }
            }
            //String[] lines = System.IO.File.ReadAllLines(@"C:\Users\maare\Downloads\Joki.txt");                        
            return joki;
        }

        public void Izvadit(List<String> lines)
        {
            
            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    Console.WriteLine(line);
                }                
            }
        }

        public void izvaditIzveleto(List<String> lines, int nr)
        {
            try
            {
                Console.WriteLine(lines[nr - 1]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Nav tik daudz joku failā");
            }           
        }

        public void PievienotJoku(List<String> joki, String joks)
        {
            RefreshJoki();
            if (joks != "")
            {
                joki.Add(joks);
            }
            else
            {
                Console.WriteLine("Nepareiza ievade");
                return;
            }
            //joki.Add(joks);
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\maare\Downloads\Joki.txt"))
                //new System.IO.StreamWriter(@"C:\Users\maare\Downloads\Joki.txt",true))    // Masīva gadījumā pievieno beigās
            {               
                    file.WriteLine(joks);   
            }
        }

        public void Tirit()
        {
            joki.Clear();
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\maare\Downloads\Joki.txt"))
            {
                file.Write("");
            }
        }

        private void RefreshJoki()
        {
            joki.Clear();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\maare\Downloads\Joki.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    joki.Add(lines[i]);
                }
                //joki.Add(lines[i]);
            }
        }

        public void RandomJoks()
        {
            Random rnd = new Random();
            int jokaNr = rnd.Next(joki.Count);
            Console.WriteLine(joki[jokaNr]);
        }

        public int GetMasLength()
        {
            RefreshJoki();
            //List<String> joki = System.IO.File.ReadAllLines(@"C:\Users\maare\Downloads\Joki.txt");
            return joki.Count;
        }
        
    }
}
