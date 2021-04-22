using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.RUS
{
    class SelectRUS
    {
        private static int Change;
        public static void ChangeShapeOperation()
        {
            Console.WriteLine("Выберете вычисление.");
            Console.WriteLine("1. Вычисление площи фигуры.");
            Console.WriteLine("2. Вычисление градуса фигуры");
            Console.WriteLine("\n8. Поменять язык / Select language");
            Console.WriteLine("\n9. Выйти из программы.");
            Console.Write("\n\nВыбор: ");
            
            try
            {
                Change = int.Parse(Console.ReadLine());
                CheckChange();
            }
            catch
            {
                ExeptionFilter.ExeptionOutput();
                ChangeShapeOperation();
            }

            
        }

        public static void CheckChange()
        {
            if (Change is 1)
            {
                Console.Clear();
                SelectShapesArea.SelectShapes();
            }

            else if (Change is 2)
            {
                Console.Clear();
                SelectShapeGradus.SelectShape();
            }
            else if (Change == 9)
            {
                return;
            }

            else if (Change == 8)
            {
                Console.Clear();
                SelectLanguage.ChangeLang();
            }

            else
            {
                ExeptionFilter.ExeptionOutput();
                ChangeShapeOperation();
            }

        }
        public static void NextChange()
        {
            try
            {
                int next;
                Console.WriteLine("\n1. Главное меню.\n9. Выход из программы.");
                next = int.Parse(Console.ReadLine());
                if (next is 1)
                {
                    Console.Clear();
                    SelectRUS.ChangeShapeOperation();
                }

                else if (next is 9)
                {
                    Environment.Exit(0);
                }

                else
                {
                    ExeptionFilter.ExeptionOutput();
                    NextChange();
                }
            }
            catch 
            {
                ExeptionFilter.ExeptionOutput();
                NextChange();
            }
            
        }
    }
}
