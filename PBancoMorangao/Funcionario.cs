using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Funcionario : Pessoa
    {
        int IdFuncionario;
        Agencia Agencia;
        float Salario;


        public Funcionario(Agencia agencia, float salario, string Nome, string Telefone, Endereco endereco) : base(Nome, Telefone, endereco)
        {
            
            Agencia = agencia;
            Salario = salario;
        }

        public void setIdFuncionario()
        {
            IdFuncionario++;    
        }

        public void setAgencia()
        {
              
        }

        public override string ToString()
        {
            return base.ImprimirPessoa()+"\nId: "+IdFuncionario+"\nAgencia: "+Agencia+"\nSalario: "+Salario;
        }
    }

}
