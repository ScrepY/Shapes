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
            try
            {
                Console.WriteLine("Enter the value of points x1, y1: ");
                x1 = int.Parse(Console.ReadLine());
                y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value of points x2,y2: ");
                x2 = int.Parse(Console.ReadLine());
                y2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value of points x3,y3: ");
                x3 = int.Parse(Console.ReadLine());
                y3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value of points x4,y4: ");
                x4 = int.Parse(Console.ReadLine());
                y4 = int.Parse(Console.ReadLine());

                Trapezium trapezium = new Trapezium(x1, x2, x3, x4, y1, y2, y3, y4);

                if (trapezium.FigureArea() is 0)
                {
                    ExeptionFilter.ExeptionOutputENG();
                    ChangeTrapezium();
                }
                else
                {
                    trapezium.DrawENG();
                    SelectENG.NextChangeENG();
                }
            }
            catch 
            {
                ExeptionFilter.ExeptionOutputENG();
                Trapezium();
            }
        }


        public static void ChangeTrapezium()
        {
            int changeTrapezium;

            Console.WriteLine("\nRepeat?");
            Console.WriteLine("1. Yes\n2. No");
            try
            {
                changeTrapezium = int.Parse(Console.ReadLine());
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
                    ExeptionFilter.ExeptionOutputENG();
                    ChangeTrapezium();
                }
            }
            catch 
            {
               ExeptionFilter.ExeptionOutputENG(); 
               ChangeTrapezium();
            }
            
                
        }
            
    }
}
