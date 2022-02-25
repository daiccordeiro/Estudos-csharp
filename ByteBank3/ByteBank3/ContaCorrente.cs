using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank3
{
    public class ContaCorrente
    // classe contacorrente define a estrutura que os objetvos dessa classe devem seguir!

    {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }

        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int Numero { get; }

        public int Agencia { get; }

        private double _saldo = 100; //PRIVATE deixa 'saldo' como campo interno da Classe 'ContaCorrente'

        public double Saldo
        {
            get //get precisa ter um retorno
            {
                return _saldo;
            }
            set //set é possível fazer alteração
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor) //Função para realização de SAQUES das contas correntes        
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            _saldo -= valor;
        }

        public void Depositar(double valor) //Função para DEPOSITAR. (Para ações sem retorno, usa-se o 'void')        
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino) //Função para TRANSFERIR, onde retorna valor e precisa do parâmetro 'valor' e 'conta'
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }
            Sacar(valor);

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            contaDestino.Depositar(valor);
        }
    }
}