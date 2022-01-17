
public class ContaCorrente 
// classe contacorrente define a estrutura que os objetvos dessa classe devem seguir!

{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo=100;

    //Quando retorna valor é comum chamar de FUNÇÃO.
    //Função para realização de SAQUES das contas correntes. (Quando usa o 'bool' precisa ter um retorno, true ou false.
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
                
        this.saldo -= valor;
        return true;        
    }

    //Quando NÃO retorna valor é comum chamar de MÉTODO.
    //Função para DEPOSITAR. (Para ações sem retorno, usa-se o 'void')
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    //Função para TRANSFERIR, onde retorna valor e precisa do parâmetro 'valor' e 'conta'
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        //Manter primeiro as condições que retornam false, 
        //assim não há necessidade de usar o else no bool quando for true.
        if (this.saldo < valor)
        {
            return false;
        }
        
        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }

}