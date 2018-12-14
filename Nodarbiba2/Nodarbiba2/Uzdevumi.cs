using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba2
{
    class Uzdevumi
    {

        public int Kapinasana(int baze, int pakape)
        {
            int rezultats = baze;
            for (int i = 1; i < pakape; i++)
            {
                rezultats = rezultats * baze;
            }
            return rezultats;
        }

    }
}
