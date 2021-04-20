using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.InitializingShapes;

namespace Shapes.ENG.AreaShapeENG
{
    class TrapeziumAreaENG
    {
        private static double x1, x2, x3, x4, y1, y2, y3, y4;

        public static void Trapezium()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Enter the value of points x1, y1: ");
            AreaTrapezium(out x1, out y1);
            Console.WriteLine("Enter the value of points x2,y2: ");
            AreaTrapezium(out x2, out y2);
            Console.WriteLine("Enter the value of points x3,y3: ");
            AreaTrapezium(out x3, out y3);
            Console.WriteLine("Enter the value of points x4,y4: ");
            AreaTrapezium(out x4, out y4);

            Trapezium trapezium = new Trapezium(x1, x2, x3, x4, y1, y2, y3, y4);

            if (trapezium.FigureArea() is 0)
            {
                Console.WriteLine("Invalid values entered.");
                ChangeTrapezium();
            }
            else
            {
                trapezium.DrawENG();
                SelectENG.NextChangeENG();
            }
        }



        public static void AreaTrapezium(out double x, out double y)
        {
            bool xIsTrue = double.TryParse(Console.ReadLine(), out x);
            bool yIsTrue = double.TryParse(Console.ReadLine(), out y);

            if (xIsTrue && yIsTrue)
            {
                return;
            }
            else
            {
                Exeption.ExeptionOutputENG();
                Trapezium();
            }
        }

        public static void ChangeTrapezium()
        {
            int changeTrapezium;

            Console.WriteLine("\nRepeat?");
            Console.WriteLine("1. Yes\n2. No");

            bool isTrue = int.TryParse(Console.ReadLine(), out changeTrapezium);
            if (isTrue)
            {
                if (changeTrapezium is 1)
                {
                    Console.Clear();
                    Trapezium();
                }

                else if (changeTrapezium is 2)
                {
                    Console.Clear();
                    SelectENG.ChangeShapeOperationENG();
                }

                else
                {
                    Exeption.ExeptionOutputENG();
                    ChangeTrapezium();
                }
            }
            else
            {
                Exeption.ExeptionOutputENG();
                ChangeTrapezium();
            }
        }
    }
}
