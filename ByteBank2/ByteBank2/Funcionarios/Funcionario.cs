﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public abstract class Funcionario
    {
        // 0 - funcionário
        // 1 - diretor
        // 2 - designer
        // N - ...
        //private int _tipo;

        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }
        
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    } 
}