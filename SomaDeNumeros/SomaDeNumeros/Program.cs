using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDeNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 5;

            int soma = 0;
            for (int i = 1; i <= n; i++)
            {

                soma = soma + i;

            }

            Console.WriteLine(soma);

            Console.ReadKey();
        }
    }
}
