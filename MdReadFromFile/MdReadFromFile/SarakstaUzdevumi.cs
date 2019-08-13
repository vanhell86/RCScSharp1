using System;
using System.Collections.Generic;
using System.Text;

namespace MdReadFromFile
{
    class SarakstaUzdevumi
    {

        private List<String> lietotaji = new List<String>();
        private List<int> lietotajuNumuri = new List<int>();
        
        private void IzvaditLietotajuSarakstu()
        {
            //String list
            //prasam, lai cilveks ievada lietotaja vardu ko pievienot sarakstam
            //izvelnei (while{switch,case)
            //1. pievienot jaunu lietotaju sarakstam
            //2. izvadit sarakstu
            //ja saraksts ir tukss, tad pie izvades tas ir japasaka
            if (lietotaji.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss");
            }
            else
            {
                for (int i = 0; i < lietotaji.Count; i++)
                {
                    Console.WriteLine(lietotajuNumuri[i] + "." + lietotaji[i]);
                }

                /*foreach(string lietotajs in lietotaji)
                {
                    Console.WriteLine(lietotajs);
                }*/
            }

        }

        private void PievienotSarakstam()
        {
            Console.WriteLine("Ievadet lietotajvardu!");
            lietotaji.Add(Console.ReadLine());


            if (lietotajuNumuri.Count == 0)
            {
                lietotajuNumuri.Add(1);
            }
            else
            {
                lietotajuNumuri.Add(lietotajuNumuri[lietotajuNumuri.Count - 1] + 1);
            }


        }

        private void Search()
        {
            //pieskirt otra saraksta katram lietotajam numuru

            //lietotajs ievada id un tad pec ta mes ari atrodam lietotajvardu
            //Izvadam lietotajvardu + id
            //ja nav nekas atrasts, tad pazinojumam
            // ievada id- ar for ciklu ejam cauri id sarakstam
            Console.WriteLine("Ievadiet ID");
            int id = Convert.ToInt16(Console.ReadLine());

            bool atrasts = false;
            for (int i = 0; i < lietotaji.Count; i++)
            {
                if (id == lietotajuNumuri[i])
                {
                    Console.WriteLine("ID " + lietotajuNumuri[i] + "ir lietotajvards " + lietotaji[i]);
                    atrasts = true;
                    break;
                }
            }

            if (atrasts != true)
            {
                Console.WriteLine("ID netika atrasts");
            }
            // no ta varam dabut i (indeksu). int atrastaisSkaitlis = i;

            // so indeksu varam izmantot, lai izvaditu Console.WriteLine(lietotaji[atraistaisSkaitlis])
        }

        private void Izdzest()
        {
            Console.WriteLine("Ievadiet ID");
            int id = Convert.ToInt16(Console.ReadLine());

            bool atrasts = false;
            for (int i = 0; i < lietotaji.Count; i++)
            {
                if (id == lietotajuNumuri[i])
                {
                    //Console.WriteLine("ID " + lietotajuNumuri[i] + "ir lietotajvards " + lietotaji[i]);
                    lietotaji.RemoveAt(i);
                    lietotajuNumuri.RemoveAt(i);
                    Console.WriteLine("Ieraksts dzests");
                    atrasts = true;
                    break;
                }
            }

            if (atrasts != true)
            {
                Console.WriteLine("ID netika atrasts");
            }
        }

        public void Interfeiss()
        {
            String choice = "";
            while (choice != "0")
            {
                Console.WriteLine("1, lai pievienotu, 2, lai izvaditu sarakstu,3, lai mekletu pec ID, 4, lai izdzestu, 0, lai izietu");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PievienotSarakstam();
                        break;
                    case "2":
                        IzvaditLietotajuSarakstu();
                        break;
                    case "3":
                        Search();
                        break;
                    case "4":
                        Izdzest();
                        break;
                    case "5":
                        Dzejolis fails = new Dzejolis();
                        //fails.RakstitSarakstu(lietotaji);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }

            }
        }

    }
}
