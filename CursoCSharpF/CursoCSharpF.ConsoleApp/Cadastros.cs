﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpF.ConsoleApp
{
    class Cadastros
    {
        public static string CadastroPessoa()
        {
            // Ctrl+K+C: Transforma em texto
            //cw+tab+tab: Escreve Console.writeLine
            Console.WriteLine("======= Cadastro de Pessoa ==========");

            Console.Write("Escreva o nome: ");
            string primeiroNome = Console.ReadLine();
            Console.Write("Escreva o sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.Write("Escreva sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=====================================");

            // Imprimindo com concatenação
            // Console.WriteLine("Seu nome é: " + primeiroNome + " Sobrenome: " + sobrenome + " Idade: " + idade);
            // Imprimindo com interpolação de strings
            // Console.WriteLine($"Seu nome é: {primeiroNome} Sobrenome: {sobrenome} Idade: {idade}");
            string pessoa = $"Seu nome é: {primeiroNome} Sobrenome: {sobrenome} Idade: {idade}";

            return pessoa;
        }
    }
}
