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
            Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t  --- Para podemos criar sua conta em nosso banco.Necessitamos de seus dados pessoais para uma PROPOSTA DE APROVAÇÃO!");
            Console.Write("\n\t\t\t\t\t\t\tNome: ");
            string nome = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tRazão social:");
            String razaosocial = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite o numero do Cnpj: ");
            String Cnpj = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite o nome Fantasia: ");
            String nomefantasia = Console.ReadLine();
            Endereco endereco = ColetaDadosEndereco();
            Console.Write("\n\t\t\t\t\t\t\tDigite seu numero de Telefone: ");
            string Telefone = Console.ReadLine();
            Console.Write("\n\t\t\t\t\t\t\tDigite o redimento atual da empresa: ");
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
        static Agencia ColetarDadosAgencia()
        {
            Console.Write("\n\t\t\t\t\t\t\tNome da Agencia: ");
            string nome = Console.ReadLine();
            Endereco endereco = ColetaDadosEndereco();

            return new Agencia(nome, endereco);
        }
        static ContaCorrente ColetarDadosContapf(PessoaFisica pessoaf)
        {

            Console.WriteLine("\n >>> DADOS PARA CRIAÇÃO DE CONTA <<<  ");
            Console.Write("\nInforme o nome do Titular da Conta: ");
            String Titular = Console.ReadLine();
            Console.Write("\nInforme o numero da Conta: ");
            long conta = long.Parse(Console.ReadLine());
            Console.Write("\nInforme uma senha para a Conta: ");
            int Senha = int.Parse(Console.ReadLine());
            Console.Write("\nInforme o tipo de conta: ");
            String TipoConta = Console.ReadLine();
            Console.Write("\ninforme o valor de Cheque Especial desejado para a conta: ");
            float limite = float.Parse(Console.ReadLine());
            Console.Write("\ninforme o valor saldo atual da conta:");
            float saldo = float.Parse(Console.ReadLine());

            return new ContaCorrente(Titular, conta, Senha, TipoConta, limite, saldo, pessoaf);
        }
        static ContaCorrente ColetarDadosContapj(PessoaJuridica pessoaj)
        {
            Console.WriteLine("\n  >>> DADOS PARA CRIAÇÃO DE CONTA <<< ");
            Console.Write("\nInforme o nome do Titular da Conta:");
            String Titular = Console.ReadLine();
            Console.Write("\nInforme o numero da Conta:");
            long conta = long.Parse(Console.ReadLine());
            Console.Write("\nInforme uma senha para a Conta:");
            int Senha = int.Parse(Console.ReadLine());
            Console.Write("\nInforme o tipo de conta:");
            String TipoConta = Console.ReadLine();
            Console.Write("\ninforme o valor de Cheque Especial desejado para a conta:");
            float limite = float.Parse(Console.ReadLine());
            Console.Write("\ninforme o valor saldo atual da conta:");
            float saldo = float.Parse(Console.ReadLine());

            return new ContaCorrente(Titular, conta, Senha, TipoConta, limite, saldo, pessoaj);
        }
        static void MenuCliente()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                                Seja Bem Vindo!                                            $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                           - Digite a Opção desejada -                                     $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                           0 -  SAIR                                                       $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                           1 -  SAQUE                                                      $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                           2 -  DEPOSITO                                                   $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                           3 -  TRANSFERENCIA                                              $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                           4 -  EXTRATO                                                    $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                           5 -  CONSULTAR lIMITE (Cartão de credito)                       $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                           6 -  CONSULTAR SALDO                                            $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                           7 -  REALIZAR PAGAMENTOS                                        $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                           8 -  SOLICITAR EMPRESTIMO                                       $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
            Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");

        }
        static void TelaInicial()
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

        }
        static void TelaPFPJ()
        {
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
        }
        static void MenuIncial()
        {
            int opc;
            List<PessoaFisica> listaPF = new List<PessoaFisica>();
            List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();
            List<ContaCorrente> listaCorrente = new List<ContaCorrente>();
            List<Agencia> listaAgencia = new List<Agencia>();
            List<string> emprestimo = new List<string>();
            List<float> extrato = new();

            do
            {
                TelaInicial();
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: // rodando perfeitamenteeee 
                        TelaPFPJ();
                        int opcC = int.Parse(Console.ReadLine());
                        do
                        {
                            if (opcC == 1)
                            {
                                Console.Clear();
                                PessoaFisica pf = ColetarDadosPF();
                                listaPF.Add(pf);
                                int solicitaAberturaC = pf.AbrirConta();
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n");
                                Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                                Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                                Console.WriteLine("\t\t\t\t\t\t\t\t$               -------------- Proposta realizada com SUCESSO!  ------------------          $");
                                Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                                Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                                Console.WriteLine("\t\t\t\t\t\t\t\t$                -------------- TECLE ENTER PARA CONTINUAR!  ------------------             $");
                                Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                                Console.ReadKey();

                                if (solicitaAberturaC == 1)
                                {
                                    int tipoconta = pf.SolicitarTipoConta();
                                    pf.setTipoConta(tipoconta);
                                    Console.WriteLine(pf.ImprimirPessoaFisica());
                                    Console.WriteLine("\t\t\t\t\t\t\t\t --------- Tecle ENTER para voltar ao menu iniciar  --------------- ");
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
                                listaPJ.Add(pj);
                                int solicitaAberturaCJ = pj.AbrirConta();
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n");
                                Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                                Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                                Console.WriteLine("\t\t\t\t\t\t\t\t$               -------------- Proposta realizada com SUCESSO!  ------------------          $");
                                Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                                Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                                Console.WriteLine("\t\t\t\t\t\t\t\t$                -------------- TECLE ENTER PARA CONTINUAR!  ------------------             $");
                                Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                                Console.ReadKey();

                                if (solicitaAberturaCJ == 1)
                                {
                                    int solicitaTipoCJ = pj.SolicitarTipoConta();
                                    pj.setTipoConta(solicitaTipoCJ);
                                    Console.WriteLine(pj.ImprimirPessoaJuridica());
                                    Console.WriteLine(" Tecle ENTER para voltar ao menu iniciar ");
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
                        if (listaCorrente.Count == 0)
                        {
                            Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------------------------------------------------");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$              - NÃO ENCONTRAMOS SUA CONTA.  -                    $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$              - FAÇA O CADASTRO DA MESMA  -                      $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                        -  OU -                                  $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$              - INFORME NOVAMENTE OD DADOS  -                    $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------------------------------------------------");
                            Console.WriteLine("\t\t\t\t\t\t\t\t --------- Tecle ENTER para voltar ao menu iniciar  --------------- ");
                            Console.ReadKey();
                        }
                        else
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
                            Console.WriteLine("\t\t\t\t\t\t\t\t$              - DIGITE O NUMERO DA CONTA:  -                     $");
                            long contaD = int.Parse(Console.ReadLine());
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$              - DIGITE A SENHA:    -                             $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------------------------------------------------");
                            int senhaD = int.Parse(Console.ReadLine());
                            foreach (ContaCorrente i in listaCorrente)
                            {
                                if (contaD == i.getConta() && (senhaD == i.getSenha()))
                                {
                                    ContaCorrente contaI = i;
                                    int stop = 0;
                                    do
                                    {

                                        MenuCliente();
                                        int opcCL = int.Parse(Console.ReadLine());
                                        switch (opcCL)
                                        {
                                            case 0:
                                                stop = 1;
                                                break;
                                            case 1:
                                                Console.Write("\nDigite o valor que deseja sacar: ");
                                                float valor = float.Parse(Console.ReadLine());
                                                contaI.Saque(valor);
                                                //extrato.Add()
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                Console.Write("\nDigite o valor que deseja Depositar: ");
                                                float deposito = float.Parse(Console.ReadLine());
                                                contaI.Deposito(deposito);
                                                //extrato.Add();
                                                Console.ReadKey();
                                                break;
                                            case 3:
                                                Console.Write("\nDigite o valor que deseja Transferir: ");
                                                float transferir = float.Parse(Console.ReadLine());
                                                contaI.Tranferir(transferir, listaCorrente);
                                                break;
                                            case 4:

                                                Console.ReadKey();
                                                break;
                                            case 5:
                                                Console.WriteLine("\t\t\t\t\t\t\t\t --------- Tecle ENTER para voltar ao menu iniciar  --------------- ");
                                                Console.ReadKey();
                                                break;
                                            case 6:
                                                contaI.ConsultaSaldo();
                                                Console.ReadKey();
                                                break;
                                            case 7:
                                                Console.WriteLine("\nDigite o codigo de pagamento: ");
                                                float conta = float.Parse(Console.ReadLine());
                                                Console.WriteLine("\nDigite o valor da Conta: ");
                                                float valorConta = float.Parse(Console.ReadLine());
                                                contaI.PagarConta(valorConta);
                                                Console.ReadKey();
                                                break;
                                            case 8:
                                                string solicitacao = contaI.SolicitarEmprestimo();
                                                emprestimo.Add(solicitacao);
                                                Console.ReadKey();
                                                break;
                                        }
                                    } while (stop != 1);

                                }
                                else
                                {
                                    Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------------------------------------------------");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$              - NÃO ENCONTRAMOS SUA CONTA.  -                    $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$              - FAÇA O CADASTRO DA MESMA  -                      $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$                        -  OU -                                  $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$              - INFORME NOVAMENTE OD DADOS  -                    $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------------------------------------------------");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t --------- Tecle ENTER para voltar ao menu iniciar  --------------- ");
                                    Console.ReadKey();

                                }

                            }
                        }
                        break;
                    case 3:

                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                                 Bem vindo de volta!                                       $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                             Digite a Opção que desejada:                                  $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                             1 - Acessar o painel de Gerente                               $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                             2 - Voltar ao Menu INICIAL                                    $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                        Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                        int opcF = int.Parse(Console.ReadLine());

                        if (opcF == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                            Bem vindo ao painel do GERENTE                                 $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                            Digite a Opção que desejada:                                   $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                            1 - Criar nova Conta                                           $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                            2 - Altorizar Emprestimo                                       $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                            3 - Criar nova Agencia                                         $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                            4 - Voltar ao Menu INICIAL                                     $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                            Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                            int opcG = int.Parse(Console.ReadLine());
                            switch (opcG)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(">>> LISTA DE PF PARA CRIAR CONTA <<<");
                                    listaPF.ForEach(i => Console.WriteLine(i.ImprimirPessoaFisica())); // lambda

                                    // ------------------------------------------ imprimi todos pf pendenetes

                                    Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                    Console.ReadKey();


                                    foreach (PessoaFisica i in listaPF)
                                    {
                                        Console.WriteLine("\n\n\n\n\t\t\t -------------- CRIE A CONTA E VINCULE AO CLIENTE!  ------------------  ");
                                        ContaCorrente conta = ColetarDadosContapf(i);

                                        listaCorrente.Add(conta);
                                        Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                    }

                                    listaPF.Clear();

                                    Console.WriteLine(">>> LISTA DE PJ PARA CRIAR CONTA <<<");
                                    listaPJ.ForEach(i => Console.WriteLine(i.ImprimirPessoaJuridica()));

                                    // ------------------------------------------ imprimi todos pj pendenetes
                                    Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                    Console.ReadKey();

                                    foreach (PessoaJuridica i in listaPJ)
                                    {
                                        Console.WriteLine("\n\n\n\n\t\t\t -------------- CRIE A CONTA E VINCULE AO CLINETE!  ------------------  ");
                                        ContaCorrente conta = ColetarDadosContapj(i);
                                        Console.WriteLine("\n\n\n\n\t\t\t -------------- TECLE ENTER PARA CONTINUAR!  ------------------  ");
                                        listaCorrente.Add(conta);

                                    }

                                    listaPJ.Clear();

                                    Console.WriteLine(" Tecle ENTER para voltar ao menu inicar ");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine(">>> LISTA DE EMPRESTIMOS PARA CRIAR LIBERAÇÃO <<<");
                                    emprestimo.ForEach(i => Console.WriteLine(i.ToString()));

                                    Console.WriteLine(" >>  Digite a opição desejada << ");
                                    Console.WriteLine(" 1 - Liberar emprestimo ");
                                    Console.WriteLine(" 2 - Recusar emprestimo ");
                                    int opcE = int.Parse(Console.ReadLine());

                                    if (opcE == 1)
                                    {
                                        Console.WriteLine("Digite a conta do cliente: ");
                                        int cc = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite o valor a ser liberado");
                                        int vc = int.Parse(Console.ReadLine());
                                        foreach (ContaCorrente i in listaCorrente)
                                        {
                                            if (cc == i.getConta())
                                            {
                                                i.Deposito(vc);
                                            }
                                        }
                                    }
                                    else if (opcE == 2)
                                    {
                                        Console.WriteLine("Emprestimo negado.");
                                        Console.ReadLine();
                                        break;
                                    }
                                    break;
                                case 3:
                                    Agencia agencia = ColetarDadosAgencia();
                                    listaAgencia.Add(agencia);
                                    Console.WriteLine("\n\n\n\n\n");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$               -------------- Cadastro realizado com SUCESSO!  ------------------          $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                                           $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t$                -------------- TECLE ENTER PARA CONTINUAR!  ------------------             $");
                                    Console.WriteLine("\t\t\t\t\t\t\t\t---------------------------------------------------------------------------------------------");
                                    listaAgencia.ForEach(i => Console.WriteLine(i.ToString()));
                                    Console.ReadKey();
                                    break;

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
