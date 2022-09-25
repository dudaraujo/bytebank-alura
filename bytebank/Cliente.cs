using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {

        //Propriedades autoimplementadas 

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente()
        {
            TotalDeClientesCadastrados += 1;
        }

        public static int TotalDeClientesCadastrados { get; set; }


     

    }
}
