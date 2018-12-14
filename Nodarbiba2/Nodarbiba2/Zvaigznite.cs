using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba2
{
    class Zvaigznite
    {

        public void ZvaigznitesIzvade2(int robeza, String teksts)
        {
            for (int i = 0; i < robeza; i++)
            {
                Console.WriteLine(teksts);
                teksts += "*";
            }
        }




        public static void ZvaigznitesIzvade(int robeza, String teksts)
        {
            for (int i = 0; i < robeza; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(teksts);
                }
                Console.WriteLine();
            }
        }

    }


}
