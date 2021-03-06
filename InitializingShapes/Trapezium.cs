using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.InitializingShapes
{
    public class Trapezium : Shapes
    {
        private readonly double X1, X2, X3, X4, Y1, Y2, Y3, Y4;

        private readonly double A, B, C, D;

        private double perimetrS;
        public double PerimetrS { get { return perimetrS; } }

        public Trapezium(double x1, double x2, double x3, double x4, double y1, double y2, double y3, double y4)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
            X4 = x4;
            Y1 = y1;
            Y2 = y2;
            Y3 = y3;
            Y4 = y4;

            A = ((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
            B = ((X3 - X2) * (X3 - X2) + (Y3 - Y2) * (Y3 - Y2));
            C = ((X4 - X3) * (X4 - X3) + (Y4 - Y3) * (Y4 - Y3));
            D = ((X1 - X4) * (X1 - X4) + (Y1 - Y4) * (Y1 - Y4));
            perimetrS = Perimetr();
        }


        public override void Draw()
        {
            Console.WriteLine("\nРезультат: ");
            Console.WriteLine($"Длинна стороны А: {A} см");
            Console.WriteLine($"Длинна стороны B: {B} см");
            Console.WriteLine($"Длинна стороны C: {C} см");
            Console.WriteLine($"Длинна стороны D: {D} см");
            Console.WriteLine($"\nПлощадь трапеции: {FigureArea()} cm\u00B2");
            Console.WriteLine($"Периметр трапеции: {PerimetrS} cm\u00B2");
        }

        public override void DrawENG()
        {
            Console.WriteLine("Result:");
            Console.WriteLine($"Length of side A: {A} cm");
            Console.WriteLine($"Length of side B: {B} cm");
            Console.WriteLine($"Length of side C: {C} cm");
            Console.WriteLine($"Length of side D: {D} cm");
            Console.WriteLine($"Trapezium area: {FigureArea()} cm\u00b2");
            Console.WriteLine($"Perimeter of the trapezoid: {PerimetrS} cm\u00b2");
        }

        public override double FigureArea()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double per = perimetrS / 2;
            double S = ((A + B) / (A - B)) * (Math.Sqrt((per - A) * (per - B) * (per - A - C) * (per - A - D)));
            if (double.IsNaN(0 / S))
            {
                return 0;
            }

            else
            {
                return S;
            }
        }



        public double Perimetr()
        {
            double perimetr = A + B + C + D;
            return perimetr;
        }

    }
}
