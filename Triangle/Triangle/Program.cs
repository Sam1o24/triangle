using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader tr;
            StreamWriter sw;
            try
            {
                 tr = new StreamReader("in.txt");
                 sw = new StreamWriter("out.txt");
            }
            catch 
            {
                Console.WriteLine("Не найдены файлы");
                return;
            }

            while (!tr.EndOfStream)
            {
                string S;
                S = tr.ReadLine();
                S = S.Trim();        //удаление пробелов в начале и в конце 

                string[] Mas_S = S.Split(';');

                double a = Convert.ToDouble(Mas_S[0]);
                double b = Convert.ToDouble(Mas_S[1]);
                double alpha = Convert.ToDouble(Mas_S[2]) * Math.PI/180;

                double c = Math.Sqrt(a*a + b*b - 2*a*b*Math.Cos(alpha));
                Console.WriteLine("c = {0}", c);

                double beta = Math.Acos((b*b + c*c - a*a)/(2*b*c));
                Console.WriteLine("beta = {0}", beta * 180 / Math.PI);

                double gamm = 180 - alpha * 180 / Math.PI - beta * 180 / Math.PI;
                Console.WriteLine("gamm = {0}", gamm);

                sw.Write("{0};{1};{2}",a,b,c);
            }
            sw.Close();
            tr.Close();
        }
    }
}
