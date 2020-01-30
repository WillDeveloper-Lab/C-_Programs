using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
              double salario;
              double novoSalario = 0;
              int percentual = 0;
              double aumento = 0;

              Console.WriteLine("Digite o valor do seu salário: ");
              salario = Convert.ToDouble(Console.ReadLine());

              if(salario <= 280)
              {
                  percentual = 20;
                  aumento = salario * (percentual / 100.0);
                  novoSalario = salario + aumento;
              }else if (salario >280 && salario <=700)
              {
                  percentual = 15;
                  aumento = salario * (percentual / 100.0);
                  novoSalario = salario + aumento;
              }else if(salario >700 && salario <= 1500)
              {
                  percentual = 10;
                  aumento = salario * (percentual / 100.0);
                  novoSalario = salario + aumento;
              }else if(salario > 1500){
                  percentual = 5;
                  aumento = salario * (percentual / 100.0);
                  novoSalario = salario + aumento;
              }
              Console.WriteLine(" - Seu Salario Atual: R$" + salario);
              Console.WriteLine(" - O percentual de aumento é: " + percentual);
              Console.WriteLine(" - Seu aumento é de: R$" + aumento);
              Console.WriteLine(" - Seu novo Salario: R$" + novoSalario);
              Console.ReadKey();
        }
    }
}
