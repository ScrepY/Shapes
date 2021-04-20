using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.ENG.AreaShapeENG;
using Shapes.ENG.GradusShapeENG;

namespace Shapes.ENG
{
    class SelectENG
    {
        private static int Change;
        public static void ChangeShapeOperationENG()
        {
            Console.WriteLine("Select calculation.");
            Console.WriteLine("1. Calculating the area of a figure.");
            Console.WriteLine("2. Calculating the degree of a figure");
            Console.WriteLine("\n8. Select language / Поменять язык");
            Console.WriteLine("\n9. Exit the program.");
            Console.Write("\n\nChoice: ");
            
            try
            {
                Change = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Exeption.ExeptionOutputENG();
                ChangeShapeOperationENG();
            }

            CheckChangeENG();
        }


        public static void CheckChangeENG()
        {
            if (Change is 1)
            {
                Console.Clear();
                SelectShapeAreaENG.SelectShapes(); //ENG
            }

            else if (Change is 2)
            {
                Console.Clear();
                SelectShapeGradusENG.SelectShape();//ENG
            }
            else if (Change == 9)
            {
                Environment.Exit(0);
            }

            else if (Change == 8)
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
                    SelectENG.ChangeShapeOperationENG();
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
