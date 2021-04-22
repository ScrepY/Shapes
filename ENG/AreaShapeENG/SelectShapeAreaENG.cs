using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ENG.AreaShapeENG
{
    class SelectShapeAreaENG
    {
        private static int Choice;


        public static void SelectShapes()
        {
            Console.WriteLine("Select a shape.");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Trapezium");
            Console.WriteLine("\n8. Back.");

            try
            {
                Choice = int.Parse(Console.ReadLine());
                CheckSelect2();
            }
            catch
            {
                ExeptionFilter.ExeptionOutputENG();
                SelectShapes();
            }


        }

        public static void CheckSelect2()
        {

            if (Choice == 1)
            {
                Console.Clear();
                CircleAreaENG.CircleAreaShape();
            }
            else if (Choice == 2)
            {
                Console.Clear();
                SquareAreaENG.SquareAreaShape();
            }
            else if (Choice == 3)
            {
                Console.Clear();
                TrapeziumAreaENG.Trapezium();
            }
            else if (Choice == 8)
            {
                Console.Clear();
                SelectENG.ChangeShapeOperationENG();
            }
            else
            {
                ExeptionFilter.ExeptionOutputENG();
                SelectShapes();
            }
        }

    }
}
