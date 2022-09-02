using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class PessoaFisica : Pessoa
    {
        String Cpf, Sexo;
        DateTime DataNascimento;
        int TipoConta;


        public PessoaFisica(string sexo, string cpf, DateTime dataNascimento, string Nome, string Telefone,float salario, Endereco endereco) : base(Nome, Telefone,salario, endereco)
        {
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Sexo = sexo;
        }

        public void setCpf(string Cpf)
        {
            this.Cpf = Cpf;
        }
        public void setSexo(string sexo)
        {
            this.Sexo = sexo;
        }

        public void setDataNascimento(DateTime datanascimento)
        {
            this.DataNascimento = datanascimento;
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
            Console.WriteLine("\t\t\t\t\t\t\t\t$                     Olá " + getNome() +"                                  $");
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
            Console.WriteLine("Para você: " + getNome());
            Console.WriteLine("Temos 3 modelos de contas em nosso banco: ");
            Console.WriteLine("Digite 1 - UNIVERSITARIA ");
            Console.WriteLine("Digite 2 - COMUM ");
            Console.WriteLine("Digite 3 - VIP ");
            Console.WriteLine("Digite a forma de conta desejada: 'Lembrando que estará sobre a analise de um de nossos Gerentes para APROVAÇÃO'");
            int opc = int.Parse(Console.ReadLine());

            return opc;
        }
        public string ImprimirPessoaFisica()
        {
            return base.ImprimirPessoa() + "\nCpf: " + Cpf + "\nData Nascimento: " + DataNascimento + "\nSexo: " + Sexo+"\nTipo de Conta: "+TipoConta;
        }


    }
}
