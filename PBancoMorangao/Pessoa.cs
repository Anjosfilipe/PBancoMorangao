using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Pessoa
    {
        String Nome, Telefone;
        Endereco Endereco;
        int IdCliente;
        float Salario;
        ContaCorrente Conta;

        public Pessoa(string Nome, string Telefone,float salario, Endereco endereco)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Endereco = endereco;
            this.Salario = salario;

        }

        public void setSalario(float salario)
        {
            this.Salario = salario;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        public void setEndereco(Endereco Endereco)
        {
            this.Endereco = Endereco;

        }
        public void setConta(ContaCorrente conta)
        {
            this.Conta = conta;
        }

        public string getNome()
        {
            return this.Nome;
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



        public string ImprimirPessoa()
        {
            return "\nNome: " + Nome + "\nTelefone: " + Telefone + Endereco + "\nID: " + IdCliente + "\nRenda: " + Salario + "\nTipo de conta: " + Conta;
        }


    }

}
