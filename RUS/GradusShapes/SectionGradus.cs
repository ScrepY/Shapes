using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.InitializingShapes;

namespace Shapes
{
    struct SectionGradus
    {
        private static double X;
        private static double Y;

        public static void SectionGradusXY()
        {

            Console.Write("Введите координат X: ");
            bool xIsTrue = double.TryParse(Console.ReadLine(), out X);
            Console.Write("Введите координат Y: ");
            bool yIsTrue = double.TryParse(Console.ReadLine(), out Y);
            CheckGradus(xIsTrue, yIsTrue);
        }

        public static void CheckGradus(bool x, bool y)
        {
            
            if (x && y)
            {
                Shapes sectoin = new Section(X, Y);
                sectoin.Draw();
                Thread.Sleep(2000);
                Select.NextChange();

            }
            else
            {
                Exeption.ExeptionOutput();
                SectionGradusXY();
            }
        }

       
    }
}
