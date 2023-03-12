using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCsharp
{
    public class Calculo
    {
        public double Resultado;
        public double ValorA;
        public double ValorB;

        public double CalcularSoma()
        {
            double Soma = ValorA + ValorB;
            return Soma;
        }
        public double CalcularSubtracao()
        {
            double Subtracao = ValorA - ValorB;
            return Subtracao;
        }
        public double CalcularMultiplicacao()
        {
            double Multiplicacao = ValorA * ValorB;
            return Multiplicacao;
        }
        public double RetornarMaior()
        {
            return Math.Max(ValorA, ValorB);
        }

        public double SomarGeral(double valor = 0)
        {

            Resultado = ValorA + ValorB + valor;
            return Resultado;
        }
        public void ImprimirResultado(int i)
        {
            double soma = CalcularSoma();
            double subtracao = CalcularSubtracao();
            double multiplicacao = CalcularMultiplicacao();


            switch (i)
            {
                case 1:
                    Console.Write($"Resultado Final {soma}");
                    break;
                case 2:
                    Console.Write($"Resultado Final {subtracao}");
                    break;
                case 3:
                    Console.Write($"Resultado Final {multiplicacao}");
                    break;

            }

        }

        public void pegarValA(double valora)
        {
            ValorA = valora;
        }
        public void pegarValB(double valorb)
        {
            ValorB = valorb;
        }
    }
}
