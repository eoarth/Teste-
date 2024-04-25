using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nomePessoa = Console.ReadLine();

            Console.Write("Qual é a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Meu nome é  " + nomePessoa + " e minha idade é " + idade);
        }
    }
}
