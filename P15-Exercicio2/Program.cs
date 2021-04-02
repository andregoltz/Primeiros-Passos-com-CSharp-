using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 15 - Exercícios 2");

            for (int contador = 1; contador <= 100; contador++)
            {
                if (contador % 3 == 0)
                {
                    Console.WriteLine(contador);
                }
            }

            Console.ReadLine();
        }
    }
}
