using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace isp2

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double R, x;
                Console.WriteLine("Введите x");
                x = double.Parse(Console.ReadLine());
                double a = Math.Pow(Math.Sin(x * x + 4), 3) + 4.3;
                double b = Math.Pow(Math.Sin(Math.Pow(x, 4)), 3);
                R = a / b;
                Console.WriteLine("R=" + R);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }

}
