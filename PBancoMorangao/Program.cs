using System;

namespace PBancoMorangao
{
    internal class Program
    {
        static Endereco ColetaDadosEndereco()
        {
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

            return new Endereco(cep, logradouro, numero, cidade, estado, bairro);

        }
        static Cliente ColetarDadosCliente()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Endereco endereco = ColetaDadosEndereco();
            Console.WriteLine("Digite seu numero de Telefone: ");
            string Telefone = Console.ReadLine();
            Console.WriteLine("Digite o valor de seu salário: ");
            float salario = float.Parse(Console.ReadLine());

            return new Cliente(salario, nome, Telefone, endereco);
        }

        static Funcionario ColetarDadosFuncionario()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Endereco endereco = ColetaDadosEndereco();
            Console.WriteLine("Digite seu numero de Telefone: ");
            string Telefone = Console.ReadLine();
            Console.WriteLine("Digite o valor de seu salário: ");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome da Agencia que ele faz parte: ");
            string nomeAgencia = Console.ReadLine();
            Agencia agencia = new Agencia(nomeAgencia, endereco);

            return new Funcionario(agencia, salario,nome,Telefone,endereco);

        }
        static void MenuIncial()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao banco Morangão");
            Console.WriteLine("Digite a opcão desejada: ");
            Console.WriteLine("1 - Desejo me tornar Cliente");
            Console.WriteLine("2 - Sou Cliente");
            Console.WriteLine("3 - Sou funcionario");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Estamos felizes em saber que deseja se tornar membro de nossa Familia! ");
                    Console.WriteLine("Porém antes de mais nada necessitamos de alguns dados basicos.");
                    Cliente cliente = ColetarDadosCliente();
                    int solicitaAberturaC = cliente.AbrirConta();
                    if (solicitaAberturaC == 1)
                    {
                        int solicitaTipoC = cliente.SolicitarTipoConta(); // gerente necessita ler essa variavel para comprovar a conta 
                        Console.WriteLine(cliente.ToString()); // visualiza o meu cliente cadastrado 
                        Console.WriteLine(" Tecle ENTER para voltar ao menu inicar ");
                        Console.ReadKey();
                        MenuIncial();
                    }
                    else
                    {
                        Console.WriteLine("O banco moragão agradece o atendimento. voltaremos para o menu INICIAL ");
                        MenuIncial();
                    }
                    break;
                case 2:
                    Console.WriteLine("Terminar essa função ainda PAI. bora la negao");
                    break;

                case 3:

                    Console.Clear();
                    Console.WriteLine("Bem vindo de volta!");
                    Console.WriteLine("Digite a Opção que desejada: ");
                    Console.WriteLine("1 - Cadastrar novo Gerente ");
                    Console.WriteLine("2 - Acessar o painel de Gerente ");
                    Console.WriteLine("3 - Voltar ao Menu INICIAL");
                    int opcF = int.Parse(Console.ReadLine());

                    if(opcF == 1)
                    {
                        Console.Clear();
                        Funcionario funcionario = ColetarDadosFuncionario();
                        Console.Clear();
                        Console.WriteLine("Cadastro Realizado com SUCESSO!");
                        Console.WriteLine("Estamos felizes em saber que temos mais um membro em nossa Familia! ");
                        Console.WriteLine(funcionario.ToString()); // visualiza meu gerente cadastrado 
                        Console.WriteLine(" Tecle ENTER para voltar ao menu inicar ");
                        Console.ReadKey();
                        MenuIncial();
                    }
                    else
                    {
                        if(opcF == 2 )
                        {

                        }

                    }

                    break;
            }

        }
        static void Main(string[] args)
        {

            MenuIncial();



            //pessoa.ImprimirPessoa();
            //Console.WriteLine(pessoa.getNome());

            //Cliente cliente = new Cliente();

            //cliente.SolicitarTipoConta();
            //cliente.SolicitarEmprestimo();

        }
    }
}
