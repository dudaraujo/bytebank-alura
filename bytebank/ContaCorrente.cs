using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    //Clase é um modelo para criar objetos, um escopo
    public class ContaCorrente
    {
        //Um campo é uma variável definida dentro do corpo de uma classe
        public string Conta;
        public int NumeroAgencia;
        public string NomeAgencia;
        public double Saldo;

        //Definindo um método, um comportamento existente no mundo real 
        //Usando o bool pois quero que ele retorne uma valor booleano
        public bool Sacar(double valor)
        {
            if (Saldo > valor && valor > 0)
            {
                Saldo = Saldo - valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Métodos que são definidos como void não retornam valor 
        public void Depositar(double valor)
        {
            if(valor > 0)
            {
                Saldo = Saldo + valor;
            }
        }

        
        //Passando como referência o valor que será tranferido e o objeto que receberá o valor 
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(Saldo > valor && valor > 0)
            {
                Saldo = Saldo - valor;
                destino.Saldo = destino.Saldo + valor;
                return true;
            }
            else
            {
                return false; 
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine(Titular);
            Console.WriteLine(Conta);
            Console.WriteLine(NomeAgencia);
            Console.WriteLine(NumeroAgencia);
            Console.WriteLine(Saldo);
        }
    }
}
