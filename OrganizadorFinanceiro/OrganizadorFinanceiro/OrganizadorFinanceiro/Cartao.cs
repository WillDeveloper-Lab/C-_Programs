using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizadorFinanceiro
{
    class Cartao
    {
        public string apelido { get; set; }
        public double limite { get; protected set; }
        public double saldo { get; protected set; }
        public  double despesa {  get; private set; }
        public ArrayList extrato {  get;  set; }

        public void Cadastrar()
        {
            Console.Write("Digite um Apelido: ");
            this.apelido = Console.ReadLine();
            Console.Write("Digite Limite: ");
            this.limite = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite Saldo: ");
https://www.youtube.com/watch?v=Iy-dJwHVX84            this.saldo = Convert.ToDouble(Console.ReadLine());
        }

        public void AdicionarItemExtrato(double valor)
        {
            extrato.Add(valor);

        }
        public void LerExtrato()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*             EXTRATO            *");
            Console.WriteLine("**********************************");
            int count = 1;
            foreach (double valor in extrato)
            {
                Console.WriteLine(count+ " - " + valor);
                count++;
            }
            Console.WriteLine("**********************************");
        }
        public void ApagarItemExtrato(int index)
        {
            extrato.RemoveAt(index - 1);
        } 
        public void AlterarItemExtrato(int index, double novoValor)
        {
            extrato.Insert((index - 1), novoValor);
        }
        public void TotalDespesa()
        {
            foreach (double valor in extrato)
            {
                if(valor < 0)
                {
                    this.despesa += valor;
                }
            }
        }
    }
}
