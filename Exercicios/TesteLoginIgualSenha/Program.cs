using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLoginIgualSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean passa = false;
            while (passa == false)
            {
                Console.WriteLine("***Cadastro de Usuario****");
                Console.Write("Digite um nome de Usuario: ");
                string usuario = Console.ReadLine();
                Console.Write("Digite uma senha: ");
                string senha = Console.ReadLine();
                Console.WriteLine("");

                if (usuario == senha)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Erro 6969 - Usuario e Senha iguais.");
                    Console.WriteLine("Por favor tente novamente.");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Cadastro efetuado com sucesso");
                    passa = true;
                }
            }
            Console.ReadKey();
        }
    }
}
