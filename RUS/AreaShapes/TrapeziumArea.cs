using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.InitializingShapes;

namespace Shapes.RUS.AreaShapes
{
   public class TrapeziumArea
    {
       private static double x1, x2, x3, x4, y1, y2, y3, y4;
       
       public static void Trapezium()
        {
            Console.OutputEncoding = Encoding.UTF8;
            

            Console.WriteLine("Введите значение точек x1,y1: ");
            AreaTrapezium(out x1, out y1);
            Console.WriteLine("Введите значение точек x2,y2: ");
            AreaTrapezium(out x2, out y2);
            Console.WriteLine("Введите значение точек x3,y3: ");
            AreaTrapezium(out x3, out y3);
            Console.WriteLine("Введите значение точек x4,y4: ");
            AreaTrapezium(out x4, out y4);

            Trapezium trapezium = new Trapezium(x1, x2, x3, x4, y1, y2, y3, y4);

            if (trapezium.FigureArea() is 0)
            {
                Console.WriteLine("Введены неверные значения.");
                ChangeTrapezium();
            }
            else
            {
                trapezium.Draw();
                Select.NextChange();
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
                Exeption.ExeptionOutput();
                Trapezium();
            }
        }

        public static void ChangeTrapezium()
        {
            Console.WriteLine("\nПовторить?");
            Console.WriteLine("1. Да\n2. Нет");
            int changeTrapezium;
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
                    Select.ChangeShapeOperation();
                }

                else
                {
                    Exeption.ExeptionOutput();
                    ChangeTrapezium();
                }
            }
            else
            {
                Exeption.ExeptionOutput();
                ChangeTrapezium();
            }
        }
    }
}