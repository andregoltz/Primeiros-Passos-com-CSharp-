using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12 - Calcula Investimento Longo Prazo");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5 ; contadorAno++)
            {
                for (int ContadorMes = 1; ContadorMes <= 12; ContadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("Ano = " + contadorAno + " Mes = " + ContadorMes + " Valor Investido = " + valorInvestido);
                }
                fatorRendimento += 0.0010;
               
            }

           // Console.WriteLine("Ao término do rendimento, você terá R$" + valorInvestido);
            Console.ReadLine();
        }
    }
}
