using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nova contacorrente 'Bruno'
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            
            Console.WriteLine(contaDoBruno.saldo);

            //contaDoBruno = (nome da referência) e .Sacar = (nome do método)
            bool resultadoSaque = contaDoBruno.Sacar(500);

            //Verificando o saldo da conta 'Bruno' depois da função 'SACAR'
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);
            
            //Método DEPOSITAR na contaDoBruno
            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            //Nova contacorrente 'Gabriela'
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            //Verificando os saldos das contas 'Bruno' e 'Gabriela' depois do método 'DEPOSITAR'
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            //Chamando a função TRANSFERIR - contaDoBruno para contaDaGabriela
            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            //Verificando os saldos das contas 'Bruno' e 'Gabriela' depois da função 'TRANSFERIR'
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            //Retorno booleano da transferencia (true ou false)
            Console.WriteLine("Resultado transferência: " + resultadoTransferencia);
            
            //TRANSFERIR da contaDaGabriela para contaDoBruno
            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            //Mostra na tela
            Console.ReadLine();

        }
    }
}
