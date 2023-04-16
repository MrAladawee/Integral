using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    internal class Function
    {
        //private int a, b;
        //public int A { get { return a; } set { a = value; } }
        //public int B { get { return b; } set { b = value; } }
        //Decarts p;

        public double minY, maxY, minX, maxX;
        public string functionIntegral;

        public Function(double minX = -10, double maxX = 10, double minY = -10, double maxY = 10, string FunctionIntegral = "cos")
        {
            this.minY = minY;
            this.maxY = maxY;
            this.minX = minX;
            this.maxX = maxX;
            this.functionIntegral = FunctionIntegral;
        }

        public double func(double x)
        {
            if (this.functionIntegral == "cos")
            {
                return Math.Cos(x);
            }
            else if (this.functionIntegral == "sin")
            {
                return Math.Sin(x);
            }
            else if (this.functionIntegral == "x**2")
            {
                return Math.Pow(x, 2);
            }
            else
            {
                return Math.Sin(x * 3 - 5) - 1;
            }
        }

        public Decarts point(double x)
        {
            return new Decarts(x, func(x));
        }

    }
}
