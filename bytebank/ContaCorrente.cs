using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Cliente titular;
        public string Conta { get; set; }

        public int NumeroAgencia { get; set; }

        //variáveis que não possuem nenhuma validação para aceitar valores, podem ser declaradas diretamente como propriedades 
        private string nomeAgencia;


        //definindo o saldo como provado pois assim não é possível 
        //mudar o saldo sem ser por algum método
        private double saldo;

        //Definindo método contrutor da classe. Ele vai ser chamado toda vez que iniciarmos uma isntância
        public ContaCorrente(string nomeAgencia)
        {
            NomeAgencia = nomeAgencia;
            TotalDeContasCriadas += 1;
        }


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
            if (valor > 0)
            {
                saldo = saldo + valor;
            }
        }


        //Passando como referência o valor que será tranferido e o objeto que receberá o valor 
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo > valor && valor > 0)
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
            Console.WriteLine(Conta);
            Console.WriteLine(NomeAgencia);
            Console.WriteLine(NumeroAgencia);
            Console.WriteLine(Saldo);
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(double valor)
        {
            if (valor > 0)
            {
                saldo = saldo + valor;
            }

        }

        //Melhor forma de fazer o get e set

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if (value > 0)
                {
                    saldo = saldo + value;
                }
            }
        }

        public Cliente Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public string NomeAgencia
        {

            get { return nomeAgencia; }

            set
            {
                if (value != null)
                    nomeAgencia = value;
            }

        }

        //Definindo uma propiedade estática, qua vai ser parte da classe em si, não da instancia de objeto
        public static int TotalDeContasCriadas { get; set; }
    }
}
