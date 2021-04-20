using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.InitializingShapes;

namespace Shapes.ENG.GradusShapeENG
{
    class SectionGradusENG
    {
        private static double X;
        private static double Y;

        public static void SectionGradusXY()
        {

            Console.Write("Enter X coordinates: ");
            bool xIsTrue = double.TryParse(Console.ReadLine(), out X);
            Console.Write("Enter Y coordinates: ");
            bool yIsTrue = double.TryParse(Console.ReadLine(), out Y);
            CheckGradus(xIsTrue, yIsTrue);
        }

        public static void CheckGradus(bool x, bool y)
        {

            if (x && y)
            {
                Shapes sectoin = new Section(X, Y);
                sectoin.DrawENG();
                Thread.Sleep(2000);
                SelectENG.NextChangeENG();

            }
            else
            {
                Exeption.ExeptionOutputENG();
                SectionGradusXY();
            }
        }
    }
}
