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



        public ContaCorrente(String titular, long NumeroConta, String Senha, String TipoConta, float limite, float Saldo, PessoaFisica pessoaf)
        {

            this.Titular = titular;
            this.NumeroConta = NumeroConta;
            this.Senha = Senha;
            this.TipoConta = TipoConta;
            this.Limite = limite;
            this.Saldo = Saldo;
            this.PessoaFisica = pessoaf;
            this.IdConta  = this.IdConta++;


        }
        public ContaCorrente(String titular, long NumeroConta, String Senha, String TipoConta, float limite, float Saldo, PessoaJuridica pessoaj)
        {

            this.Titular = titular;
            this.NumeroConta = NumeroConta;
            this.Senha = Senha;
            this.TipoConta = TipoConta;
            this.Limite = limite;
            this.Saldo = Saldo;
            this.PessoaJuridica = pessoaj;
            this.IdConta = this.IdConta++;


        }

        public ContaCorrente(String titular, long NumeroConta, String Senha, String TipoConta, float limite, float Saldo)
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


        public string imprimirContaCorrente()
        {
            return "\nID: " + IdConta + "\nTitular: " + Titular + "\nNumero da conta: " + this.NumeroConta + "\nSenha: " + Senha + "\nSaldo: " + Saldo + "\nLimite: " + Limite + "\nTipo da conta: " + TipoConta;
        }


    }
}
