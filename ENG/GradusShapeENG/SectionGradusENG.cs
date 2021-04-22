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
            try
            {
                Console.Write("Enter X coordinates: ");
                X = int.Parse(Console.ReadLine());
                Console.Write("Enter Y coordinates: ");
                Y = int.Parse(Console.ReadLine());
                CheckGradus();
            }

            catch
            {
                ExeptionFilter.ExeptionOutputENG();
            }

        }

        public static void CheckGradus()
        {

            Shapes sectoin = new Section(X, Y);
            sectoin.DrawENG();
            Thread.Sleep(2000);
            SelectENG.NextChangeENG();


        }
    }
}
