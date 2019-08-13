using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MdReadFromFile
{
    class DzejolisList
    {
        private List<String> list = new List<String>();


        public void LasitUnIzvaditSarakstu()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\maare\Downloads\dzejolis.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line); // Add to list.
                    Console.WriteLine(line); // Write to console.
                }
                Console.WriteLine();

                for (int i = list.Count - 1; i > -1; i--)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }

        public List<String> LasitUnSamainit()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\maare\Downloads\dzejolis.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line); // Add to list.
                    Console.WriteLine(line); // Write to console.
                }
                list.Add(list[0]);
                list[0] = list[list.Count - 2];
                list.RemoveAt(list.Count - 2);
            }
            return list;
        }

            public void RakstitSarakstu(List<String> list)
            {
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"C:\Users\maare\Downloads\dzejolis_edited2.txt"))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        file.WriteLine(list[i]);
                    }

                }
            }        
    }

}
