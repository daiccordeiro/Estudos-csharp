//using _006_ByteBank;

namespace _006_ByteBank
{
    public class ContaCorrente
    // classe contacorrente define a estrutura que os objetvos dessa classe devem seguir!

    {
        public Cliente titular;
        public int agencia;
        public int numero;
        //PRIVATE deixa 'saldo' como campo interno da Classe 'ContaCorrente'
        private double saldo = 100;


        //Método para saber se  a operação realizada com sucesso ou não.
        public void DefinirSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            this.saldo = saldo;
        }

        //Método que dá acesso ao valor do campo 'saldo'
        public double ObterSaldo()
        {
            return saldo;
        }

        //Quando retorna valor é comum chamar de FUNÇÃO.
        //Função para realização de SAQUES das contas correntes. (Quando usa o 'bool' precisa ter um retorno, true ou false.
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            return true;
        }

        //Quando NÃO retorna valor é comum chamar de MÉTODO.
        //Função para DEPOSITAR. (Para ações sem retorno, usa-se o 'void')
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        //Função para TRANSFERIR, onde retorna valor e precisa do parâmetro 'valor' e 'conta'
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            //Manter primeiro as condições que retornam false, 
            //assim não há necessidade de usar o else no bool quando for true.
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}


