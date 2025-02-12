// See https://aka.ms/new-console-template for more information

string nome = "Ana Freitas";
string saudacao = "Ola," + nome + "!Bem vindo";
Console.WriteLine(saudacao);

// Saída: Ola, Ana Freitas! Bem vindo

string nome2 = "Joao";
string saudacao2 = $"Ola, {nome2}! Bem vindo";
Console.WriteLine(saudacao2);

// Saída: Ola, Joao! Bem vindo

int numero = 5;
Console.WriteLine(numero.GetType());

// Saída: System.Int32

Console.WriteLine(typeof(int));

string valorTexto = "100";
Console.WriteLine("A variavel valorTexto e do tipo:"+valorTexto.GetType());

int numero2 = int.Parse(valorTexto);
Console.WriteLine(numero2);
Console.WriteLine("A variavel numeroParse e tipo:"+numero.GetType());

string valorEmTexto = "100";
Console.WriteLine("A variavel valorTexto e do tipo:"+valorEmTexto.GetType());

int numeroConvertido =Convert.ToInt32(valorEmTexto);
Console.WriteLine(numeroConvertido);
Console.WriteLine("A variavel numeroConvertido e tipo:"+numeroConvertido.GetType());