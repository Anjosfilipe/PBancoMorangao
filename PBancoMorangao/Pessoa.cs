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
    public Pessoa(string Nome, string Telefone, Endereco endereco)
    {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Endereco = endereco;
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


        public void ImprimirPessoa()
        {
            Console.WriteLine("\nNome: " + Nome + "\n Telefone: " + Telefone + "\nEndereço: " + Endereco);
        }


    }

}
