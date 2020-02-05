using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoante
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letras = new char[] {'a','b','c','d','e','f','g','h','i','j'};
            char[] vogais = new char[] {'a','e','i','o','u'};
            int i, j;
            int count = 0;
            Console.Write("Consoantes-> {");
            for (i = 0; i < 10; i++)
            {
                if (letras[i] != 'a' || letras[i] != 'e' || letras[i] != 'i' || letras[i] != 'o' || letras[i] != 'u')
                 {
                     Console.Write(letras[i] + " ");
                     count++;
                    
                 }
                /*  for (j = 0; j < 5; j++)
                 {
                     if (vogais[j].Equals(letras[i]))
                     {
                         Console.Write(letras[i] + " ");
                         count++;
                         break;
                     }
                 }*/
            }
            Console.Write("}");
            Console.WriteLine("Quantidade de Consoantes: " + count);
            Console.ReadKey();
        }
    }
}
