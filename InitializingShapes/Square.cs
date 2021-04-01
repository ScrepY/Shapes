using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.InitializingShapes
{
    public class Square : Shapes
    {
        private readonly double A;
        private readonly double B;

        public Square(double a, double b)
        {
            A = a;
            B = b;
        }

        public override void Draw()
        {
            Console.WriteLine($"Площадь квадрата S = {FigureArea()}");
        }

        public override void DrawENG()
        {
            Console.WriteLine($"Square area S = {FigureArea()}");
        }

        public override double FigureArea()
        {
            return A * B;
        }
    }
}
