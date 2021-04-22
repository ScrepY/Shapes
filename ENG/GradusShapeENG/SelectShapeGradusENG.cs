using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ENG.GradusShapeENG
{
    class SelectShapeGradusENG
    {
        private static int ChangeOp;
        public static void SelectShape()
        {

            Console.WriteLine("Select a shape:");
            Console.WriteLine("1.Segment along the axes 'X, Y'");
            Console.WriteLine("\n8. Back.");

            try
            {
                ChangeOp = int.Parse(Console.ReadLine());
                CheckSelect2();
            }
            catch
            {
                ExeptionFilter.ExeptionOutputENG();
                SelectShape();
            }

        }

        public static void CheckSelect2()
        {

            if (ChangeOp is 1)
            {
                Console.Clear();
                SectionGradusENG.SectionGradusXY();
            }

            else if (ChangeOp is 8)
            {
                Console.Clear();
                SelectENG.ChangeShapeOperationENG();
            }

            else
            {
                ExeptionFilter.ExeptionOutputENG();
                SelectShape();
            }
        }

    }
}
