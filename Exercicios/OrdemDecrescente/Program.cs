using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Digite um numero para A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um numero para B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um numero para C: ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine($" ordem = {a},{b},{c}");
            }
            else if (a > c && c > b)
            {
                Console.WriteLine($" ordem = {a},{c},{b}");
            }
            else if (b > a && a > c)
            {
                Console.WriteLine($" ordem = {b},{a},{c}");
            }
            else if (b> c && c > a)
            {
                Console.WriteLine($" ordem = {b},{c},{a}");
            }
            else if (c > a && a > b)
            {
                Console.WriteLine($" ordem = {c},{a},{b}");
            }
            else
            {
                Console.WriteLine($" ordem = {c},{b},{a}");
            }
            Console.ReadKey();
        }
    }
}
