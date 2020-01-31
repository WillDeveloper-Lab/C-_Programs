using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;
            Console.Write("Digite o primeiro lado do triangulo: ");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo lado do triangulo: ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o terceiro lado do triangulo: ");
            lado3 = Convert.ToDouble(Console.ReadLine());
            // erro na lógica quando n formar um triangulo

            if ((lado2 - lado3 < lado1) && (lado1 < lado2 + lado3) && (lado1 - lado3 < lado2) && (lado2 < lado1 + lado3) && (lado1 - lado2 < lado3) && (lado3 < lado1 + lado2))
            {
                Console.WriteLine("Os lados não formam um triangulo!!!");
            }
            /*else if(lado1 == lado2 && lado1== lado3)
            {
                Console.WriteLine("Seus lados formam um Triangulo EQUILÁTERO");
            }else if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Seus lados formam um Triangulo ISÓSCELES");
            }
            else{
                Console.WriteLine("Seus lados formam um Triangulo ESCALENO");
            }*/
            Console.ReadKey();
        }
    }
}
