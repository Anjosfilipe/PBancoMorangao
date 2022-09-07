using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class ContaUniversitaria : ContaCorrente
    {
        String ra, nomeCurso, Institucao;

        public ContaUniversitaria(string ra, string nomeCurso, string institucao, String titular, long NumeroConta, int Senha,String TipoConta,float limite, float Saldo, PessoaFisica pessoaf) :base(titular,NumeroConta,Senha,TipoConta,limite,Saldo,pessoaf)
        {
            this.ra = ra;
            this.nomeCurso = nomeCurso;
            Institucao = institucao;
        }   

    }
}
