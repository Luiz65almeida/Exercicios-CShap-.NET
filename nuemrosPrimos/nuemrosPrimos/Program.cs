using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuemrosPrimos
{

    internal class Program
    {

        static void Main(string[] args)
        {

            int number = 27;

            if (EhPrimo(number))
            {
                Console.WriteLine("O Número " + number + " é um número primo!");
            }
            else
            {
                Console.WriteLine("O Número " + number + " não é um número primo!");
            }

            Console.ReadKey();
        }

        static bool EhPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}