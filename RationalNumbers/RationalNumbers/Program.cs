using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    class Program
    {
        

        static void Main(string[] args)
        {


            var rational1 = new Rational(1, 2);
            var rational2 = new Rational(1, 2);
            Console.WriteLine($"{rational1 == rational2} should be true");

            /*var rational1 = new Rational(1, 2);
            var rational2 = new Rational(3, 2);
            Console.WriteLine($"{rational1 < rational2} should be true");

            var rational1 = new Rational(1, 2);
            var rational2 = new Rational(1, 2);
            Console.WriteLine($"{rational1 + rational2} should be 1 instead of 1 / 1");
            */


        }
    }
}
