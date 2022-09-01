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

        public Cliente(float salario, string Nome, string Telefone, Endereco endereco) : base(Nome, Telefone, endereco)
        {

            Salario = salario;

        }

        public void setId(Random rand)
        {
            this.IdCliente = rand.Next(0, 100);

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

        //public String SolicitarFechamentoConta()
        //{
        //    Console.WriteLine("Olá " + getNome());
        //    Console.WriteLine("Atualmente sua conta: " + getContaCorrente());
        //    Console.WriteLine("Deseja cancelar a mesma?: SIM ou NÂO");

        //    return Console.ReadLine();
        //}

        public string ImprimirCliente()
        {
            return base.ImprimirPessoa() + "\nID: " + IdCliente + "\nRenda: " + Salario + "\nTipo de conta: " + Conta;
        }



    }
}
