using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 5;
            for(int i = fatorial -1; i>=1; i--)
            {
                fatorial *= i;
                Console.WriteLine(fatorial);
            }
            Console.ReadKey();
        }
    }
}
