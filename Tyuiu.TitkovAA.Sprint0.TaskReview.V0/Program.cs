using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.TitkovAA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            bool tr = true;
            Console.WriteLine("Вводи 1 число -> ");
            while (tr)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    tr = false;
                }
                catch
                {
                    Console.WriteLine("это не число ");
                }
            }

            tr = true;
            Console.WriteLine("Вводи 2 число -> ");
            while (tr)
            {
                try
                {
                    b = int.Parse(Console.ReadLine());
                    tr = false;
                }
                catch
                {
                    Console.WriteLine("это не число ");
                }
            }
            tr = true;

            Console.WriteLine("Вводи 3 число -> ");
            while (tr)
            {
                try
                {
                    c = int.Parse(Console.ReadLine());
                    tr = false;
                }
                catch
                {
                    Console.WriteLine("это не число ");
                }
            }

            Console.WriteLine(DataService.Calc(a, b, c));
            Console.ReadKey();

        }
    }
}
