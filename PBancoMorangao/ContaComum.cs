using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class ContaComum : ContaCorrente
    {
        String Profissao, NomeEmpresa;
        float Renda;

        public ContaComum(string profissao, string nomeempresa, float salario, String titular, long NumeroConta, int Senha, String TipoConta, float limite, float Saldo, PessoaFisica pessoaf) : base(titular, NumeroConta, Senha, TipoConta, limite, Saldo, pessoaf)
        {
            this.Profissao = profissao;
            this.NomeEmpresa = nomeempresa;
            this.Renda = salario;
        }
        public ContaComum(string profissao, string nomeempresa, float salario, String titular, long NumeroConta, int Senha, String TipoConta, float limite, float Saldo, PessoaJuridica pessoaj) : base(titular, NumeroConta, Senha, TipoConta, limite, Saldo, pessoaj)
        {
            this.Profissao = profissao;
            this.NomeEmpresa = nomeempresa;
            this.Renda = salario;
        }

    }
}
