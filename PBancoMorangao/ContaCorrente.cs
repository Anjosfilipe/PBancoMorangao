using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class ContaCorrente
    {
        int IdConta, Senha;
        String Titular, TipoConta;
        float Limite, Saldo;
        Agencia Agencia;
        Pessoa Pessoa;
        long NumeroConta;
        PessoaFisica PessoaFisica;
        PessoaJuridica PessoaJuridica;



        public ContaCorrente(String titular, long NumeroConta, int Senha, String TipoConta, float limite, float Saldo, PessoaFisica pessoaf)
        {

            this.Titular = titular;
            this.NumeroConta = NumeroConta;
            this.Senha = Senha;
            this.TipoConta = TipoConta;
            this.Limite = limite;
            this.Saldo = Saldo;
            this.PessoaFisica = pessoaf;

        }
        public ContaCorrente(String titular, long NumeroConta, int Senha, String TipoConta, float limite, float Saldo, PessoaJuridica pessoaj)
        {

            this.Titular = titular;
            this.NumeroConta = NumeroConta;
            this.Senha = Senha;
            this.TipoConta = TipoConta;
            this.Limite = limite;
            this.Saldo = Saldo;
            this.PessoaJuridica = pessoaj;


        }
        public ContaCorrente(String titular, long NumeroConta, int Senha, String TipoConta, float limite, float Saldo)
        {

            this.Titular = titular;
            this.Senha = Senha;
            this.TipoConta = TipoConta;
            this.Limite = limite;
            this.Saldo = Saldo;


        }
        public void setIdConta(int Idconta)
        {

            this.IdConta = Idconta;

        }
        public void setTitular(string titular)
        {
            this.Titular = titular;
        }
        public void setSenha(int senha)
        {
            this.Senha = senha;
        }
        public void setTipoConta(string tipoConta)
        {
            this.TipoConta = tipoConta;
        }
        public void setLimite(float Limite)
        {
            this.Limite = Limite;
        }
        public void setSaldo(float Saldo)
        {
            this.Saldo = Saldo;
        }
        public void setAgencia(Agencia agencia)
        {
            this.Agencia = agencia;
        }
        public void setCliente(Pessoa pessoa)
        {
            this.Pessoa = pessoa;
        }
        public void setPessoaFisica(PessoaFisica pessoaf)
        {
            this.PessoaFisica = pessoaf;
        }
        public void setNumeroConta(long NumeroConta)
        {
            this.NumeroConta = NumeroConta;
        }
        public PessoaFisica getPessoaFisica()
        {
            return this.PessoaFisica;
        }
        public PessoaJuridica getPessoaJuridica()
        {
            return this.PessoaJuridica;
        }
        public int getSenha()
        {
            return this.Senha;
        }
        public long getConta()
        {
            return this.NumeroConta;
        }
        public float getLimite()
        {
            return this.Limite;
        }
        public float getSaldo()
        {
            return this.Saldo;
        }
        public string getTitular()
        {
            return this.Titular;
        }
        public long getNumeroConta()
        {
            return this.NumeroConta;
        }
        public float Saque(float valor)
        {
            float saldoAT = 0;

            if ((getSaldo() + getLimite()) < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                Console.ReadKey();
            }
            else
            {
                if (getSaldo() > valor)
                {
                    saldoAT = (getSaldo() - valor);
                    setSaldo(saldoAT);

                }
                else
                {
                    saldoAT = (getLimite() - (valor - getSaldo()));
                    setLimite(saldoAT);
                    setSaldo(0);

                }

                Console.WriteLine("Saldo atual: " + (getSaldo() + getLimite()));
            }
            return saldoAT;
        }

        public float Deposito(float valor)
        {
            float deposito = (getSaldo() + valor);

            setSaldo(deposito);
            Console.WriteLine("Deposito realizado com sucesso");
            Console.WriteLine("Saldo atual: " + (getSaldo() + getLimite()));
            Console.ReadKey();
            return deposito;
        }

        public void ConsultaSaldo()
        {
            Console.WriteLine("\nSaldo atual: " + (getSaldo() + getLimite()));
        }

        public void PagarConta(float valor)
        {
            Saque(valor);

        }

        public void Tranferir(float valor, List<ContaCorrente> listaCorrente)
        {
            Console.WriteLine("Digite a conta para a transferencia: ");
            int cc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da tansação");
            int vc = int.Parse(Console.ReadLine());
            foreach (ContaCorrente i in listaCorrente)
            {
                if (cc == i.getConta())
                {
                    i.Deposito(vc);
                }
                else
                {
                    Console.WriteLine(" Conta informa não existe ");
                }

            }
            Saque(vc);
        }

        public String SolicitarEmprestimo()
        {
            Console.WriteLine("Digite o valor que deseja de emprestimo: ");
            float valorEmprestimo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de parcelas desejadas: ");
            int parcelas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data de vencimento: ");
            string dataVencimento = Console.ReadLine();

            
            Console.WriteLine("\nProposta realizada com sucesso!");
            Console.WriteLine("\nAguarde a aprovação do gerente!");
            Console.ReadKey();

            return "\nTitular: " + getTitular() + "\nNumero da conta: " + getNumeroConta() + "\nValor desejado: " + valorEmprestimo + "\nNumero de parcelas: " + parcelas + "\nData de vencimento: " + dataVencimento;

        }

        public string imprimirContaCorrente()
        {
            return "\nID: " + IdConta + "\nTitular: " + Titular + "\nNumero da conta: " + this.NumeroConta + "\nSenha: " + Senha + "\nSaldo: " + Saldo + "\nLimite: " + Limite + "\nTipo da conta: " + TipoConta;
        }
    }
}
