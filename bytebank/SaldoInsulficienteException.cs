using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class SaldoInsulficienteException : OperacaoFinanceiraException
    {
        public SaldoInsulficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
