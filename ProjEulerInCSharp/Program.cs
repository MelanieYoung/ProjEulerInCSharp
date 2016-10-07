using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEulerInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Problems1To10 results1to10 = new Problems1To10();
            results1to10.Problem1();
            results1to10.Problem2();
            results1to10.Problem3();
            results1to10.Problem4();
            results1to10.Problem5();
            results1to10.Problem6();
            results1to10.Problem7();
            results1to10.Problem8();
            results1to10.Problem9();
            //results1to10.Problem10();
            Console.ReadKey();
        }
    }
}
