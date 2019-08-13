using System;

namespace MdReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Dzejolis dzejolis = new Dzejolis();
            DzejolisList dzejolisList = new DzejolisList();

            //dzejolis.LasitUnIzvadit();
            //dzejolis.Rakstit(dzejolis.LasitUnApgriezt());

            dzejolisList.LasitUnIzvaditSarakstu();
            Console.WriteLine();
            dzejolisList.RakstitSarakstu(dzejolisList.LasitUnSamainit());
            Console.ReadLine();
        }
    }
}
