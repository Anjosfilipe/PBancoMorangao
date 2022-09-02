using System;
using System.Collections.Generic;

namespace PBancoMorangao
{
    internal class Program
    {
        static Endereco ColetaDadosEndereco()
        {
            Console.Write("\n\t\t\t\t\t\t\tDigite o CEP atual: ");
            String cep = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite o Estado que reside atualmente: ");
            String estado = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite a Cidade que reside atualmente: ");
            String cidade = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite o Bairro que reside atualmente: ");
            String bairro = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite o Logradouro atual: ");
            String logradouro = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite o numero da residencia atual: ");
            String numero = Console.ReadLine();

            return new Endereco(cep, logradouro, numero, cidade, estado, bairro);

        }
        static PessoaFisica ColetarDadosPF()
        {
            Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t  --- Para podemos criar sua CONTA em nosso banco. Necessitamos de seus DADOS PESSOAIS para uma PROPOSTA DE APROVAÇÃO!");
            Console.Write("\n\t\t\t\t\t\t\tNome: ");
            String nome = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite o numero de seu Cpf: ");
            String Cpf = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite a Data de Nascimento: ");
            DateTime datanascimento = DateTime.Parse(Console.ReadLine());
            Endereco endereco = ColetaDadosEndereco();
            Console.Write("\n\t\t\t\t\t\t\tDigite seu numero de Telefone: ");
            String Telefone = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite o valor de seu salario: ");
            float salario = float.Parse(Console.ReadLine());
            Console.Write("\n\t\t\t\t\t\t\tDigite seu Sexo: ");
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

        static ContaCorrente ColetarDadosContapf(PessoaFisica pessoaf)
        {
            Console.WriteLine("Informe o nome do Titular da Conta:");
            String Titular = Console.ReadLine();
            Console.WriteLine("Informe o numero da Conta:");
            long conta = long.Parse(Console.ReadLine());
            Console.WriteLine("Informe uma senha para a Conta:");
            String Senha = Console.ReadLine();
            Console.WriteLine("Informe o tipo de conta:");
            String TipoConta = Console.ReadLine();
            Console.WriteLine("informe o valor de Cheque Especial desejado para a conta:");
            float limite = float.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor saldo atual da conta:");
            float saldo = float.Parse(Console.ReadLine());

            return new ContaCorrente(Titular,conta, Senha, TipoConta, limite, saldo, pessoaf);
        }
        static ContaCorrente ColetarDadosContapj(PessoaJuridica pessoaj)
        {
            Console.WriteLine("Informe o nome do Titular da Conta:");
            String Titular = Console.ReadLine();
            Console.WriteLine("Informe o numero da Conta:");
            long conta = long.Parse(Console.ReadLine());
            Console.WriteLine("Informe uma senha para a Conta:");
            String Senha = Console.ReadLine();
            Console.WriteLine("Informe o tipo de conta:");
            String TipoConta = Console.ReadLine();
            Console.WriteLine("informe o valor de Cheque Especial desejado para a conta:");
            float limite = float.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor saldo atual da conta:");
            float saldo = float.Parse(Console.ReadLine());

            return new ContaCorrente(Titular, conta, Senha, TipoConta, limite, saldo, pessoaj);
        }
        static void MenuIncial()
        {
            int opc;
            List<PessoaFisica> listaPF = new List<PessoaFisica>();
            List<PessoaJuridica> listaJuridica = new List<PessoaJuridica>();
            List<ContaCorrente> listaCorrente = new List<ContaCorrente>();

            do
            {

                Console.Clear();
                Console.WriteLine(@" 
                                 _______    ______   __    __   ______    ______         __       __   ______   _______    ______   __    __   ______    ______    ______  
                                /       \  /      \ /  \  /  | /      \  /      \       /  \     /  | /      \ /       \  /      \ /  \  /  | /      \  /      \  /      \ 
                                $$$$$$$  |/$$$$$$  |$$  \ $$ |/$$$$$$  |/$$$$$$  |      $$  \   /$$ |/$$$$$$  |$$$$$$$  |/$$$$$$  |$$  \ $$ |/$$$$$$  |/$$$$$$  |/$$$$$$  |
                                $$ |__$$ |$$ |__$$ |$$$  \$$ |$$ |  $$/ $$ |  $$ |      $$$  \ /$$$ |$$ |  $$ |$$ |__$$ |$$ |__$$ |$$$  \$$ |$$ | _$$/ $$ |__$$ |$$ |  $$ |
                                $$    $$< $$    $$ |$$$$  $$ |$$ |      $$ |  $$ |      $$$$  /$$$$ |$$ |  $$ |$$    $$< $$    $$ |$$$$  $$ |$$ |/    |$$    $$ |$$ |  $$ |
                                $$$$$$$  |$$$$$$$$ |$$ $$ $$ |$$ |   __ $$ |  $$ |      $$ $$ $$/$$ |$$ |  $$ |$$$$$$$  |$$$$$$$$ |$$ $$ $$ |$$ |$$$$ |$$$$$$$$ |$$ |  $$ |
                                $$ |__$$ |$$ |  $$ |$$ |$$$$ |$$ \__/  |$$ \__$$ |      $$ |$$$/ $$ |$$ \__$$ |$$ |  $$ |$$ |  $$ |$$ |$$$$ |$$ \__$$ |$$ |  $$ |$$ \__$$ |
                                $$    $$/ $$ |  $$ |$$ | $$$ |$$    $$/ $$    $$/       $$ | $/  $$ |$$    $$/ $$ |  $$ |$$ |  $$ |$$ | $$$ |$$    $$/ $$ |  $$ |$$    $$/ 
                                $$$$$$$/  $$/   $$/ $$/   $$/  $$$$$$/   $$$$$$/        $$/      $$/  $$$$$$/  $$/   $$/ $$/   $$/ $$/   $$/  $$$$$$/  $$/   $$/  $$$$$$/  
                                                                                                                                           
                                                                                                                                           
                                                                                                                                      ");
                Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------------------------------------------------");
                Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                Console.WriteLine("\t\t\t\t\t\t\t\t$              -  Bem vindo ao banco Morangão  -                  $");
                Console.WriteLine("\t\t\t\t\t\t\t\t$                   Digite a opcão desejada:                      $");
                Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                Console.WriteLine("\t\t\t\t\t\t\t\t$           1 - Desejo me tornar Cliente                          $");
                Console.WriteLine("\t\t\t\t\t\t\t\t$           2 - Sou Cliente                                       $");
                Console.WriteLine("\t\t\t\t\t\t\t\t$           3 - Sou funcionario                                   $");
                Console.WriteLine("\t\t\t\t\t\t\t\t$           0 - Para sair                                         $");
                Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                Console.WriteLine("\t\t\t\t\t\t\t\t___________________________________________________________________");
                Console.SetCursorPosition(60, 50);
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: // rodando perfeitamenteeee 
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n");
                        Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$       °Estamos felizes em saber que deseja se tornar membro de nossa Familia!             $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$       °Porém antes de mais nada, necessitamos de alguns dados basicos.                    $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$       °Primeiramente precisamos saber se você deseja criar uma conta  - PF -  ou  - PJ -  $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                             Selecione a Opção desejada:                                   $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                     1 - Solicitar conta para Pessoa Física                                $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                     2 - Solicitar conta para Pessoa Jurídica                              $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t_____________________________________________________________________________________________");
                        Console.SetCursorPosition(70, 20);
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
                                    int tipoconta = pf.SolicitarTipoConta();
                                    pf.setTipoConta(tipoconta);
                                    Console.WriteLine(pf.ImprimirPessoaFisica());
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
                                Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                Console.ReadKey();

                                if (solicitaAberturaCJ == 1)
                                {
                                    int solicitaTipoCJ = pj.SolicitarTipoConta(); // gerente necessita ler essa variavel para comprovar a conta 
                                    pj.setTipoConta(solicitaTipoCJ);
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
                        Console.WriteLine("1 - Acessar o painel de Gerente ");
                        Console.WriteLine("2 - Voltar ao Menu INICIAL");
                        int opcF = int.Parse(Console.ReadLine());

                        if (opcF == 1)
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
                                // ------------------------------------------ imprimi todos pf pendenetes
                                Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                Console.ReadKey();
                              

                                foreach (PessoaFisica pessoaFisica in listaPF)
                                {
                                    Console.WriteLine("\n\n\n\n\t\t\t -------------- CRIE A CONTA E VINCULE AO CLINETE!  ------------------  ");
                                    ContaCorrente conta = ColetarDadosContapf(pessoaFisica);
                                    Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                    listaCorrente.Add(conta);
                                }

                                listaCorrente.ForEach(i => Console.WriteLine(i.ImprimirContaCorrente()));
                                Console.WriteLine("\n\n\n\n\t\t\t -------------- Ta dando certo!  ------------------  ");
                                Console.ReadKey();


                                Console.WriteLine(">>> LISTA DE PJ PARA CRIAR CONTA <<<");
                                listaJuridica.ForEach(i => Console.WriteLine(i.ImprimirPessoaJuridica()));

                                // ------------------------------------------ imprimi todos pj pendenetes
                                Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                Console.ReadKey();

                                foreach (PessoaJuridica pessoaJuridica in listaJuridica)
                                {
                                    Console.WriteLine("\n\n\n\n\t\t\t -------------- CRIE A CONTA E VINCULE AO CLINETE!  ------------------  ");
                                    ContaCorrente conta = ColetarDadosContapj(pessoaJuridica);
                                    Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                    listaCorrente.Add(conta);
                                }

                                listaCorrente.ForEach(i => Console.WriteLine(i.ImprimirContaCorrente()));
                                Console.WriteLine("\n\n\n\n\t\t\t -------------- Ta dando certo!  ------------------  ");
                                Console.ReadKey();

                                Console.WriteLine(" Tecle ENTER para voltar ao menu inicar ");
                                Console.ReadKey();
                            }
                            else if (opcG == 2)
                            {
                                Console.WriteLine(" Não fez ainda pai bora a neh!!!!  ");
                                Console.WriteLine(" Tecle ENTER para voltar ao menu inicar ");
                                Console.ReadKey();
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
