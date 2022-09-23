//Chamando a classe que eu dei o namespace bytebank
//Sempre quando queremos usar um arquivo, objeto, classe definido em outro arquivo,
//devemos importar o namespace
using bytebank;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!!");

//Criando uma nova conta com o escopo ContaCorenete,que é uma classe
//Criando um objeto
ContaCorrente conta1 = new ContaCorrente();

//Acessando a propriedade de uma class
conta1.Titular = "Maria Eduarda";
conta1.Conta = "10123-X";
conta1.NumeroAgencia = 23;
conta1.NomeAgencia = "Agencia Sul";
conta1.Saldo = 1000;

ContaCorrente conta2 = new ContaCorrente();
conta2.Titular = "Gabriel de Almeida";
conta2.Conta = "10123-E";
conta2.NumeroAgencia = 25;
conta2.NomeAgencia = "Agencia Norte";
conta2.Saldo = 2000;

//False pois o endereço de memória é diferente, são duas contas diferentes por mais que tenham os mesmo dados
//Comparãção por tipagem
Console.WriteLine(conta1 == conta2); 

//True pois o valor dos atributos é igual em cada objeto
//Comparação por referência
Console.WriteLine(conta2.Titular == conta1.Titular);

//Agora a comparação vai ser true pois eu passei o enrdereço de memoria de conta2 para conta1
//conta1 = conta2;
//Console.WriteLine(conta1 == conta2);


//Console.WriteLine("Titular: " + conta1.Titular);
//Console.WriteLine("Número da conta: " + conta1.Conta);
//Console.WriteLine("Número da agencia: " + conta1.NumeroAgencia);
//Console.WriteLine("Nome da agencia: " + conta1.NomeAgencia);
//Console.WriteLine("Saldo da conta: " + conta1.Saldo);

//Pessoa paciente1 = new Pessoa();
//Console.WriteLine(paciente1.nomePessoa);
//Console.WriteLine(paciente1.idade);
//Console.WriteLine(paciente1.altura);
//Console.WriteLine(paciente1.peso);

Console.WriteLine("Saldo da conta da Maria Eduarda: " + conta1.Saldo);

//Colocando o retorno do método sacar dentro da variável saque
bool saque = conta1.Sacar(50);
Console.WriteLine("Retorno do método sacar: " + saque);
Console.WriteLine("Saldo da conta da Maria Eduarda após o saque: " + conta1.Saldo);


//Deposito
Console.WriteLine("Saldo da conta da Duda antes de depositar: " + conta1.Saldo);
conta1.Depositar(1000);
Console.WriteLine("Saldo da conta da Duda depois de depositar: " + conta1.Saldo);


//Transferência
Console.WriteLine("Saldo da conta1 antes da tranferência: " + conta1.Saldo);
Console.WriteLine("Saldo da conta2 antes da tranferênia " + conta2.Saldo);
bool tranferencia = conta1.Transferir(1000, conta2);
Console.WriteLine("Tranferência realizada? " + tranferencia);
Console.WriteLine("Saldo da conta1 depois da tranferência: " + conta1.Saldo);
Console.WriteLine("Saldo da conta2 depois da tranferênia " + conta2.Saldo);



//Exibir dados
conta1.ExibirDados();
conta2.ExibirDados();
