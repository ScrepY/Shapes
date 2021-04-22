using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.InitializingShapes;
using Shapes.RUS;

namespace Shapes
{
    struct SectionGradus
    {
        private static double X;
        private static double Y;

        public static void SectionGradusXY()
        {
            try
            {
                Console.Write("Введите координат X: ");
                X = double.Parse(Console.ReadLine());
                Console.Write("Введите координат Y: ");
                Y = double.Parse(Console.ReadLine());
                CheckGradus();

            }
            catch
            {
                ExeptionFilter.ExeptionOutput();
                SectionGradusXY();
            }


        }

        public static void CheckGradus()
        {
            Shapes sectoin = new Section(X, Y);
            sectoin.Draw();
            Thread.Sleep(2000);
            SelectRUS.NextChange();
        }
    }
}
