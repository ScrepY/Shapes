using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.InitializingShapes;

namespace Shapes.ENG.AreaShapeENG
{
    class CircleAreaENG : Shapes
    {
        public static void CircleAreaShape()
        {
            double radiusCircle;

            Console.Write("Enter the radius of the circle: ");
            bool isTryParse = double.TryParse(Console.ReadLine(), out radiusCircle);

            if (isTryParse)
            {
                Circle circle = new Circle(radiusCircle);
                Console.WriteLine("Area of a circle S = " + circle.FigureArea());
                Thread.Sleep(2000);
                Select.NextChangeENG();
            }

            else
            {
                Exeption.ExeptionOutputENG();
                CircleAreaShape();
            }

        }

    }
}