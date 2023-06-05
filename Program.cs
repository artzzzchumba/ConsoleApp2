using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double f = 5 * Math.Cos(2*x);
            Console.WriteLine("Результат"+f);
            Console.ReadKey();
        }
    }
}
