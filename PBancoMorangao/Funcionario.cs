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


        public Funcionario(int Idfuncionario, Agencia agencia, float salario, string Nome, string Telefone, Endereco endereco) : base(Nome, Telefone, endereco)
        {
            IdFuncionario = Idfuncionario;
            Agencia = agencia;
            Salario = salario;
        }
    }

}
