using System;

namespace HW_week3_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //INFO
            int password;
            string agency;

            //INPUT
            Console.Write("Input 6 digit password :");
            password = int.Parse(Console.ReadLine());
            Console.Write("What is your agency :");
            agency = (Console.ReadLine());


            //UNIT
            int num100k = password / 100000;
            int num10k = (password / 10000) - num100k;
            int num1k = (password / 1000) - num100k - num10k;
            int num100 = (password / 100) - num100k - num10k - num1k;
            int num10 = (password / 10) - num100k - num10k - num1k - num100;
            int num1 = (password / 1) - num100k - num10k - num1k - num100 - num10;


            //IF ELSE STATEMENT
            if (agency == "CIA")
            {
                if ((num1 % 3 == 0))
                {
                    if ((num10 != 1) && (num10 != 3) && (num10 != 5))
                    {
                        if ((num1k >= 6) && (num1k != 8))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (agency == "FBI")
            {
                if ((num100k >= 4) && (num100k <= 7))
                {
                    if ((num100 % 2 == 0) && (num100 != 6))
                    {
                        if (num10k % 2 == 1)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (agency == "NSA")
            {
                if ((num1 % 30 == 0))
                {
                    if ((num100 % 2 != 0) && (num100 % 3 == 0))
                    {
                        if ((num1 == 7) || (num10 == 7) || (num100 == 7) || (num1k == 7) || (num10k == 7) || (num100k == 7))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}