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
            Console.WriteLine("======= Cadastro de Pessoa ==========");

            Console.Write("Escreva o nome: ");
            string primeiroNome = Console.ReadLine();

            Console.Write("Escreva o sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Escreva sua idade: ");
            int idade = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("=====================================");

            Console.WriteLine("Seu nome é: " + primeiroNome + " Sobrenome: " + sobrenome + " Idade: " + idade);
            Console.WriteLine($"Seu nome é: {primeiroNome} Sobrenome: {sobrenome} Idade: {idade}");

            Console.ReadLine();
        }
    }
}
