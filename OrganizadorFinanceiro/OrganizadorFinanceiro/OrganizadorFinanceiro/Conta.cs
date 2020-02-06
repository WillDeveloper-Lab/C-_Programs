using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizadorFinanceiro
{
    class Conta
    {
        public string usuario { get; set; }
        public string senha { get; set; }
        public Cliente cliente;
        public Cartao[] cartoes { get; set; }

        public Conta()
        {
            cliente = new Cliente();
        }
        public void Cadastrar()
        {
          
            Console.Write("Digite um Usuario: ");
            this.usuario = Console.ReadLine();
            Console.Write("Digite uma Senha: ");
            this.senha = Console.ReadLine();
            cliente.Cadastrar();
        }


    }
}
