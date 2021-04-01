using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.InitializingShapes
{


    public class Circle : Shapes
    {
        private readonly double Radius;
        private readonly double PI = Math.PI;

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double FigureArea()
        {
            return PI * Radius * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Площадь круга S = {FigureArea()}");
        }

        public override void DrawENG()
        {
            Console.WriteLine($"Circle area S = {FigureArea()}");
        }
    }
}

