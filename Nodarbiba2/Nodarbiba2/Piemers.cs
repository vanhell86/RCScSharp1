using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba2
{
    class Piemers
    {

        public void TestaIzvade()
        {
            Console.WriteLine("vii");
        }

        public static void TestaIzvade2()   // static metodeem nevajag veidot objektu, lai taam piekljuutu. Pieklust pa taisno caur klasi!
        {
            Console.WriteLine("vii");
        }

        public void cikli()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("vii");
            }

            String izvele = "";

            while (izvele != "iziet")
            {
                Console.WriteLine("Vai gribat iziet?");
                izvele = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("Vai gribat iziet?");
                izvele = Console.ReadLine();
            } while (izvele != "iziet");
        }

    }
}
