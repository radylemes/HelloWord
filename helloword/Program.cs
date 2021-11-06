using System;

namespace helloword
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFilme, sala, hora, data;

            Console.WriteLine("Digite o nome do Filme: ");
            nomeFilme = Console.ReadLine();

            Console.WriteLine("Digite a sala: ");
            sala = Console.ReadLine();

            Console.WriteLine("Qual a hora do Filme: ");
            hora = Console.ReadLine();

            Console.WriteLine("Data: ");
            data = Console.ReadLine();

            Console.WriteLine($"Seu ingresso para o filme {nomeFilme}, sala {sala} no dia {data} às {hora}");
        }
    }
}
