using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class PessoaJuridica : Pessoa
    {
        String Cnpj, RazaoSocial, NomeFantasia;
        int TipoConta;

        public PessoaJuridica(string cnpj, string razaoSocial, string nomeFantasia, float salario, string Nome, string Telefone, Endereco endereco) : base( Nome, Telefone, salario, endereco)
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

        public void setTipoConta(int tipoConta)
        {
            this.TipoConta = tipoConta;
        }
        public int AbrirConta()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                     Olá " + getNome());
            Console.WriteLine("\t\t\t\t\t\t\t\t$           Deseja  realmente abrir uma conta em nosso banco ?    $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                 Digite -- 1 -- para SIM                         $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                 Digite -- 2 -- para NÂO                         $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
            Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------------------------------------------------");
            Console.SetCursorPosition(70, 20);
            int opc = int.Parse(Console.ReadLine());

            return opc;
        }
        public int SolicitarTipoConta()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$               Para você: " + getNome());
            Console.WriteLine("\t\t\t\t\t\t\t\t$          - Temos 2 modelos de contas em nosso banco: -          $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$            Digite 1 - COMUM                                     $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$            Digite 2 - VIP                                       $");
            Console.WriteLine("\t\t\t\t\t\t\t\t$                                                                 $");
            Console.WriteLine("\t\t\t\t\t\t\t\t-------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t\tDigite a forma de conta desejada: 'Lembrando que estará sobre a analise de um de nossos Gerentes para APROVAÇÃO'");
            int opc = int.Parse(Console.ReadLine());
            return opc;
        }

        public string ImprimirPessoaJuridica()
        {
            return base.ImprimirPessoa() + "\nCnpj: " + Cnpj + "\nRazão Social: " + RazaoSocial + "\nNome fantasia: " + NomeFantasia + "\nTipo de Conta: " + TipoConta;
        }

    }
}
