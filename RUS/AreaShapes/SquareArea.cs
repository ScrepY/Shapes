using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.InitializingShapes;

namespace Shapes.RUS.AreaShapes
{
    struct SquareArea
    {
        private static double A, B;

        public static void SquareAreaShape()
        {
            try
            {
                Console.Write("Введите сторону а: ");
                bool isA = double.TryParse(Console.ReadLine(), out A);
                Console.Write("Введите сторону b: ");
                bool isB = double.TryParse(Console.ReadLine(), out B);
                Console.WriteLine();
                InitializingSquare();

            }
            catch 
            {
                ExeptionFilter.ExeptionOutput();
                SquareAreaShape();
            }
            
        }

        public static void InitializingSquare()
        {
            Square square = new Square(A, B);
            square.Draw();
            Thread.Sleep(2000);
            SelectRUS.NextChange();
        }
    }
}
