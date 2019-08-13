using System;
using System.Collections.Generic;
using System.Text;

namespace Nodarbiba6
{
    class SarakstaPiemeri
    {
        public void SarakstaPiemers()
        {
            List<int> pirmaisSaraksts = new List<int>();

            pirmaisSaraksts.Add(1234);
            pirmaisSaraksts.Add(6);
            for(int i = 0; i < pirmaisSaraksts.Count; i++)
            {
                Console.WriteLine(pirmaisSaraksts[i]);
            }
        }
        

    }
}
