using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Cliente:Pessoa 
    {
        int Id;
        float Salario;
        ContaCorrente Conta;

        public Cliente(int id, float salario, ContaCorrente conta, string Nome, string Telefone, Endereco endereco) : base(Nome, Telefone, endereco)
        {
            Id = id;
            Salario = salario;
            Conta = conta;
        }

    }
}
