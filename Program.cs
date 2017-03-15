using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gittest
{
    class Program
    {
        static void Main(string[] args)
        {
            m1();
            m2();
            Console.ReadKey();
        }

        static void m1()
        {
            Console.WriteLine("feature 1 with feature 2 changes");
            Console.WriteLine("feature 1 bugfix");
        }

        static void m2()
        {
            Console.WriteLine("feature 2 c1 c2");
        }
    }
}
