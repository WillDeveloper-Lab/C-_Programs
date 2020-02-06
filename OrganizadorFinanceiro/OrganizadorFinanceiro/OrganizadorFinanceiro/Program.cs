using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizadorFinanceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("");
            Console.WriteLine("************Money Plus************");
            Console.WriteLine("*                                *");
            Console.WriteLine("*          Criando Conta:        *");
            Console.WriteLine("*                                *");
            Console.WriteLine("**********************************");
            Conta conta = new Conta();
            
            conta.Cadastrar();

            Console.ReadKey();
        }
    }
}
