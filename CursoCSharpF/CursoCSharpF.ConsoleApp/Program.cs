using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpF.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero:");
            int numeroHum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite um segundo numero:");
            int numeroDois = Convert.ToInt32(Console.ReadLine());

            int resultado = Soma(numeroHum, numeroDois);

            Console.WriteLine($"Resultado Soma: {resultado}");

            resultado = Multipli(numeroHum, numeroDois);

            Console.WriteLine($"Resultado Multiplicação: {resultado}");

            resultado = Subtracao(numeroHum, numeroDois);

            Console.WriteLine($"Resultado Subtracao: {resultado}");

            resultado = Divisao(numeroHum, numeroDois);

            Console.WriteLine($"Resultado Divisão: {resultado}");

            resultado = RestoDiv(numeroHum, numeroDois);

            Console.WriteLine($"Resto da divisão: {resultado}");

            Console.ReadLine();
        }

        static int Soma(int n1, int n2)
        {
            int resultadoSoma = n1 + n2;

            return resultadoSoma;

        }
        static int Multipli(int n1, int n2)
        {
            int resultadoMultipli = n1 * n2;

            return resultadoMultipli;
        }
        static int Subtracao(int n1, int n2)
        {
            int resultadoSubtracao = n1 - n2;

            return resultadoSubtracao;
        }
        static int Divisao(int n1, int n2)
        {
            int resultadoDivisao = n1 / n2;

            return resultadoDivisao;
        }
        static int RestoDiv(int n1, int n2)
        {
            int RestoDiv = n1 % n2;

            return RestoDiv;
        }
    }
}
