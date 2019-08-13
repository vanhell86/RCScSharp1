using System;
using System.Collections.Generic;
using System.Text;

namespace Batleship
{

    class PlayGame
    {
        List<int> hitCoordXP1 = new List<int>();    // izveidojam sarakstus, kur glabāsim sašauto kuģu koord. 1. spēlētājam
        List<int> hitCoordYP1 = new List<int>();
        List<int> hitCoordXP2 = new List<int>();    // izveidojam sarakstus, kur glabāsim sašauto kuģu koord. 2. spēlētājam
        List<int> hitCoordYP2 = new List<int>();

        int hit = 0;
        bool ifHitted = false;



        public bool IfHit(String[,] playerBoard, int x, int y)  // Metode kas pārbauda vai trāpīts
        {
            if (playerBoard[x, y] != " " && playerBoard[x, y] != "H" && playerBoard[x, y] != "X" && playerBoard[x, y] != "M")
            {
                hit = 1;    // Ja ir trāpīts, tad hit ir 1. Vajag lai atkārtotu spēlētāja gājienu un lai noteiktu vai kāds ir uzvarējis
                return true;
            }
            else
            {
                hit = 0;
                return false;
            }
        }

        public void Hit(String[,] playerBoard, String[,] opponentBoard, String player, int x, int y)    // Metode kas veic šāvienus
        {                                                                               // un samaina lauciņu vērtības
            x = x - 1;
            y = y - 1;

            if (IfHit(playerBoard, x, y) == true)   // Pārbauda vai trāpīts
            {
                if (IfSunk(playerBoard, x, y) == true)  // Pārbauda vai nav nogrimis
                {
                    Console.WriteLine("Kuģis ir nogrimis!");
                    playerBoard[x, y] = "X";    // samainam pretinieka spēlētāja laukuma vērtības uz X(nogremdēts) esošajām koord.
                    opponentBoard[x, y] = "X";  // samainam spēlētāja mērķa laukuma vērtības uz X(nogremdēts) esošajām koord.
                    if (player == "player1") // ja šauj pirmais spēlētājs
                    {
                        for (int i = 0; i < hitCoordXP1.Count; i++)
                        {
                            playerBoard[hitCoordXP1[i], hitCoordYP1[i]] = "X";  // samaina uz X saglabātajām vērtībām
                            opponentBoard[hitCoordXP1[i], hitCoordYP1[i]] = "X";  // samaina uz X saglabātajām vērtībām
                        }
                        hitCoordXP1.Clear();    // Notīram sarakstus
                        hitCoordYP1.Clear();
                        ifHitted = false;
                    }
                    else if (player == "player2")   // ja šauj 2. spelētājs, viss tas pats kas 1. spēlētājam
                    {
                        for (int i = 0; i < hitCoordXP2.Count; i++)
                        {
                            playerBoard[hitCoordXP2[i], hitCoordYP2[i]] = "X";
                            opponentBoard[hitCoordXP2[i], hitCoordYP2[i]] = "X";
                        }
                        hitCoordXP2.Clear();
                        hitCoordYP2.Clear();
                        ifHitted = false;
                    }

                }
                else    // ja nav nogrimis, bet ir trāpīts
                {
                    playerBoard[x, y] = "H";    //samainam vērtību uz H
                    opponentBoard[x, y] = "H";
                    if (player == "player1")
                    {
                        hitCoordXP1.Add(x);     // pievienojam x un y koord. sarakstam
                        hitCoordYP1.Add(y);
                        ifHitted = false;
                    }
                    else if (player == "player2")
                    {
                        hitCoordXP2.Add(x);
                        hitCoordYP2.Add(y);
                        ifHitted = false;
                    }
                }
            }
            else if (playerBoard[x, y] == "H" || playerBoard[x, y] == "X" || playerBoard[x, y] == "M")  // ja ir šauts, vai jau trāpīts 
            {                                                                                           // vai jau nogremdēts
                ifHitted = true;// pasakam ka ir jau šauts pa šo lauciņu
            }
            else        // ja nav trāpīts
            {
                playerBoard[x, y] = "M";    // samainam vērtību uz M
                opponentBoard[x, y] = "M";
                ifHitted = false;
            }
        }



        public bool IfSunk(String[,] playerBoard, int x, int y) // Metode kas pārbauda vai nav nogrimis kuģis
        {

            bool test = false;
            int shipLength = ShipLenght(playerBoard, x, y); // iegūstam sašautā kuģa garumu

            for (int i = 0; i < shipLength; i++)    // veicam pārbaudi kuģa uz visām pusēm kuģa garuma apmērā
            {

                if ((x == 0) && (y == 0))   // pārbaude tikai pa labi un uz leju
                {
                    if (playerBoard[x, y + i] != ShipID(shipLength) &&
                        playerBoard[x + i, y] != ShipID(shipLength))
                    {
                        test = true;
                    }
                    else
                    {
                        test = false;
                    }
                }
                else if ((x == 0) && (y == 9))  // pārbaude tikai pa kreisi un uz leju
                {
                    if (playerBoard[x, y - i] != ShipID(shipLength) &&
                        playerBoard[x + i, y] != ShipID(shipLength))
                    {
                        test = true;
                    }
                    else
                    {
                        test = false;
                    }
                }
                else if ((x == 9) && (y == 0)) // pārbaude tikai pa labi un uz augšu
                {
                    try { 
                    if (playerBoard[x, y + i] != ShipID(shipLength) &&
                        playerBoard[x - i, y] != ShipID(shipLength))
                    {
                        test = true;
                    }
                    else
                    {
                        test = false;
                    }
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                }
                else if ((x == 9) && (y == 9)) // pārbaude tikai pa kreisi un uz augšu
                {
                    try { 
                    if (playerBoard[x, y - i] != ShipID(shipLength) &&
                        playerBoard[x - i, y] != ShipID(shipLength))
                    {
                        test = true;
                    }
                    else
                    {
                        test = false;
                    }
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                }
                else if ((x == 0) && (y > 0) && (y < 9))    // pārbaude tikai pa labi, pa kreisi un uz leju
                {
                    try { 
                    if (playerBoard[x, y + i] != ShipID(shipLength) &&
                        playerBoard[x, y - i] != ShipID(shipLength) &&
                        playerBoard[x + i, y] != ShipID(shipLength))
                    {
                        test = true;
                    }
                    else
                    {
                        test = false;
                    }
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                }
                else if ((x == 9) && (y > 0) && (y < 9))    // pārbaude tikai pa labi, pa kreisi un uz augšu
                {
                    
                    try
                    {
                        if (playerBoard[x, y + i] != ShipID(shipLength) &&
                        playerBoard[x, y - i] != ShipID(shipLength) &&
                        playerBoard[x - i, y] != ShipID(shipLength))
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                }
                else if ((x > 0) && (x < 9) && (y == 0))    // pārbaude tikai pa labi, uz augšu un uz leju
                {
                    try
                    {
                        if (playerBoard[x - i, y + i] != ShipID(shipLength) &&
                            playerBoard[x - i, y] != ShipID(shipLength) &&
                            playerBoard[x + i, y] != ShipID(shipLength) &&
                            playerBoard[x, y + i] != ShipID(shipLength))
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                }
                else if ((x > 0) && (x < 9) && (y == 9))    // pārbaude tikai pa kreisi, uz augšu un uz leju
                {
                    try { 
                    if (playerBoard[x - i, y] != ShipID(shipLength) &&
                        playerBoard[x + i, y - i] != ShipID(shipLength) &&
                        playerBoard[x, y - i] != ShipID(shipLength))
                    {
                        test = true;
                    }
                    else
                    {
                        test = false;
                    }
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                }
                else    // pārbaudam uz visām pusēm tikai skatamies vai tā nepārsniedz laukuma robežas
                {
                    if (x + shipLength > 9) // neskatamies uz leju
                    {
                        if (playerBoard[x, y + i] != ShipID(shipLength) &&
                        playerBoard[x, y - i] != ShipID(shipLength) &&
                        playerBoard[x - i, y] != ShipID(shipLength))
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                        }
                    }
                    else if (x - shipLength < 0)    // neskatamies uz augšu
                    {
                        if (playerBoard[x, y + i] != ShipID(shipLength) &&
                        playerBoard[x, y - i] != ShipID(shipLength) &&
                        playerBoard[x + i, y] != ShipID(shipLength))
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                        }
                    }
                    else if (y + shipLength > 9)    // neskatamies pa labi
                    {
                        if (playerBoard[x, y] != ShipID(shipLength) &&
                        playerBoard[x + i, y - i] != ShipID(shipLength) &&
                        playerBoard[x - i, y] != ShipID(shipLength))
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                        }
                    }
                    else if (y - shipLength < 0)    // neskatamies pa kreisi
                    {
                        if (playerBoard[x, y] != ShipID(shipLength) &&
                        playerBoard[x + i, y + i] != ShipID(shipLength) &&
                        playerBoard[x - i, y] != ShipID(shipLength))
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                        }
                    }
                    else    // skatamies visur rinķī
                    {
                        if (playerBoard[x, y + i] != ShipID(shipLength) &&
                       playerBoard[x, y - i] != ShipID(shipLength) &&
                       playerBoard[x + i, y] != ShipID(shipLength) &&
                       playerBoard[x - i, y] != ShipID(shipLength))
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                        }
                    }
                }
            }
            return test;
        }

        public String ShipID(int shipLength)    //Metode kas iegūst kuģa ID
        {
            if (shipLength == 2)
            {
                return "D";
            }
            else if (shipLength == 3)
            {
                return "S";
            }
            else if (shipLength == 4)
            {
                return "B";
            }
            return "";
        }

        public int ShipLenght(String[,] playerboard, int x, int y)  // Metode kas iegūst kuģa garumu
        {
            if (playerboard[x, y] == "D")
            {
                return 2;
            }
            else if (playerboard[x, y] == "S")
            {
                return 3;
            }
            else if (playerboard[x, y] == "B")
            {
                return 4;
            }
            return 0;
        }

        public int GetHit()
        {
            return hit;
        }

        public bool IfHitted()
        {
            return ifHitted;
        }
    }
}
