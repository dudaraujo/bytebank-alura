//Chamando a classe que eu dei o namespace bytebank
//Sempre quando queremos usar um arquivo, objeto, classe definido em outro arquivo,
//devemos importar o namespace
using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!!");

//Criando uma nova conta com o escopo ContaCorenete,que é uma classe
//Criando um objeto
ContaCorrente conta1 = new ContaCorrente();


//Acessando a propriedade de uma class

//conta1.Titular = "Maria Eduarda";
conta1.conta = "10123-X";
conta1.numeroAgencia = 23;
conta1.nomeAgencia = "Agencia Sul";
conta1.saldo = 1000;

ContaCorrente conta2 = new ContaCorrente();
//conta2.Titular = "Gabriel de Almeida";
conta2.conta = "10123-E";
conta2.numeroAgencia = 25;
conta2.nomeAgencia = "Agencia Norte";
conta2.saldo = 2000;

//False pois o endereço de memória é diferente, são duas contas diferentes por mais que tenham os mesmo dados
//Comparãção por tipagem
//Console.Writeline(conta1 == conta2);

//True pois o valor dos atributos é igual em cada objeto
//Comparação por referência
//Console.Writeline(conta2.titular == conta1.titular);

//Agora a comparação vai ser true pois eu passei o enrdereço de memoria de conta2 para conta1
conta1 = conta2;
//Console.Writeline(conta1 == conta2);


Console.WriteLine("Titular: " + conta1.Titular);
Console.WriteLine("Número da conta: " + conta1.conta);
Console.WriteLine("Número da agencia: " + conta1.numeroAgencia);
Console.WriteLine("Nome da agencia: " + conta1.nomeAgencia);
Console.WriteLine("Saldo da conta: " + conta1.saldo);

//Pessoa paciente1 = new Pessoa();
//Console.WriteLine(paciente1.nomePessoa);
//Console.WriteLine(paciente1.idade);
//Console.WriteLine(paciente1.altura);
//Console.WriteLine(paciente1.peso);

Console.WriteLine("Saldo da conta da Maria Eduarda: " + conta1.saldo);

//Colocando o retorno do método sacar dentro da variável saque
bool saque = conta1.Sacar(50);
Console.WriteLine("Retorno do método sacar: " + saque);
Console.WriteLine("Saldo da conta da Maria Eduarda após o saque: " + conta1.saldo);


////Deposito
Console.WriteLine("Saldo da conta da Duda antes de depositar: " + conta1.saldo);
conta1.Depositar(1000);
Console.WriteLine("Saldo da conta da Duda depois de depositar: " + conta1.saldo);


////Transferência
Console.WriteLine("Saldo da conta1 antes da tranferência: " + conta1.saldo);
Console.WriteLine("Saldo da conta2 antes da tranferênia " + conta2.saldo);
bool tranferencia = conta1.Transferir(1000, conta2);
Console.WriteLine("Tranferência realizada? " + tranferencia);
Console.WriteLine("Saldo da conta1 depois da tranferência: " + conta1.saldo);
Console.WriteLine("Saldo da conta2 depois da tranferênia " + conta2.saldo);



////Exibir dados
conta1.ExibirDados();
conta2.ExibirDados();


//Criando objeto cliente
Cliente duda = new Cliente();
duda.nome = "Maria Eduarda";
duda.cpf = "12312312315";
duda.profissao = "QA Analyst";

Cliente gabris = new Cliente();
gabris.nome = "Gabriel de Almeida";
gabris.cpf = "78978978941";
gabris.profissao = "Developer";

ContaCorrente conta3 = new ContaCorrente();
conta3.Titular = gabris;
conta3.conta = "12141";
conta3.numeroAgencia = 12;
conta3.nomeAgencia = "Agencia Central";
conta3.saldo = 4000;

Console.WriteLine("O NOME DO CLINTE DA CONTA3 É: " + conta3.Titular.nome);

//Outra forma de criar objetos e atribuir valores 
ContaCorrente conta4 = new ContaCorrente();
Cliente isa = new Cliente();
conta4.Titular = isa;
conta4.Titular.nome = "Isa";
conta4.Titular.profissao = "Engenheira de Produção";


Console.WriteLine("O nome e a profissão do titular da conta 4 é: " + conta4.Titular.nome + "e " + conta4.Titular.profissao);