using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            double horasTrabalhadas;
            double valorHora;
            double fgts = 0;
            double sindicato = 0;
            double salarioBruto;
            double inss = 0;
            double ir = 0;
            double salarioLiquido = 0;
            Console.Write("Quantas horas você trabalha por mes: ");
            horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor da sua hora: ");
            valorHora = Convert.ToDouble(Console.ReadLine());

            salarioBruto = horasTrabalhadas * valorHora;
            if (salarioBruto <= 900)
            {
                ir = 0;
                inss = salarioBruto * 0.1;
                fgts = salarioBruto * 0.11;
                sindicato = salarioBruto * 0.03;
                salarioLiquido = salarioBruto - (inss + ir);
            } else if (salarioBruto > 900 && salarioBruto <= 1500)
            {
                ir = 0;
                inss = salarioBruto * 0.05;
                fgts = salarioBruto * 0.11;
                sindicato = salarioBruto * 0.03;
                salarioLiquido = salarioBruto - (inss + ir);
            } else if (salarioBruto > 1500 & salarioBruto <= 2500)
            {
                ir = 0.1;
                inss = salarioBruto * 0.1;
                fgts = salarioBruto * 0.11;
                sindicato = salarioBruto * 0.03;
                salarioLiquido = salarioBruto - (inss + ir);
            }else if(salarioBruto > 2500){
                ir = 0.2;
                inss = salarioBruto * 0.1;
                fgts = salarioBruto * 0.11;
                sindicato = salarioBruto * 0.03;
                salarioLiquido = salarioBruto - (inss + ir);
            }

            Console.WriteLine("+ Salario Bruto: " + salarioBruto);
            Console.WriteLine("- Imposto de renda: " + ir);
            Console.WriteLine("- INSS: " + inss);
            Console.WriteLine("  FGTS: " + fgts);
            Console.WriteLine("  Sindicato: " + sindicato);
            Console.WriteLine("= Salario Liquido: " + salarioLiquido);
            Console.ReadKey();
        }
    }
}
