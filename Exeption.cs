using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shapes
{
    class Exeption
    {
       
       
        public static void ExeptionOutput()
        {
            
            Console.WriteLine("Неверный ввод данных, повторите попытку.");
            Thread.Sleep(2000);
            Console.Clear();

        }

        public static void ExeptionOutputENG()
        {
            Console.WriteLine("Invalid data entry, try.");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void ExeptionOutputRUSAndENG()
        {
            Console.WriteLine("Неверный ввод данных, повторите попытку / Invalid data entry, try.");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}
