using System;

namespace PBancoMorangao
{
    internal class Program
    {
        static Pessoa ColetarDadosPessoa()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite os dados solicitados a baixo");
            Console.WriteLine("Digite o CEP atual: ");
            string cep = Console.ReadLine();
            Console.WriteLine("Digite o estado que mora atualmente: ");
            string estado = Console.ReadLine();
            Console.WriteLine("Digite a cidade que mora atualmente: ");
            string cidade = Console.ReadLine();
            Console.WriteLine("Digite o bairro que mora atualmente: ");
            string bairro = Console.ReadLine();
            Console.WriteLine("Digite o Logradouro atual: ");
            string logradouro = Console.ReadLine();
            Console.WriteLine("Digite o numero da residencia atual: ");
            string numero = Console.ReadLine();
            Endereco endereco = new Endereco(cep, logradouro, numero, cidade, estado, bairro);
            Console.WriteLine("Digite seu numero de Telefone: ");
            string Telefone = Console.ReadLine();

            return new Pessoa(nome, Telefone, endereco);
        }

        static void Main(string[] args)
        {
            Pessoa pessoa = ColetarDadosPessoa();
            pessoa.ImprimirPessoa();

        }
    }
}
