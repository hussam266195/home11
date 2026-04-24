using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using super_CLASS;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GO go = new GO();
            Console.Write("Enter number:");
            int number = go.kj.v.z.moon.mxm;
            number = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(number);
            Console.ResetColor();
        }
    }
}
