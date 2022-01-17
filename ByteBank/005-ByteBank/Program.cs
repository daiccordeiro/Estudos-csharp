using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Informações da Classe 'Cliente'
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "434.562.878-20";

            //Informações da Classe 'Conta Corrente'
            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            //Manipulando o mesmo objeto de 2 formas diferentes:
            //Acessando através da referência da variável 'gabriela'
            Console.WriteLine(gabriela.nome);
            //Acessando o campo 'titular' que guarda uma referência do obj 'gabriela'
            Console.WriteLine(conta.titular.nome); 

            //Console.ReadLine();

            //Outra forma de fazer:
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = new Cliente();
            conta1.titular.nome = "Gabriela Costa";
            conta1.titular.cpf = "434.562.878-20";
            conta1.titular.profissao = "Desenvolvedora C#";

            conta1.saldo = 500;
            conta1.agencia = 563;
            conta1.numero = 5634527;

            Console.WriteLine(conta1.titular.nome);
            Console.WriteLine(conta1.titular.cpf);
            Console.WriteLine(conta1.titular.profissao);

            Console.ReadLine();


        }

    }
}
