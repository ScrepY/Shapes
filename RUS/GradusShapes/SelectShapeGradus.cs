using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.RUS;

namespace Shapes
{
    class SelectShapeGradus
    {
        private static int ChangeOp;

        public static void SelectShape()
        {
            Console.WriteLine("Выбирете фигуру:");
            Console.WriteLine("1.Отрезок по осям 'X,Y' ");
            Console.WriteLine("\n8. Назад.");

            try
            {
                ChangeOp = int.Parse(Console.ReadLine());
                CheckSelect2();
            }
            catch
            {
                ExeptionFilter.ExeptionOutput();
                SelectShape();
            }
        }

        public static void CheckSelect2()
        {

            if (ChangeOp is 1)
            {
                Console.Clear();
                SectionGradus.SectionGradusXY();
            }

            else if (ChangeOp is 8)
            {
                Console.Clear();
                SelectRUS.ChangeShapeOperation();
            }

            else
            {
                ExeptionFilter.ExeptionOutput();
                SelectShape();
            }
        }

    }
}
