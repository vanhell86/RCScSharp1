using System;
using System.Collections.Generic;
using System.Text;

namespace MajasDarbs2
{
    class Calc
    {
        private double n1;
        private double n2;
        private String choice;
        public Calc (double n1, double n2, String choice)
        {          
                this.n1 = n1;
                this.n2 = n2;
                this.choice = choice;    
        }

        public void WhatToDo()
        {
            try
            {
                switch (choice)
                {
                    case "1":
                    case "+":
                        {
                            Console.WriteLine("Skaītļu " + n1 + " un " + n2 + " summa ir: " + Add());
                            break;
                        }

                    case "2":
                    case "-":
                        {
                            Console.WriteLine("Skaītļu " + n1 + " un " + n2 + " starpība ir: " + SubStract());
                            break;
                        }

                    case "3":
                    case "*":
                        {
                            Console.WriteLine("Skaītļu " + n1 + " un " + n2 + " reizinājums ir: " + MultiPly());
                            break;
                        }

                    case "4":
                    case "/":
                        {
                            Console.WriteLine("Skaītļu " + n1 + " un " + n2 + " dalījums ir: " + Divide());
                            break;
                        }

                    case "5":
                    case "^":
                        {
                            Console.WriteLine("Skaītlis " + n1 + " , " + n2 + " pakāpē ir: " + Squaring());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Jūs neievadījāt pareizu darbību!!!");
                            break;
                        }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ar nulli nevar dalīt!!!");
            }
            //catch(FormatException)
            //{
            //    Console.WriteLine("Jūs neievadījāt skaitļus!!!");
            //}
        }

        private double Add()
        {
            return n1 + n2;
        }

        private double SubStract()
        {
            return n1 - n2;
        }

        private double MultiPly()
        {
            return n1 * n2;
        }

        private double Divide()
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException();
            }
            return n1 / n2;
        }


        private double Squaring()
        {
            double result = n1;
            if (n2 == 0)
            {
                return result = 1;
            }
            else if (n2 < 0)
            {
                for (int i = 1; i < -n2; i++)
                {
                    result = result * n1;
                }
                return 1 / result;
            }
            for (int i = 1; i < n2; i++)
            {
                result = result * n1;
            }
            return result;
        }

        private void DivideByZeroException()
        {
            throw new NotImplementedException();
        }
    }
}
