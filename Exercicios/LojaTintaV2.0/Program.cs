using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaTintaV2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double lataG = 18;
            double valorG = 80;
            double lataP = 3.6;
            double valorP = 25;

            Console.WriteLine("Digite a area a ser pintada(m2)");
            area = Convert.ToDouble(Console.ReadLine());
            double litroTinta = area / 6;
            Console.WriteLine("Litros de tinta usado será de: " + litroTinta);
            double qtdLatas = Math.Ceiling(litroTinta / lataG);
            Console.WriteLine("Valor gasto apenas com latas grandes: " + (valorG * qtdLatas));
            qtdLatas = Math.Ceiling(litroTinta / lataP);
            Console.WriteLine("valor gasto apenas com latas grandes: " + (valorP * qtdLatas));
            Console.ReadKey();
        }
    }
}
