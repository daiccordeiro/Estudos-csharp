using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    //Diretor herda as propriedades de funcionario
    public class Diretor : Funcionario
    {
        //override sobrepõe a implementação da classe base
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
