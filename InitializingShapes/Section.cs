using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.InitializingShapes
{

    public class Section : Shapes
    {
        private readonly double X;
        private readonly double Y;

        public Section(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override double FigureArea()
        {
            return X * Y;
        }

        public override double Gradus()
        {

            double result = Math.Abs(Math.Atan2(Y, X) * 180 / Math.PI);
            return result;

        }


        public override double Length()
        {
            double result = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return result;
        }

        public override void Draw()
        {
            Console.WriteLine($"\nГрадус кута между осью ОХ: {Gradus()}");
            Console.WriteLine($"Длинна OA: {Length()}");
        }

        public override void DrawENG()
        {
            Console.WriteLine($"Degree of angle between the OX axis: {Gradus()}");
            Console.WriteLine($"Length OA: {Length()}");
        }
    }
}

