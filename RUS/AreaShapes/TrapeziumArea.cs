using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.InitializingShapes;

namespace Shapes.RUS.AreaShapes
{
   public struct TrapeziumArea
    {
       private static double x1, x2, x3, x4, y1, y2, y3, y4;
       
       public static void Trapezium()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine("Введите значение точек x1, y1: ");
                x1 = int.Parse(Console.ReadLine());
                y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение точек x2,y2: ");
                x2 = int.Parse(Console.ReadLine());
                y2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение точек x3,y3: ");
                x3 = int.Parse(Console.ReadLine());
                y3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение точек x4,y4: ");
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
                    trapezium.Draw();
                    SelectRUS.NextChange();
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

            Console.WriteLine("\nПовторить?");
            Console.WriteLine("1. Да\n2. Нет");

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
                    SelectRUS.ChangeShapeOperation();
                }

                else
                {
                    ExeptionFilter.ExeptionOutput();
                    ChangeTrapezium();
                }
            }

            catch 
            {
                ExeptionFilter.ExeptionOutput();
                ChangeTrapezium();
            }
        }
    }
}