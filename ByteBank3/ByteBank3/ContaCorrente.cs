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
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        public int Numero { get; set; }

        //PRIVATE deixa 'saldo' como campo interno da Classe 'ContaCorrente'
        private double _saldo = 100;

        //Construção do Método com Get e Set
        public double Saldo
        {
            //GET substituiu ObterSaldo
            get //get precisa ter um retorno
            {
                return _saldo;
            }
            //SET substituiu DefinirSaldo
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
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        //Quando retorna valor é comum chamar de FUNÇÃO.
        //Função para realização de SAQUES das contas correntes. (Quando usa o 'bool' precisa ter um retorno, true ou false.
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        //Quando NÃO retorna valor é comum chamar de MÉTODO.
        //Função para DEPOSITAR. (Para ações sem retorno, usa-se o 'void')
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        //Função para TRANSFERIR, onde retorna valor e precisa do parâmetro 'valor' e 'conta'
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            //Manter primeiro as condições que retornam false, 
            //assim não há necessidade de usar o else no bool quando for true.
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}
