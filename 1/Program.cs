using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        delegate double Del(double a);


        static void Main(string[] args)
        {
            Del radius = GetR;
            Console.Write("R = ");
            double rad = radius(Convert.ToDouble(Console.ReadLine()));

            Del diam = D;
            Console.WriteLine($"D = {Math.Round(diam(rad), 2)}");

            Del s = S;
            Console.WriteLine($"S = {Math.Round(s(rad), 2)}");

            Del v = V;
            Console.WriteLine($"V = {Math.Round(v(rad), 2)}");

            Console.ReadKey();
        }
        static double GetR(double r)
        {
            return r;
        }
        static double D(double r)
        {
            double d = 2 * Math.PI * r;
            return d;
        }
        static double S(double r)
        {
            double s = Math.PI * (r * r);
            return s;
        }
        static double V(double r)
        {
            double v  = (4 * Math.PI * (r * r * r))/3;
            return v;
        }

    }
}
