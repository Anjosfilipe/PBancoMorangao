using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class PessoaJuridica : Cliente
    {
        String Cnpj, RazaoSocial, NomeFantasia;

        public PessoaJuridica(string cnpj, string razaoSocial, string nomeFantasia, float salario, string Nome, string Telefone, Endereco endereco) : base(salario, Nome, Telefone, endereco)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
        }

        public void setCnpj(string Cnpj)
        {
            this.Cnpj = Cnpj;
        }

        public void setRazaoSocial(string RazaoSocial)
        {
            this.RazaoSocial = RazaoSocial;
        }
        public void setNomeFantasia(string nomeFantasia)
        {
            this.NomeFantasia = nomeFantasia;
        }
        public int AbrirConta()
        {
            Console.Clear();
            Console.WriteLine("Olá " + getNome());
            Console.WriteLine("Deseja abrir uma conta em nosso banco? ");
            Console.WriteLine("Digite -- 1 -- para SIM ");
            Console.WriteLine("Digite -- 2 -- para NÂO ");
            int opc = int.Parse(Console.ReadLine());

            return opc;
        }
        public int SolicitarTipoConta()
        {
            Console.Clear();
            Console.WriteLine("Para você: " + getNome());
            Console.WriteLine("Temos 2 modelos de contas em nosso banco: ");
            Console.WriteLine("Digite 1 - COMUM ");
            Console.WriteLine("Digite 2 - VIP ");
            Console.WriteLine("Digite a forma de conta desejada: 'Lembrando que estará sobre a analise de um de nossos Gerentes para APROVAÇÃO'");
            int opc = int.Parse(Console.ReadLine());

            return opc;
        }

        public string ImprimirPessoaJuridica()
        {
            return base.ImprimirPessoa() + "\nCnpj: " + Cnpj + "\nRazão Social: " + RazaoSocial + "\nNome fantasia: " + NomeFantasia;
        }

    }
}
