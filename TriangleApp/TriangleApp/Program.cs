using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr;
            StreamWriter sw;
            try
            {
                sr = new StreamReader("in.txt");
                sw = new StreamWriter("out.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Не найдены файлы");
                return;
            }

            Triangle tr = new Triangle();

            while (!sr.EndOfStream)
            {
                string S;
                S = sr.ReadLine();
                S = S.Trim();

                string[] Mas_S = S.Split(';');

                try
                {
                    tr.A = Convert.ToDouble(Mas_S[0]);
                    tr.B = Convert.ToDouble(Mas_S[1]);
                    tr.Alpha = tr.ToRad(Convert.ToDouble(Mas_S[2]));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Ошибка ввода");
                    //sw.WriteLine("Ошибка ввода");
                    continue;
                }
                Console.WriteLine("beta = {0} gamma = {1}", tr.ToGrad(tr.beta), tr.ToGrad(tr.gamma));

                if ((tr.A == 0) || (tr.B == 0) || (tr.c == 0))
                {
                    sw.WriteLine("Error");
                    continue;
                }
                if (tr.Alpha == 0 || tr.beta == 0 || tr.gamma == 0)
                {
                    sw.WriteLine("Error");
                    continue;
                }
                sw.WriteLine("{0};{1};{2}", tr.A, tr.B, tr.c);
            }
            sw.Close();
            sr.Close();

        }
    }
}
