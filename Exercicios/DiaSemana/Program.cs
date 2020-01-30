using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero do dia da semana: ");
            int num = Convert.ToInt32(Console.ReadLine());
       
            switch (num)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
            }
            Console.ReadKey();
        }
    }
}
