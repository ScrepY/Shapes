using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using Shapes.ENG;
using Shapes.RUS;

namespace Shapes
{
    static class SelectLanguage
    {
        public static void ChangeLang()
        {
            int change = 0;
            Console.WriteLine("Select language / Выберете язык");
            Console.Write("1. RUS\n2. ENG\n\n9.Exit the program / Выйти из программы\n\nChange / Выбор: ");
            try
            {
                change = int.Parse(Console.ReadLine());
            }
            catch
            {
                Exeption.ExeptionOutputRUSAndENG();
                ChangeLang();
            }

            ChangeCheck(change);
        }

        public static void ChangeCheck(int change)
        {
            switch (change)
            {
                case 1:
                    Console.Clear();
                    SelectRUS.ChangeShapeOperation();
                    break;

                case 2:
                    Console.Clear();
                    SelectENG.ChangeShapeOperationENG();
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

    }
}
