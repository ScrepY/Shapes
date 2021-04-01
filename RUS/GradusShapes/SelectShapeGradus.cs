using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shapes
{
    class SelectShapeGradus
    {
        public static void SelectShape()
        {

            Console.WriteLine("Выбирете фигуру:");
            Console.WriteLine("1.Отрезок по осям 'X,Y' ");
            Console.WriteLine("\n8. Назад.");
            int ChangeOp;
            bool CheckChange;
            CheckChange = int.TryParse(Console.ReadLine(), out ChangeOp);
            CheckSelect2(ChangeOp,CheckChange);
        }

        public static void CheckSelect2(int ChangeOp,bool CheckChange)
        {
            if (CheckChange)
            {
                if (ChangeOp is 1)
                {
                    Console.Clear();
                    SectionGradus.SectionGradusXY();
                }

                else
                {
                    Exeption.ExeptionOutput();
                    SelectShape();
                }
            }

            else
            {
               Exeption.ExeptionOutput();
                SelectShape();
            }
        }
        
    }
}
