using System;

namespace Parabola
{
    class Program
    {
        static void Main(string[] args)
        {
            //INFO
            double X, Y, A, B;                                   //สมการ :  Y=(X-1)2 or Math.Sqrt(Y)+1 
            string Mode;                                         //A และ B แทน X
            Console.Write("Input X :");
            X = double.Parse(Console.ReadLine());
            Console.Write("Input Y:");
            Y = double.Parse(Console.ReadLine());
            Console.Write("Input Mode :");
            Mode = Console.ReadLine();
            if (Mode == "time")
            {
                if(X < 0)
                {
                    Console.WriteLine("Invalid Mouse Position");
                }
                else if(X >= 0)
                {
                    Y = Math.Pow(X-1,2);
                    Console.WriteLine("Output : {0} , {1}", X, Y);
                }
            }
            else if(Mode == "price")
            {
                if(X < 0)
                {
                    Console.WriteLine("Invalid Mouse Position");
                }
                else if( X >= 0)
                {
                    A = Math.Sqrt(Y) + 1;
                    Console.WriteLine("Output : {0} , {1}", A, Y);
                }
                //else if((X <= 1)&&(Y <= 1))                         //โจทย์ไม่ได้กำหนดแต่เพื่อให้ครบกรณี
                //{
                //    B = -Math.Sqrt(Y) + 1;
                //    Console.WriteLine("Output : {0} , {1}", B, Y);
                //}
            }
            else
            {
                Console.WriteLine("Invalid Mode");
            }
            Console.ReadLine();




        }
    }
}
