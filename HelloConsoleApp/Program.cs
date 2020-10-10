using System;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {
            String nome;
            int idade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o sua idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Bem vindo "+ nome + " !");

            if (idade >= 18)
                Console.WriteLine("você é maior de idade !");
            else
                Console.WriteLine("você é maior de idade !");

        }
    }
}
   