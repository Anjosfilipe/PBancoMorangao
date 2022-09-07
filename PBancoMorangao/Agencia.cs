using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Agencia
    {
        int IdAgencia;
        String Nome;
        Endereco Endereco;
        

        public Agencia(string nome, Endereco endereco)
        {

            this.Nome = nome;
            this.Endereco = endereco;

        }


        public override string ToString()
        {
            return "IdAgencia: "+IdAgencia+"\nNome da Agencia: " + Nome + "\nEndereço: " + Endereco;
        }
    }
}
