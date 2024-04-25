using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Paula ";
            string sobrenome = "Toller";
            //Console.WriteLine(string.Concat(nome, sobrenome));
            string nomeCompleto = $"{nome}{sobrenome}";
            Console.WriteLine(nomeCompleto);
            int posicao = nomeCompleto.IndexOf("T");
            //Pegar o sobrenome
            string nomeFinal = nomeCompleto.Substring(posicao);
            Console.WriteLine(nomeFinal);
            Console.WriteLine(nomeFinal.ToUpper());
            Console.WriteLine(nomeFinal.ToLower());

            
        

        }
    }
}
