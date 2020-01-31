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
        /*Faça um Programa que peça os 3 lados de um triângulo. O programa deverá informar se os valores podem ser um triângulo. Indique, caso os lados formem um triângulo, se o mesmo é: equilátero, isósceles ou escaleno.
        Dicas:
            Três lados formam um triângulo quando a soma de quaisquer dois lados for maior que o terceiro;
            Triângulo Equilátero: três lados iguais;
            Triângulo Isósceles: quaisquer dois lados iguais;
            Triângulo Escaleno: três lados diferentes
          */
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
