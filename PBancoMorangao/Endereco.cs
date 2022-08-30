using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Endereco
    {
        String Cep, Logradouro, Numero, Cidade, Estado, Bairro;
        

        public Endereco(string cep, string logradouro, string numero, string cidade, string estado, string bairro)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Bairro = bairro;
        }

        public void setCep(string cep)
        {
            this.Cep = cep;
        }
        public void setLogradouro(string logradouro)
        {
            this.Logradouro = logradouro;
        }
        public void setNumero(string numero )
        {
            this.Numero = numero;
        }
        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }
        public void setEstado(string estado)
        {
            this.Estado = estado;
        }
        public void setBairro(string bairro)
        {
            this.Bairro = bairro;
        }

        public override string ToString()
        {
            return "\nEstado: "+Estado+"\nCidade: "+Cidade+ "\nBairro: "+Bairro+"\nCep: "+Cep+"\nLogradouro: "+Logradouro+"\nNumero: "+Numero;
        }
    }
}
