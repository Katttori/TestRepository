using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 600;
            int b = 9;
            byte c = checked((byte)(a + b));
            Console.WriteLine("Master hello!");
            Console.WriteLine("Rusik");
            Console.WriteLine($"{a}");
        }
    }
}
