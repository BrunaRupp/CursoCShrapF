using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Loja de Bebidas************");
            Console.WriteLine("Seja bem vindo a sua loja de bebidas!!!!");

            List<string> listaClientes = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                string nC = CadastrarCliente();
                listaClientes.Add(nC);
            }

            //Como ordenar por ordem alfabética: listaClientes = listaClientes.OrderBy(i=>i).ToList();
            //Para comentar código : Selcionar as linhas e pressionar Ctrl + K+ C e Para desfazer comentários: Ctrl + K; Ctrl + U.
            //Para ocultar/apagar texto: Ctrl + L.

            foreach (string item in listaClientes)
            {
                Console.WriteLine($"Nome: {item} !");
            }
            
            Console.ReadKey();

        }
        static string CadastrarCliente()
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = $"{nome} {sobrenome}";
            return nomeCompleto;
        }
    }
}
