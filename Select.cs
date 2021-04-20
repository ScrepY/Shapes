using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using Shapes.ENG.AreaShapeENG;
using Shapes.ENG.GradusShapeENG;
using Console = System.Console;

namespace Shapes
{
    class Select
    {
        private static int ChangeOp;
        
        public static void ChangeShapeOperation()
        {
            Console.WriteLine("Выберете вычисление.");
            Console.WriteLine("1. Вычисление площи фигуры.");
            Console.WriteLine("2. Вычисление градуса фигуры");
            Console.WriteLine("\n8. Поменять язык / Select language");
            Console.WriteLine("\n9. Выйти из программы.");
            Console.Write("\n\nВыбор: "); 
            bool CheckChangeBool = int.TryParse(Console.ReadLine(), out ChangeOp);
            CheckChange();
        }

        public static void ChangeShapeOperationENG()
        {
            Console.WriteLine("Select calculation.");
            Console.WriteLine("1. Calculating the area of a figure.");
            Console.WriteLine("2. Calculating the degree of a figure");
            Console.WriteLine("\n8. Select language / Поменять язык");
            Console.WriteLine("\n9. Exit the program.");
            Console.Write("\n\nChoice: ");
            bool CheckChangeBool = int.TryParse(Console.ReadLine(), out ChangeOp);
            CheckChangeENG();
        }

        public static void CheckChange()
        {
            if (ChangeOp is 1)
            {
                Console.Clear();
                SelectShapesArea.SelectShapes();
            }

            else if (ChangeOp is 2)
            {
                Console.Clear();
                SelectShapeGradus.SelectShape();
            }
            else if (ChangeOp == 9)
            {
                return;
            }

            else if (ChangeOp == 8)
            {
                Console.Clear();
                SelectLanguage.ChangeLang();
            }
            
            else
            {
                Exeption.ExeptionOutput();
                ChangeShapeOperation();
            }

        }

        public static void CheckChangeENG()
        {
            if (ChangeOp is 1)
            {
                Console.Clear();
                SelectShapeAreaENG.SelectShapes(); //ENG
            }

            else if (ChangeOp is 2)
            {
                Console.Clear();
                SelectShapeGradusENG.SelectShape();//ENG
            }
            else if (ChangeOp == 9)
            {
                Environment.Exit(0);
            }

            else if (ChangeOp == 8)
            {
                Console.Clear();
                SelectLanguage.ChangeLang();
            }

            else
            {
                Exeption.ExeptionOutputENG();
                ChangeShapeOperationENG();
            }
        }

        public static void NextChange()
        {
            Console.WriteLine("\n1. Главное меню.\n9. Выход из программы.");
            int next;
            bool nextChange = int.TryParse(Console.ReadLine(), out next);

            if (nextChange)
            {
                if (next is 1)
                {
                    Console.Clear();
                    Select.ChangeShapeOperation();
                }

                else if (next is 9)
                {
                    Environment.Exit(0);
                }

                else
                {
                    Exeption.ExeptionOutput();
                    NextChange();
                }
            }
            else
            {
                Exeption.ExeptionOutput();
                NextChange();
            }
        }

        public static void NextChangeENG()
        {
            Console.WriteLine("\n1. Main menu.\n9. Exiting the program.");
            int next;
            bool nextChange = int.TryParse(Console.ReadLine(), out next);

            if (nextChange)
            {
                if (next is 1)
                {
                    Console.Clear();
                    Select.ChangeShapeOperationENG();
                }

                else if (next is 9)
                {
                    Environment.Exit(0);
                }

                else
                {
                    Exeption.ExeptionOutputENG();
                    NextChangeENG();
                }
            }
            else
            {
                Exeption.ExeptionOutputENG();
                NextChangeENG();
            }
        }
    }
}
