using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleApp
{
    public class Triangle
    {
        public double a, b;

        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; }
        }

        public double A
        {
            get { return a; }
            set { if (value > 0) a = value; }
        }
        private double alpha;

        public double Alpha
        {
            get { return alpha; }
            set { if (value > 0 && value < 180) alpha = value; }
        }

        public double c
        {
            get { return Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(alpha)); }
        }

        public double beta
        {
            get { return Math.Acos((b * b + c * c - a * a) / (2 * b * c)); }
        }

        public double gamma
        {
            get { return ToRad(180 - ToGrad(alpha) - ToGrad(beta)); }
        }

        public double ToRad(double grad)
        {
            return grad * Math.PI / 180;
        }

        public double ToGrad(double rad)
        {
            return rad * 180 / Math.PI;
        }

        public Triangle()
        {
            
        }
    }
}
