//Chamando a classe que eu dei o namespace bytebank
//Sempre quando queremos usar um arquivo, objeto, classe definido em outro arquivo,
//devemos importar o namespace
using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!!");

//Criando uma nova conta com o escopo ContaCorenete,que é uma classe
//Criando um objeto
ContaCorrente conta1 = new ContaCorrente("Agencia Sul");


//Acessando a propriedade de uma class

//conta1.Titular = "Maria Eduarda";
conta1.Conta = "10123-X";
conta1.NumeroAgencia = 23;
//conta1.NomeAgencia = "Agencia Sul";
//Não consigo mais definir o saldo dessa forma pois a variável foi definida como private
//conta1.saldo = 1000;
conta1.SetSaldo(1000);

ContaCorrente conta2 = new ContaCorrente("Agencia Norte");
//conta2.Titular = "Gabriel de Almeida";
conta2.Conta = "10123-E";
conta2.NumeroAgencia = 25;
//conta2.NomeAgencia = "Agencia Norte";
//conta2.saldo = 2000;
conta2.SetSaldo(2000);

//False pois o endereço de memória é diferente, são duas contas diferentes por mais que tenham os mesmo dados
//Comparãção por tipagem
//Console.Writeline(conta1 == conta2);

//True pois o valor dos atributos é igual em cada objeto
//Comparação por referência
//Console.Writeline(conta2.titular == conta1.titular);

//Agora a comparação vai ser true pois eu passei o enrdereço de memoria de conta2 para conta1
conta1 = conta2;
//Console.Writeline(conta1 == conta2);


//Console.WriteLine("Titular: " + conta1.Titular);
//Console.WriteLine("Número da conta: " + conta1.Conta);
//Console.WriteLine("Número da agencia: " + conta1.NumeroAgencia);
//Console.WriteLine("Nome da agencia: " + conta1.NomeAgencia);
//Console.WriteLine("Saldo da conta: " + conta1.GetSaldo());

//Pessoa paciente1 = new Pessoa();
//Console.WriteLine(paciente1.nomePessoa);
//Console.WriteLine(paciente1.idade);
//Console.WriteLine(paciente1.altura);
//Console.WriteLine(paciente1.peso);

//Console.WriteLine("Saldo da conta da Maria Eduarda: " + conta1.GetSaldo());

//Colocando o retorno do método sacar dentro da variável saque
//bool saque = conta1.Sacar(50);
//Console.WriteLine("Retorno do método sacar: " + saque);
//Console.WriteLine("Saldo da conta da Maria Eduarda após o saque: " + conta1.GetSaldo());


////Deposito
//Console.WriteLine("Saldo da conta da Duda antes de depositar: " + conta1.GetSaldo());
conta1.Depositar(1000);
//Console.WriteLine("Saldo da conta da Duda depois de depositar: " + conta1.GetSaldo());


////Transferência
//Console.WriteLine("Saldo da conta1 antes da tranferência: " + conta1.GetSaldo());
//Console.WriteLine("Saldo da conta2 antes da tranferênia " + conta2.GetSaldo());
bool tranferencia = conta1.Transferir(1000, conta2);
//Console.WriteLine("Tranferência realizada? " + tranferencia);
//Console.WriteLine("Saldo da conta1 depois da tranferência: " + conta1.GetSaldo());
//Console.WriteLine("Saldo da conta2 depois da tranferênia " + conta2.GetSaldo());



////Exibir dados
//conta1.ExibirDados();
//conta2.ExibirDados();


//Criando objeto cliente
Cliente duda = new Cliente();
duda.Nome = "Maria Eduarda";
duda.Cpf = "12312312315";
duda.Profissao = "QA Analyst";

Cliente gabris = new Cliente();
gabris.Nome = "Gabriel de Almeida";
gabris.Cpf = "78978978941";
gabris.Profissao = "Developer";

ContaCorrente conta3 = new ContaCorrente("Agencia Central");
conta3.Titular = gabris;
conta3.Conta = "12141";
conta3.NumeroAgencia = 12;
//conta3.NomeAgencia = "Agencia Central";
conta3.SetSaldo(4000);

//Console.WriteLine("O NOME DO CLINTE DA CONTA3 É: " + conta3.Titular.Nome);

//Outra forma de criar objetos e atribuir valores 
ContaCorrente conta4 = new ContaCorrente("Agencia da Isa");
Cliente isa = new Cliente();
conta4.Titular = isa;
conta4.Titular.Nome = "Isa";
conta4.Titular.Profissao = "Engenheira de Produção";


//Console.WriteLine("O nome e a profissão do titular da conta 4 é: " + conta4.Titular.Nome + "e " + conta4.Titular.Profissao);

//Não posso setar nem exibir o saldo dessa forma pois defini a variável saldo como private
//conta4.saldo = -10;
//Console.WriteLine(conta4.saldo);

conta4.SetSaldo(10);
//Console.WriteLine(conta4.GetSaldo());

//Utilizando forma mais correta do set e get
//Estou chamando a propriedade Saldo que é publica e tem o get e set
//NÃO estou chamando diretamente a variável saldo
conta4.Saldo = 1000;
//Console.WriteLine("Saldo da conta4: " + conta4.Saldo);


Cliente sarah = new Cliente();


//Console.WriteLine(conta1.NomeAgencia);
//Console.WriteLine(conta2.NomeAgencia);
//Console.WriteLine(conta3.NomeAgencia);
//Console.WriteLine(conta4.NomeAgencia);

ContaCorrente contaCorrente = new ContaCorrente("Agência ITI");

//Console.WriteLine(ContaCorrente.TaxaOpecacao);

//Acessando uma propriedade estática da classe ContaCorrente
Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

Console.WriteLine("Total de clientes cadastrados: " + Cliente.TotalDeClientesCadastrados);

try
{
    ContaCorrente lua = new ContaCorrente("Luc");
    lua.Depositar(50);
    lua.Sacar(500);
    Console.WriteLine(lua.Saldo);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Ocorreu um erro do tipo ArgumentExeception");
    Console.WriteLine(ex.Message);
}
catch(SaldoInsulficienteException ex)
{
    Console.WriteLine("Ocorreu um erro do tipo Saldo insulficiente Exceptions");
    Console.WriteLine(ex.Message);
    Console.WriteLine("Stack Trace" + ex.StackTrace);
}