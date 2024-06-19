using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversaoDeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String palavra = "Bala";

            //Opção alternativa
            String palavaInvertida = String.Concat(palavra.Reverse());

            Console.WriteLine(palavra.Reverse().ToArray());

            Console.ReadLine();
        }
    }
}
