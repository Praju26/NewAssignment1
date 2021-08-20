using System;

namespace NewAssignment1
{
    partial class Program
    {
        static void Main()
        {
            {
                CalCulator sq = new CalCulator();
               // Console.WriteLine(sq.Square(5));
                Console.WriteLine(sq.Add(8, 63));
                Console.WriteLine(sq.Multiply(5, 8));
                Console.WriteLine(sq.Subtract(10, 42));
                Console.WriteLine(sq.Division(3, 4));
                Console.ReadLine();
            }
        }
    }



}



