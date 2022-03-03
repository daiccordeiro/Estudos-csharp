using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2022, 1, 1);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataCorrente - dataFimPagamento;
            //TimeSpan diferenca = TimeSpan.FromMinutes(60);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);

            //Console.WriteLine(dataCorrente);
            //Console.WriteLine(dataFimPagamento);

            
            //-------------------------------//
            ////ContaCorrente conta = new ContaCorrente(847, 489754);

            ////FuncionarioAutenticavel carlos = null;

            ////carlos.Autenticar("kjhasfkjas");

            ////Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
        //    static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        //    {
        //        return timeSpan.Days + " dias";
        //    }
    }
}