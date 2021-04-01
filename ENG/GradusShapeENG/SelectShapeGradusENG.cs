using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ENG.GradusShapeENG
{
    class SelectShapeGradusENG
    {
        public static void SelectShape()
        {

            Console.WriteLine("Select a shape:");
            Console.WriteLine("1.Segment along the axes 'X, Y'");
            Console.WriteLine("\n8. Back.");
            int ChangeOp;
            bool CheckChange;
            CheckChange = int.TryParse(Console.ReadLine(), out ChangeOp);
            CheckSelect2(ChangeOp, CheckChange);
        }

        public static void CheckSelect2(int ChangeOp, bool CheckChange)
        {
            if (CheckChange)
            {
                if (ChangeOp is 1)
                {
                    Console.Clear();
                    SectionGradusENG.SectionGradusXY();
                }

                else
                {
                    Exeption.ExeptionOutputENG();
                    SelectShape();
                }
            }

            else
            {
                Exeption.ExeptionOutputENG();
                SelectShape();
            }
        }
    }
}
