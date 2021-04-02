using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            //O int é um tipo de variavel  que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é um tipo variavel de 64 bit
            long idade = 13000000000000;
            Console.WriteLine(idade);

            //o short é um tipo de variavel de 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);
            
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
