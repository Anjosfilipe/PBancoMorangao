using System;
using System.Collections.Generic;

namespace PBancoMorangao
{
    internal class Program
    {
        static Endereco ColetaDadosEndereco()
        {
            Console.WriteLine("Digite o CEP atual: ");
            String cep = Console.ReadLine();
            Console.WriteLine("Digite o Estado que reside atualmente: ");
            String estado = Console.ReadLine();
            Console.WriteLine("Digite a Cidade que reside atualmente: ");
            String cidade = Console.ReadLine();
            Console.WriteLine("Digite o Bairro que reside atualmente: ");
            String bairro = Console.ReadLine();
            Console.WriteLine("Digite o Logradouro atual: ");
            String logradouro = Console.ReadLine();
            Console.WriteLine("Digite o numero da residencia atual: ");
            String numero = Console.ReadLine();

            return new Endereco(cep, logradouro, numero, cidade, estado, bairro);

        }
        static PessoaFisica ColetarDadosPF()
        {
            Console.WriteLine("Para podemos criar sua conta em nosso banco.Necessitamos de seus dados pessoais para uma PROPOSTA DE APROVAÇÃO!");
            Console.WriteLine("Nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Digite o numero de seu Cpf: ");
            String Cpf = Console.ReadLine();
            Console.WriteLine("Digite a Data de Nascimento: ");
            DateTime datanascimento = DateTime.Parse(Console.ReadLine());
            Endereco endereco = ColetaDadosEndereco();
            Console.WriteLine("Digite seu numero de Telefone: ");
            String Telefone = Console.ReadLine();
            Console.WriteLine("Digite o valor de seu salario: ");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu Sexo: ");
            String sexo = Console.ReadLine();

            return new PessoaFisica(sexo, Cpf, datanascimento, nome, Telefone, salario, endereco);
        }
        static PessoaJuridica ColetarDadosPJ()
        {
            Console.WriteLine("Para podemos criar sua conta em nosso banco.Necessitamos de seus dados pessoais para uma PROPOSTA DE APROVAÇÃO!");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Razão social:");
            String razaosocial = Console.ReadLine();
            Console.WriteLine("Digite o numero do Cnpj: ");
            String Cnpj = Console.ReadLine();
            Console.WriteLine("Digite o nome Fantasia: ");
            String nomefantasia = Console.ReadLine();
            Endereco endereco = ColetaDadosEndereco();
            Console.WriteLine("Digite seu numero de Telefone: ");
            string Telefone = Console.ReadLine();
            Console.WriteLine("Digite o redimento atual da empresa: ");
            float salario = float.Parse(Console.ReadLine());

            return new PessoaJuridica(Cnpj, razaosocial, nomefantasia, salario, nome, Telefone, endereco);
        }
        static Funcionario ColetarDadosFuncionario()
        {
            Console.WriteLine("Nome do funcionario : ");
            string nome = Console.ReadLine();
            Endereco endereco = ColetaDadosEndereco();
            Console.WriteLine("Digite o numero de Telefone: ");
            string Telefone = Console.ReadLine();
            Console.WriteLine("Digite o valor do salário: ");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome da Agencia que ele faz parte: ");
            string nomeAgencia = Console.ReadLine();
            Agencia agencia = new Agencia(nomeAgencia, endereco);

            return new Funcionario(agencia, salario, nome, Telefone, endereco);

        }

        static ContaCorrente ColetarDadosConta()
        {
            Console.WriteLine("Informe o nome do Titular da Conta:");
            String Titular = Console.ReadLine();
            Console.WriteLine("Informe uma senha para a Conta:");
            String Senha = Console.ReadLine();
            Console.WriteLine("Informe o tipo de conta:");
            String TipoConta = Console.ReadLine();
            Console.WriteLine("informe o valor de Cheque Especial desejado para a conta:");
            float limite = float.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor saldo atual da conta:");
            float saldo = float.Parse(Console.ReadLine());

            return new ContaCorrente(Titular, Senha, TipoConta, limite, saldo);
        }
        static void MenuIncial()
        {
            int opc;
            List<PessoaFisica> listaPF = new List<PessoaFisica>();
            List<PessoaJuridica> listaJuridica = new List<PessoaJuridica>();
            //List<ContaCorrente> listaCorrente = new List<ContaCorrente>();

            do
            {

                Console.Clear();
                Console.WriteLine("----------------------------- MENU INICIAL ------------------------");
                Console.WriteLine("|                                                                 |");
                Console.WriteLine("|          - Bem vindo ao banco Morangão  -                       |");
                Console.WriteLine("|           Digite a opcão desejada:                              |");
                Console.WriteLine("|           1 - Desejo me tornar Cliente                          |");
                Console.WriteLine("|           2 - Sou Cliente                                       |");
                Console.WriteLine("|           3 - Sou funcionario                                   |");
                Console.WriteLine("|           0 - Para sair                                         |");
                Console.WriteLine("|                                                                 |");
                Console.WriteLine("-------------------------------------------------------------------");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\nEstamos felizes em saber que deseja se tornar membro de nossa Familia! ");
                        Console.WriteLine("\nPorém antes de mais nada, necessitamos de alguns dados basicos.");
                        Console.WriteLine("\nPrimeiramente precisamos saber se você deseja criar uma conta PF ou PJ.");
                        Console.WriteLine("\nSelecione a Opção desejada:");
                        Console.WriteLine(" 1 - Solicitar conta para Pessoa Física ");
                        Console.WriteLine(" 2 - Solicitar conta para Pessoa Jurídica ");
                        int opcC = int.Parse(Console.ReadLine());
                        do
                        {

                            if (opcC == 1)
                            {
                                Console.Clear();
                                PessoaFisica pf = ColetarDadosPF();
                                listaPF.Add(pf);
                                int solicitaAberturaC = pf.AbrirConta();// gerente necessita ler essa variavel para comprovar a conta 
                                Console.Clear();
                                Console.WriteLine("\t\t\t -------------- Proposta realizada com SUCESSO!  ------------------  ");
                                Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                Console.ReadKey();

                                if (solicitaAberturaC == 1)
                                {
                                    int solicitaTipoCF = pf.SolicitarTipoConta(); // gerente necessita ler essa variavel para comprovar a conta 
                                    Console.WriteLine(pf.ImprimirPessoaFisica()); // visualiza o meu cliente PF cadastrado 
                                    Console.WriteLine(" Tecle ENTER para voltar ao menu inicar ");
                                    Console.ReadKey();

                                }
                                else if (solicitaAberturaC == 2)
                                {
                                    Console.WriteLine("O banco moragão agradece o atendimento. voltaremos para o menu INICIAL ");

                                }


                            }
                            if (opcC == 2)
                            {
                                Console.Clear();
                                PessoaJuridica pj = ColetarDadosPJ();
                                listaJuridica.Add(pj);
                                int solicitaAberturaCJ = pj.AbrirConta();
                                Console.Clear();
                                Console.WriteLine("\t\t\t -------------- Proposta realizada com SUCESSO!  ------------------  ");
                                if (solicitaAberturaCJ == 1)
                                {
                                    int solicitaTipoCJ = pj.SolicitarTipoConta(); // gerente necessita ler essa variavel para comprovar a conta 
                                    Console.WriteLine(pj.ImprimirPessoaJuridica()); // visualiza o meu cliente PJ cadastrado 
                                    Console.WriteLine(" Tecle ENTER para voltar ao menu inicar ");
                                    Console.ReadKey();

                                }
                                else if (solicitaAberturaCJ == 2)
                                {
                                    Console.WriteLine("O banco moragão agradece o atendimento. voltaremos para o menu INICIAL ");

                                }
                            }
                        } while (opcC != 1 && opcC != 2);

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

                        if (opcF == 1)
                        {
                            Console.Clear();
                            Funcionario funcionario = ColetarDadosFuncionario();
                            Console.Clear();
                            Console.WriteLine("Cadastro Realizado com SUCESSO!");
                            Console.WriteLine("Estamos felizes em saber que temos mais um membro em nossa Familia! ");
                            Console.WriteLine(funcionario.ToString()); // visualiza meu gerente cadastrado 
                            Console.WriteLine(" Tecle ENTER para voltar ao menu inicar ");
                            Console.ReadKey();

                        }
                        else
                        {
                            if (opcF == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Bem vindo ao painel do GERENTE");
                                Console.WriteLine("\nDigite a Opção que desejada: ");
                                Console.WriteLine("1 - Criar nova Conta ");
                                Console.WriteLine("2 - Altorizar Emprestimo");
                                Console.WriteLine("3 - Voltar ao Menu INICIAL");
                                int opcG = int.Parse(Console.ReadLine());

                                if (opcG == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(">>> LISTA DE PF PARA CRIAR CONTA <<<");
                                    listaPF.ForEach(i => Console.WriteLine(i.ImprimirPessoaFisica()));
                                    Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine(">>> LISTA DE PJ PARA CRIAR CONTA <<<");
                                    listaJuridica.ForEach(i => Console.WriteLine(i.ImprimirPessoaJuridica()));
                                    //ContaCorrente conta = ColetarDadosConta();
                                    //conta.setPessoaFisica();
                                    Console.WriteLine(" Tecle ENTER para voltar ao menu inicar ");
                                    Console.ReadKey();


                                }
                                else if (opcG == 2)
                                {
                                    Console.WriteLine(" Não fez ainda pai bora a neh!!!!  ");
                                    Console.WriteLine(" Tecle ENTER para voltar ao menu inicar ");
                                    Console.ReadKey();

                                }
                                else
                                {
                                    Console.ReadKey();

                                }

                            }

                        }

                        break;
                }
            } while (opc != 0);
        }




        static void Main(string[] args)
        {
            MenuIncial();

        }
    }
}
