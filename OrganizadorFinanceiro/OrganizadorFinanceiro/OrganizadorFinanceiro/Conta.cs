using System;
using System.Collections;
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
        public ArrayList cartoes { get; set; }
        public double saldoAcumulado{ get; private set;}
        public double despesas{ get; private set; }

        public Conta()
        {
            cliente = new Cliente();
            cartoes = new ArrayList();
            //cartoes.Add(new Cartao());
        }
        public void Cadastrar()
        {
          
            Console.Write("Digite um Usuario: ");
            this.usuario = Console.ReadLine();
            Console.Write("Digite uma Senha: ");
            this.senha = Console.ReadLine();
            cliente.Cadastrar();
            this.Menu();
        }
        public void Menu()
        {
           
            Console.WriteLine("**********************************");
            Console.WriteLine("*            Money Plus          *");
            Console.WriteLine("**********************************");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("**********************************");
            Console.WriteLine("* 1-Adicionar  2-Alterar  3-Sair *");
            Console.WriteLine("**********************************");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    this.Adiciona();
                    break;
                case 2:

                    break;
                case 3:
                    Console.WriteLine("Obrigado por usar nossa aplicação");
                    Environment.Exit(1);
                    break;
            }
        }
        public void Adiciona()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*           Adicionar            *");
            Console.WriteLine("**********************************");
            Console.WriteLine("*  1-Cartão  2-Renda  3-Despesa  *");
            Console.WriteLine("*  4-Voltar                      *");
            Console.WriteLine("**********************************");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    this.Cartao();
                    break;
                case 2:

                    break;
                case 3:
                   
                    break;
                case 4:
                    this.Menu();
                    break;
            }
        }
        public void Cartao()
        {

        }

    }
}
