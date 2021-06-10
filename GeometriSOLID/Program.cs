using System;
using System.Collections.Generic;

namespace GeometriSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Square a = new Square(5);
            Console.WriteLine(a.Circumference());
            Console.WriteLine(a.Areal());

            Square b = new Rektangel(3, 6);
            Console.WriteLine(b.Circumference());
            Console.WriteLine(b.Areal());

            Square c = new parallelogram(5, 7);
            Console.WriteLine(c.Circumference());
            Console.WriteLine(c.Areal());*/

            List<Square> fristlist = new List<Square>();
            fristlist.Add(new Square(5));
            fristlist.Add(new Rektangel(3, 6));
            fristlist.Add(new parallelogram(3, 6, 60));
            fristlist.Add(new Trapez(30, 20, 17, 13));
            fristlist.Add(new triangle(6, 7, 9));

            for (int i = 0; i < fristlist.Count; i++)
            {
                Console.WriteLine("Circumference: " + fristlist[i].Circumference());
                Console.WriteLine("Areal: " + fristlist[i].Areal());
                Console.WriteLine();
            }
        }
    }
}
