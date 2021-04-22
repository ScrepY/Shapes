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
            try
            {
                Console.Write("Enter side A: ");
                A = double.Parse(Console.ReadLine());
                Console.Write("Enter side B: ");
                B = double.Parse(Console.ReadLine());
                Console.WriteLine();
                InitializingSquare();
            }
            catch
            {
                ExeptionFilter.ExeptionOutputENG();
                SquareAreaShape();
            }
        }

        public static void InitializingSquare()
        {
            Square square = new Square(A, B);
            square.DrawENG();
            Thread.Sleep(2000);
            SelectENG.NextChangeENG();
        }
        
    }
}
    



