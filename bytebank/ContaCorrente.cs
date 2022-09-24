using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank;
//Importamnto a classe Cliente que está no namespace bytebank.Titular
using bytebank.Titular;

//Eu posso ter várias classes dentro de um namespace
namespace bytebank
{
    //Clase é um modelo para criar objetos, um escopo
    public class ContaCorrente
    {
        //Um campo é uma variável definida dentro do corpo de uma classe
       //Clinete Titular é onde eu estou juntando a classe Cliente com a classe ContaCorrente
        public Cliente Titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo;

        //Definindo um método, um comportamento existente no mundo real 
        //Usando o bool pois quero que ele retorne uma valor booleano
        public bool Sacar(double valor)
        {
            if (saldo > valor && valor > 0)
            {
                saldo = saldo - valor;
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
                saldo = saldo + valor;
            }
        }

        
        //Passando como referência o valor que será tranferido e o objeto que receberá o valor 
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(saldo > valor && valor > 0)
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
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
            Console.WriteLine(conta);
            Console.WriteLine(nomeAgencia);
            Console.WriteLine(numeroAgencia);
            Console.WriteLine(saldo);
        }
    }
}
