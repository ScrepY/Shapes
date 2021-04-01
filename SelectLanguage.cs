using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Shapes
{
   static class  SelectLanguage
    {
        public static void ChangeLang()
        {
            int change;
            bool isTrueChange;
            Console.WriteLine("Select language / Выберете язык");
            Console.Write("1. RUS\n2. ENG\n\n9.Exit the program / Выйти из программы\n\nChange / Выбор: ");
            isTrueChange = int.TryParse(Console.ReadLine(), out change);
            ChangeCheck(isTrueChange,change);
        }
        
        public static void ChangeCheck(bool changeBool,int change)
        {
            if (changeBool)
            {
                switch (change)
                {
                    case 1:
                        Console.Clear();
                        Select.ChangeShapeOperation();
                        break;

                    case 2:
                        Console.Clear();
                        Select.ChangeShapeOperationENG();
                        break;
                    case 9:
                    
                        Environment.Exit(0);
                        break;

                    default:
                        Exeption.ExeptionOutputRUSAndENG();
                        ChangeLang();
                        break;
                }
            }

            else
            {
                Exeption.ExeptionOutputRUSAndENG();
                ChangeLang();
            }
        }
    }
}
