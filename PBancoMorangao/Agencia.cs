﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoMorangao
{
    internal class Agencia
    {
        int IdAgencia = 0;
        String Nome;
        Endereco Endereco;
        Funcionario funcionario;
        Cliente cliente;

        public Agencia(string nome, Endereco endereco)
        {
           
            this.Nome = nome;   
            this.Endereco = endereco;    
          
        }
        public void setIdAgencia()
        {
            IdAgencia++;
        }





    }
}
