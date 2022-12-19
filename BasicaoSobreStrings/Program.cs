using System;

namespace BasicaoSobreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            string nome_completo;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();

            nome_completo = nome + " " + sobrenome;
            Console.WriteLine("Olá " + nome_completo);
            Console.WriteLine("Seu nome tem " + nome.Length + " caracteres");
            Console.WriteLine("Olá " + nome.ToUpper()     );
            Console.WriteLine("Olá " + nome.ToLower()     );
            Console.WriteLine("Olá " + nome_completo.ToUpper() );

            string fragmento = nome_completo.Substring(3, 3);
            Console.WriteLine("Fragmento = {0} " ,fragmento);

            Console.ReadKey(); //pausa;...
        }
    }
}
