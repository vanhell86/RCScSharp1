using System;

namespace Batleship
{
    class Program
    {
        static String[,] p1 = new String[10, 10];
        static String[,] p2 = new String[10, 10];
        static String[,] p1Hit = new String[10, 10];
        static String[,] p2Hit = new String[10, 10];
        static Laukums laukums = new Laukums();
        static Laukums laukumsHit = new Laukums();
        static Laukums laukumsHit2 = new Laukums();
        static Laukums laukums2 = new Laukums();
        static Ships ships = new Ships();
        static String[] destroyer = new String[2] { "D", "D" };
        static String[] submarine = new String[3] { "S", "S", "S" };
        static String[] battleship = new String[4] { "B", "B", "B", "B" };
        static PlayGame playGame = new PlayGame();

        static void Main(string[] args)
        {
            do
            {
                int dCount = 3;
                int sCount = 2;
                int bCount = 1;
                bool player1 = true;
                bool player2 = false;
                int hitCountP1 = 0;
                int hitCountP2 = 0;
                laukums.CreateBoard(p1);
                laukums2.CreateBoard(p2);
                laukumsHit.CreateBoard(p1Hit);
                laukumsHit2.CreateBoard(p2Hit);


                //do
                //{               
                //    CreateBattleField(p1, "p1", destroyer, "destroyer");
                //    dCount--;
                //} while (dCount != 0);
                //do
                //{
                //    CreateBattleField(p1, "p1", submarine, "submarine");
                //    sCount--;
                //} while (sCount != 0);
                //do
                //{
                //    CreateBattleField(p1, "p1", battleship, "battleship");
                //    bCount--;
                //} while (bCount != 0);


                //Console.WriteLine("Super jūs esat izvietojis savus karakuģus. Tagad kārta 2. Spēlētājam. Spiediet 'Enter'");
                //Console.ReadLine();
                //dCount = 3;
                //sCount = 2;
                //bCount = 1;
                //do
                //{
                //    Console.WriteLine("Izvietosim 3 Destroyer kuģus, kas ir 2 lauciņu garumā. ");
                //    CreateBattleField(p2, "p2", destroyer, "destroyer");
                //    dCount--;
                //} while (dCount != 0);
                //do
                //{
                //    Console.WriteLine("Izvietosim 2 Submarine kuģus, kas ir 3 lauciņu garumā. ");
                //    CreateBattleField(p2, "p2", submarine, "submarine");
                //    sCount--;
                //} while (sCount != 0);
                //do
                //{
                //    Console.WriteLine("Izvietosim 1 Battleship kuģi, kas ir 4 lauciņu garumā. ");
                //    CreateBattleField(p2, "p2", battleship, "battleship");
                //    bCount--;
                //} while (bCount != 0);
                //Console.WriteLine("Super jūs esat izvietojis savus karakuģus. Tagad varam uzspēlēt kuģīšus. Spiediet 'Enter'");
                //Console.ReadLine();

                ships.AddShip(p1, destroyer, 4, 5, "2");
                ships.AddShip(p1, destroyer, 1, 1, "2");
                ships.AddShip(p1, destroyer, 1, 10, "2");
                ships.AddShip(p1, submarine, 7, 5, "2");
                ships.AddShip(p1, submarine, 8, 7, "8");
                ships.AddShip(p1, battleship, 10, 10, "4");

                ships.AddShip(p2, destroyer, 4, 5, "2");
                ships.AddShip(p2, destroyer, 1, 1, "2");
                ships.AddShip(p2, destroyer, 1, 10, "2");
                ships.AddShip(p2, submarine, 7, 5, "2");
                ships.AddShip(p2, submarine, 8, 7, "8");
                ships.AddShip(p2, battleship, 10, 10, "4");
                ChooseBoard("p1");
                ChooseBoard("p2");
                Console.WriteLine("Super jūs esat izvietojis savus karakuģus. Tagad varam uzspēlēt kuģīšus. Spiediet 'Enter'");
                Console.ReadLine();

                do
                {
                    if (player1 == true)
                    {
                        hitCountP1 += playGame.GetHit();
                        GetShootCoord("player1");
                        //hitCountP1 += playGame.GetHit();    // skaita 1. spēlētaja trāpījumus
                        Console.WriteLine("hitCountp1: " + hitCountP1);
                        Console.ReadLine();
                        player1 = false;
                        player2 = true;                       
                    }
                    else if (player2 == true)
                    {
                        GetShootCoord("player2");
                        hitCountP2 += playGame.GetHit();    // skaita 2. spēlētāja trāpijumus
                        Console.WriteLine("hitCountp2: " + hitCountP2);
                        player1 = true;
                        player2 = false;
                    }



                } while (hitCountP1 != 16 || hitCountP2 != 16);


                if (hitCountP1 == 16)
                {
                    Console.WriteLine("Uzvarēja Spēlētājs Nr.1!!! ");
                }
                else if (hitCountP2 == 16)
                {
                    Console.WriteLine("Uzvarēja Spēlētājs Nr.2!!! ");
                }

            } while (!Exit());


        }

        public static void ChooseBoard(String nos)      // metode kas izvēlas kuru laukumu jāprintē
        {

            if (nos == "p1")
            {
                laukums.PrintBoard(p1, " 1. kuģu laukums");
            }
            else if (nos == "p2")
            {
                laukums2.PrintBoard(p2, " 2. kuģu laukums");
            }
            else if (nos == "p1Hit")
            {
                laukumsHit.PrintBoard(p1Hit, " 1. mērķu laukums");
            }
            else if (nos == "p2Hit")
            {
                laukumsHit2.PrintBoard(p2Hit, " 2. mērķu laukums");
            }
        }

        private static int GetNum(String text)      // Iegūstam no lietotāja ievades skaitļus no 1 - 10
        {
        Start:
            Console.WriteLine(text);
            try
            {
                int cord = Convert.ToInt32(Console.ReadLine());
                if (cord < 1 || cord > 10)
                {
                    Console.WriteLine("Jūs neievadījāt skaitli no 1 līdz 10!!!");
                    goto Start;
                }
                return cord;
            }
            catch (FormatException)
            {
                Console.WriteLine("Jūs neievadījāt skaitli!!!");
                goto Start;
            }
        }

        private static String GetDirection(String teksts)       // Metode ar kuru iegūstam virzienu, kurā būs jānovieto kuģis
        {
        Start:
            Console.WriteLine(teksts);
            try
            {
                String burts = Console.ReadLine();
                if (burts.Substring(0, 1) == "2" || burts.Substring(0, 1) == "4" || burts.Substring(0, 1) == "6" || burts.Substring(0, 1) == "8")
                {
                    return burts;
                }
                else
                {
                    Console.WriteLine("Jūs ievadījāt nepareizu vērtību");
                    goto Start;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Jūs neko neievadījāt");
                goto Start;
            }
        }

        public static void CreateBattleField(String[,] playerBoard, String player, String[] ship, String shipName) // Metode ar kuras palīdzību
        {                                                                                          // izvietojam kuģus mūsu spēlētāju laukumos
        Start:
            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (" Sveicināti spēlē Batleship ".Length / 2)) + "}", " Sveicināti spēlē Battleship "));
            Console.WriteLine();
            ChooseBoard(player);
            Console.WriteLine("Izvietosim kuģus spēļu laukumā!");
            Console.WriteLine("Tagad izvietosim " + shipName + " tipa kuģus, kas ir " + ship.Length + " lauciņus gari");
            int x = GetNum("Ievadiet kuģa sākuma rindiņu numuru ( Ievadiet skaitli no 1 - 10 ):");
            int y = GetNum("Ievadiet kuģa sākuma kolonu numuru ( Ievadiet skaitli no 1 - 10 ):");
            String direction = GetDirection(" Ievadiet virzienu, kurā vēlaties novietot kuģi: 1. Uz leju '2'; 2. Uz augšu '8'; 3. Pa kreisi '4'; 4. Pa labi '6' ");

            if (ships.CheckBattleField(playerBoard, ship, x, y, direction) != true) // Pārbaudam vai kuģi var novietot spēlētāja vēlamajā pozīcijā
            {
                goto Start;                                                         // Ja nevar, ejam uz sākumu
            }
            ships.AddShip(playerBoard, ship, x, y, direction);                      // Pievienojam kuģi spēlētāja norādītajās koord. un virzienā
            ChooseBoard(player);                                                    // Pa jaunam izprintējam laukumu
        }

        public static void GetShootCoord(String player)     // Metode ar kuru veicam šaušanu pa pretinieka laukumu
        {
        Start:
            Console.Clear();
            String gameName = "BattleShip";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (gameName.Length / 2)) + "}", gameName));// Novietojam tekstu centrā
            Console.WriteLine();
            String caption = "Game On\n";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (caption.Length / 2)) + "}", caption));

            if (player == "player1")        // pārbaudam vai 1. spēlētāja gājiens
            {
                ChooseBoard("p1");
                Console.WriteLine("\n");
                ChooseBoard("p1Hit");
                Console.WriteLine("Spelētājs Nr.1 ievadi mērķa koordinātas: ");
            }
            else
            {
                ChooseBoard("p2");
                Console.WriteLine("\n");
                ChooseBoard("p2Hit");
                Console.WriteLine("Spelētājs Nr.2 ievadi mērķa koordinātas: ");
            }

            int x = GetNum("Ievadiet rindiņas numuru kur vēlaties šaut ( Ievadiet skaitli no 1 - 10 ):");
            int y = GetNum("Ievadiet kolonas numuru kur vēlaties šaut ( Ievadiet skaitli no 1 - 10 ):");

            if (player == "player1")
            {
                playGame.Hit(p2, p1Hit, player, x, y);// Metode kas veic šāvienu pa pretinieka laukumu
                if (playGame.IfHitted())    // Pārbauda vai jau nav šauts pa doto lauciņu
                {
                    Console.WriteLine("Jūs jau šāvāt pa šīm koordinātām un trāpījāt kuģim vai nogremdējāt to");
                    Console.WriteLine("Spied jebkuru taustiņu, lai turpinātu.");
                    Console.ReadLine();
                    goto Start;
                }
                if (playGame.GetHit() == 1) // Ja spēlētājs trāpa, tad var šaut vēlreiz
                {
                    Console.WriteLine("Jūs trāpījāt, varat šaut vēlreiz!");
                    Console.WriteLine("Spied jebkuru taustiņu, lai turpinātu.");
                    Console.ReadLine();
                    goto Start;
                }
                else
                {
                    Console.WriteLine(" Jūs aizšāvāt garām ");
                }
                ChooseBoard("p1");
                Console.WriteLine("\n");
                ChooseBoard("p1Hit");
                Console.WriteLine("Spied jebkuru taustiņu, lai turpinātu.");
                Console.ReadLine();
            }
            else if (player == "player2")
            {
                playGame.Hit(p1, p2Hit, player, x, y);// Metode kas veic šāvienu pa pretinieka laukumu
                if (playGame.IfHitted())// Pārbauda vai jau nav šauts pa doto lauciņu
                {
                    Console.WriteLine("Jūs jau šāvāt pa šīm koordinātām un trāpījāt kuģim vai nogremdējāt to");
                    Console.WriteLine("Spied jebkuru taustiņu, lai turpinātu.");
                    Console.ReadLine();
                    goto Start;
                }
                if (playGame.GetHit() == 1)// Ja spēlētājs trāpa, tad var šaut vēlreiz
                {
                    Console.WriteLine("Jūs trāpījāt, varat šaut vēlreiz!");
                    Console.WriteLine("Spied jebkuru taustiņu, lai turpinātu.");
                    Console.ReadLine();
                    goto Start;
                }
                else
                {
                    Console.WriteLine("\n Jūs aizšāvāt garām\n ");
                }
                ChooseBoard("p2");
                Console.WriteLine("\n");
                ChooseBoard("p2Hit");
                Console.WriteLine("Spied jebkuru taustiņu, lai turpinātu.");
                Console.ReadLine();
            }
        }

        private static bool Exit()//Metode kas piedāvā spēlēt vēlreiz spēli
        {
            Console.WriteLine("Uzspēlēsim vēlreiz? Ja negribat spiediet 'n'.");
            String yn = Console.ReadLine();
            if (yn == "n")
            {
                return true;
            }
            return false;
        }

    }
}
