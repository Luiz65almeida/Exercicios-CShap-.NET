using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contagemDeVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
                String palavra = "Luiz Henrique";

                int contadorVogais = 0;

                for (int i = 0; i < palavra.Length; i++)
                {

                    Char vogais = palavra[i];

                    if ("AEIOUaeiou".IndexOf(vogais) != -1)
                    {
                        contadorVogais++;
                    }
                }

               Console.WriteLine("numero de vogais é: " + contadorVogais);
                Console.ReadLine();
            }
        }
    }
