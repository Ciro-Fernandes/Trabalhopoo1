
using SistemaFinanceiro.Model;
Banco banco1 = new Banco(1, "Itau");

Agencia agencia1 = new Agencia(123, "unibanco", "2133553355", banco1);

Cliente cliente1 = new Cliente("Pedro", "11122211122", new DateTime(1999, 5, 10));
Cliente cliente2 = new Cliente("Ciro", "22211122211", new DateTime(1998, 9, 11));

Conta conta1 = new Conta(123456, 1235.42m, cliente1, agencia1);
Conta conta2 = new Conta(654321, 2341.42m, cliente2, agencia1);

Console.WriteLine($"Saldo total conta 1 é : R${conta1.Saldo}");
Console.WriteLine($"Saldo total conta 2 é : R${conta2.Saldo}");


decimal saldoTotal = conta1.Saldo + conta2.Saldo;

Conta contaMaiorSaldo = (conta1.Saldo > conta2.Saldo) ? conta1 : conta2;

conta1.Transferencia(100m, conta2);

decimal saldoInicialTotalGeral = conta1.Saldo + conta2.Saldo;

Console.WriteLine($"Saldo total das contas: R${saldoTotal}");
Console.WriteLine($"Conta com maior saldo: {contaMaiorSaldo.Numero}");
Console.WriteLine($"Saldo inicial total : R${saldoInicialTotalGeral:C}");

Console.WriteLine($"Cliente: {cliente1.Nome}, CPF: {cliente1.CPF}, Data de Nascimento: {cliente1.DataNascimento.ToShortDateString()}");
Console.WriteLine($"Cliente: {cliente2.Nome}, CPF: {cliente2.CPF}, Data de Nascimento: {cliente2.DataNascimento.ToShortDateString()}");

Console.WriteLine($"Idade em romano do cliente {cliente1.Nome} é {cliente1.ConverterParaRomano()}");



