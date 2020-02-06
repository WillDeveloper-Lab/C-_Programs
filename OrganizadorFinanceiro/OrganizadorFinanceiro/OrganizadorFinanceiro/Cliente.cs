using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizadorFinanceiro
{
    class Cliente
    {
        public long cpf { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public int telefone { get; set; }
        public int dataNascimento { get; set; }
        public double salario { get; set; }
        
        public void Cadastrar()
        {
            Console.Write("Digite seu Nome: ");
            this.nome = Console.ReadLine();
            Console.Write("Digite seu CPF: ");
            this.cpf = Convert.ToInt64(Console.ReadLine());
            Console.Write("Digite o seu E-mail: ");
            this.email = Console.ReadLine();
            Console.Write("Digite seu Telefone: ");
            this.telefone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite sua Data de Nascimento: ");
            this.dataNascimento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o seu Salario: ");
            this.salario = Convert.ToDouble(Console.ReadLine());
        }
    }
}
