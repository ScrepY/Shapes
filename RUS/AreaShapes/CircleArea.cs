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
            
            bool isTryParse = double.TryParse(Console.ReadLine(), out radiusCircle);
            if (isTryParse)
            {
                Circle circle = new Circle(radiusCircle);
                Console.WriteLine($"Площадь квадрата S = {circle.FigureArea()}");
                Thread.Sleep(2000);
                Select.NextChange();
            }
            else
            {
                Exeption.ExeptionOutput();
                CircleAreaShape();
            }

        }
    }
}
