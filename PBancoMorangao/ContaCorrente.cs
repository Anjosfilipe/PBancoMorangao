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
        float Limite,Saldo;
        Agencia agencia;
        Cliente cliente;

        public ContaCorrente(String titular, String Senha, String TipoConta, float limite, float Saldo, Agencia agencia, Cliente cliente)
        {
           
            this.Titular = titular;
            this.Senha = Senha;
            this.TipoConta = TipoConta;
            this.Limite = limite;
            this.Saldo = Saldo;

        }

        public String getContaCorrente()
        {
            return "\nId conta: "+this.IdConta+"Tipo da conta: "+this.TipoConta+"Cliente: "+this.cliente;
        }

    }
}
