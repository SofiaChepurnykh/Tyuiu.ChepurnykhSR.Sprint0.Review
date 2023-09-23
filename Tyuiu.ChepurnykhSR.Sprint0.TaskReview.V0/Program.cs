using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChepurnykhSR.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());

            int y;

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            int z;

            Console.WriteLine("Введите значение Z: ");
            z = Convert.ToInt32(Console.ReadLine());

            int result = DataService.Calc(x, y, z);

            Console.WriteLine($"Значение выражения ({x}+{y}+{z}) * 5 = {result}");
            Console.ReadKey();

        }
    }
}
