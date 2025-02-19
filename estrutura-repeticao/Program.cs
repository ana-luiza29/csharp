// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random numeroAleatorio = new Random();
int numero = numeroAleatorio.Next(1, 101);
int contador = 0;

Console.WriteLine($"Numero Alvo:{numero}");
while (contador <= numero)
{
    Console.Write($"contador:{contador}");
    contador++;
}
Console.WriteLine($"Contador atingiu o numero alvo:{contador}");

int numero1 = 0;

do 
{
    Console.WriteLine($"Numero:{numero1}");
    numero++;
}while (numero1 < 10);