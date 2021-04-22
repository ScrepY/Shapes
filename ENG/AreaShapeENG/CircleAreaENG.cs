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
        private static double radiusCircle;
        public static void CircleAreaShape()
        {

            try
            {
                Console.Write("Enter the radius of the circle: ");
                radiusCircle = double.Parse(Console.ReadLine());
                InitializingCircle();
            }
            catch 
            {
                ExeptionFilter.ExeptionOutputENG();
                CircleAreaShape();
            }
            

        }

        public static void InitializingCircle()
        {
            Circle circle = new Circle(radiusCircle);
            Console.WriteLine("Area of a circle S = " + circle.FigureArea());
            Thread.Sleep(2000);
            SelectENG.NextChangeENG();
        }

    }
}