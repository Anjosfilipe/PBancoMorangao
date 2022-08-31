using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Cliente : Pessoa
    {
        int IdCliente;
        float Salario;
        ContaCorrente Conta;
        Random rand = new Random(100);

        public Cliente(float salario, string Nome, string Telefone, Endereco endereco) : base(Nome, Telefone, endereco)
        {

            Salario = salario;

        }

        public int setId(Random rand)
        {
            this.IdCliente = rand.Next(0, 100);
            return this.IdCliente;
        }

        public void setSalario(float salario)
        {
            this.Salario = salario;
        }

        public void setConta(ContaCorrente conta)
        {
            this.Conta = conta;
        }
        public String SolicitarEmprestimo()
        {
            Console.WriteLine("Digite o valor que deseja de emprestimo: ");
            float valorEmprestimo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de parcelas desejadas: ");
            int parcelas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data de vencimento: ");
            string dataVencimento = Console.ReadLine();

            return "\nValor desejado: " + valorEmprestimo + "\nNumero de parcelas: " + parcelas + "\nData de vencimento: " + dataVencimento;
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
            Console.WriteLine("Temos 3 modelos de contas em nosso banco: ");
            Console.WriteLine("Digite 1 - UNIVERSITARIA ");
            Console.WriteLine("Digite 2 - COMUM ");
            Console.WriteLine("Digite 3 - VIP ");
            Console.WriteLine("Digite a forma de conta desejada: 'Lembrando que estará sobre a analise de um de nossos Gerentes para APROVAÇÃO'");
            int opc = int.Parse(Console.ReadLine());

            return opc;
        }
        //public String SolicitarFechamentoConta()
        //{
        //    Console.WriteLine("Olá " + getNome());
        //    Console.WriteLine("Atualmente sua conta: " + getContaCorrente());
        //    Console.WriteLine("Deseja cancelar a mesma?: SIM ou NÂO");

        //    return Console.ReadLine();
        //}

        public override string ToString()
        {
            return base.ImprimirPessoa() + "\nID: " + IdCliente + "\nRenda: " + Salario + "\nTipo de conta: " + Conta;
        }



    }
}
