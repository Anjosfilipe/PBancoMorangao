using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class ContaCorrente
    {
        int IdConta;
        String Titular, Senha, TipoConta;
        float Limite, Saldo;
        Agencia Agencia;
        Pessoa Pessoa;
        long NumeroConta;
        PessoaFisica PessoaFisica;
        PessoaJuridica PessoaJuridica;

        public ContaCorrente(String titular,long NumeroConta, String Senha, String TipoConta, float limite, float Saldo, PessoaFisica pessoaf)
        {

            this.Titular = titular;
            this.Senha = Senha;
            this.TipoConta = TipoConta;
            this.Limite = limite;
            this.Saldo = Saldo;
            this.PessoaFisica = pessoaf;
            

        }
        public ContaCorrente(String titular, long NumeroConta, String Senha, String TipoConta, float limite, float Saldo, PessoaJuridica pessoaj)
        {

            this.Titular = titular;
            this.Senha = Senha;
            this.TipoConta = TipoConta;
            this.Limite = limite;
            this.Saldo = Saldo;
            this.PessoaJuridica = pessoaj;


        }

        public ContaCorrente(String titular, long NumeroConta, String Senha, String TipoConta, float limite, float Saldo)
        {

            this.Titular = titular;
            this.Senha = Senha;
            this.TipoConta = TipoConta;
            this.Limite = limite;
            this.Saldo = Saldo;


        }

        public void setIdConta(Random rand)
        {
            this.IdConta = rand.Next(0, 100);

        }

        public void setTitular(string titular)
        {
            this.Titular = titular;
        }

        public void setSenha(string senha)
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
            this.Pessoa= pessoa;
        }

        public void setPessoaFisica(PessoaFisica pessoaf)
        {
            this.PessoaFisica = pessoaf;
        }

        public void setNumeroConta(long NumeroConta)
        {
            this.NumeroConta = NumeroConta;
        }

        public String ImprimirContaCorrente()
        {
            return  "\nTipo da conta: " + this.TipoConta + "\nNumero da conta: " + this.NumeroConta + "\nSenha: "+this.Senha +"\nCliente: " + this.PessoaFisica;
        }

    }
}
