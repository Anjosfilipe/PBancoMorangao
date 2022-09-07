using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class ContaVip : ContaCorrente
    {

        float Investimento, Renda;

        public ContaVip(float investimento, float renda,String titular, long NumeroConta, int Senha, String TipoConta, float limite, float Saldo, PessoaFisica pessoaf) : base(titular, NumeroConta, Senha, TipoConta, limite, Saldo, pessoaf)
        {
            Investimento = investimento;
            Renda = renda;
        }
        public ContaVip(float investimento, float renda, String titular, long NumeroConta, int Senha, String TipoConta, float limite, float Saldo, PessoaJuridica pessoaj) : base(titular, NumeroConta, Senha, TipoConta, limite, Saldo, pessoaj)
        {
            Investimento = investimento;
            Renda = renda;
        }
    }
}
