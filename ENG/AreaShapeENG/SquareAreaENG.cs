using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.InitializingShapes;

namespace Shapes.ENG.AreaShapeENG
{
    class SquareAreaENG
    {
        private static double A, B;
        public static void SquareAreaShape()
        {

            Console.Write("Enter side A: ");
            bool isA = double.TryParse(Console.ReadLine(), out A);
            Console.Write("Enter side B: ");
            bool isB = double.TryParse(Console.ReadLine(), out B);
            Console.WriteLine();

            if (isA && isB)
            {
                Square square = new Square(A, B);
                square.DrawENG();
                Thread.Sleep(2000);
                Select.NextChangeENG();
            }
            else
            {
                Exeption.ExeptionOutputENG();
                SquareAreaShape();
            }

        }
    }
    

}

