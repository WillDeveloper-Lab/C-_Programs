using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
                Boolean teste = false;
                while(teste == false) { 
                   Console.Write("Digite seu NOME: ");
                   string nome = Console.ReadLine();
                    if (nome.Length >= 3)
                       teste = true;
                    else
                       Console.WriteLine("Erro - Seu nome tem menos de 3 caracaters ");
                }
                teste = false;
                while (teste == false)
                {
                    Console.Write("Digite sua IDADE: ");
                    int idade = Convert.ToInt32(Console.ReadLine());
                    if (idade >= 0 && idade <= 150)
                        teste = true;
                    else
                        Console.WriteLine("Erro sua idade não esta entre 0 e 150 ");
                }
                teste = false;
                while (teste == false)
                {
                    Console.Write("Digite o seu SALARIO: ");
                    double salario = Convert.ToDouble(Console.ReadLine());
                    if (salario >= 0)
                        teste = true;
                    else
                        Console.WriteLine("Erro seu salario é menor ou igual a zero ");
                }
                teste = false;
                while (teste == false)
                {
                    Console.Write("Digite seu GENERO(F OR M): ");
                    char genero = Convert.ToChar(Console.ReadLine());
                    genero = char.ToLower(genero);
                    if (genero == 'f' || genero == 'm')
                        teste = true;
                    else
                        Console.WriteLine("Erro genero invalido ");
                }
                teste = false;
                while (teste == false)
                {
                    Console.Write("Digite seu ESTADO CIVIL(S,C,V,D): ");
                    char estado = Convert.ToChar(Console.ReadLine());
                    estado = char.ToLower(estado);
                    if (estado == 's' || estado == 'c' || estado == 'v' || estado == 'd' )
                        teste = true;
                    else
                        Console.WriteLine("Erro seu estado civil n existe");
                }
            Console.ReadKey();   
        }
    }
}
