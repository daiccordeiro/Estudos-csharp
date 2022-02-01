﻿using ByteBank2.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    //Diretor herda as propriedades de funcionario
    public class Diretor : FuncionarioAutenticavel
    {        
        public Diretor(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }              

        public override void AumentarSalario()
        {
            Salario*=1.15;
        }

        //override sobrepõe a implementação da classe base
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
