using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.RUS.AreaShapes;

namespace Shapes
{
    class SelectShapesArea
    {
        private static int Choice;
        private static bool CheckChoice;

        public static void SelectShapes()
        {
            Console.WriteLine("Выбирете фигуру.");
            Console.WriteLine("1. Круг");
            Console.WriteLine("2. Квадрат");
            Console.WriteLine("3. Трапеция");
            Console.WriteLine("\n8. Назад.");

            CheckChoice = int.TryParse(Console.ReadLine(), out Choice);
            CheckSelect2();
        }

        public static void CheckSelect2()
        {
            if (CheckChoice)
            {
                if (Choice==1)
                {
                    Console.Clear();
                    RUS.AreaShapes.CircleArea.CircleAreaShape();
                }
                else if (Choice==2)
                {
                    Console.Clear();
                    SquareArea.SquareAreaShape();
                }
                else if (Choice==3)
                {
                    Console.Clear();
                    TrapeziumArea.Trapezium();
                }
                else if (Choice == 8)
                {
                    Console.Clear();
                    Select.ChangeShapeOperation();
                }
                else
                {
                    Exeption.ExeptionOutput();
                    SelectShapes();
                }
            }
            else
            {
                Exeption.ExeptionOutput();
                SelectShapes();
            }
        }

    }
}
