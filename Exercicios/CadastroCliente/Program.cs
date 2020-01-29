using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente will = new Cliente();

            Console.WriteLine("**************************************");
            Console.WriteLine("          Iniciando Cadastro          ");
            Console.WriteLine("**************************************");
            Console.WriteLine("Digite o seu CPF: ");
            will.cpf = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Digite o seu RG: ");
            will.rg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o seu Nome: ");
            will.nome = Console.ReadLine();
            Console.WriteLine("Digite seu numero de Telefone: ");
            will.telefone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************");
            Console.WriteLine("            Imprimindo Dados          ");
            Console.WriteLine("**************************************");
            Console.WriteLine("CPF: " + will.cpf);
            Console.WriteLine("RG: " + will.rg);
            Console.WriteLine("Nome: " + will.nome);
            Console.WriteLine("Telefone: " + will.telefone);
            Console.WriteLine("**************************************");

            Console.ReadKey();
        }
    }
}
