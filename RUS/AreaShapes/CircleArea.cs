using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.InitializingShapes;

namespace Shapes.RUS.AreaShapes
{
    struct CircleArea
    {
        private static double radiusCircle;

        public static void CircleAreaShape()
        {

            Console.Write("Введите радиус круга: ");
            try
            {
                radiusCircle = int.Parse(Console.ReadLine());
                Circle circle = new Circle(radiusCircle);
                Console.WriteLine($"Площадь круга S = {circle.FigureArea()}");
                Thread.Sleep(2000);
                SelectRUS.NextChange();
            }
            catch 
            {
                ExeptionFilter.ExeptionOutput();
                CircleAreaShape();
            }
            
        }
    }
}
