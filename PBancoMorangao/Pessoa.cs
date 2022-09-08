using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Pessoa
    {
      
        String Nome, Telefone;
        Endereco Endereco;
        float Salario;
        ContaCorrente Conta;

        public Pessoa(string Nome, string Telefone, float salario, Endereco endereco)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Endereco = new Endereco(endereco.Cep, endereco.Logradouro, endereco.Cidade, endereco.Cidade, endereco.Estado, endereco.Bairro);
            this.Salario = salario;

        }

     

        public void setSalario(float salario)
        {
            this.Salario = salario;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        public void setEndereco(Endereco Endereco)
        {
            this.Endereco = Endereco;

        }
        public void setConta(ContaCorrente conta)
        {
            this.Conta = conta;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public string ImprimirPessoa()
        {
            return "\nNome: " + Nome + "\nTelefone: " + Telefone + Endereco.ToString() + "\nRenda: " + Salario + "\nTipo de conta: " + Conta;
        }


    }

}
