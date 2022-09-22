using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    //Clase é um modelo para criar objetos, um escopo
    internal class ContaCorrente
    {
        //Um campo é uma variável definida dentro do corpo de uma classe
        public string Titular;
        public string Conta;
        public int NumeroAgencia;
        public string NomeAgencia;
        public double Saldo;

        public bool Sacar(double valor)
        {
            if(Saldo > valor)
            {
                Saldo = Saldo - valor;
                return true;
            }
            else
            {
                return false;
            }
        
    }
}
