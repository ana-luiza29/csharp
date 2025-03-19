using System;
using exercicio_calculadora.Modelo;

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora(); 

        Console.WriteLine("Escolha uma operação: +, -, *, /");
        string operacao = Console.ReadLine(); 

        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine()); 

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine()); 

        double resultado = 0;

        
        switch (operacao)
        {
            case "+":
                resultado = calc.Somar(num1, num2);
                break;
            case "-":
                resultado = calc.Subtrair(num1, num2);
                break;
            case "*":
                resultado = calc.Multiplicar(num1, num2);
                break;
            case "/":
                resultado = calc.Dividir(num1, num2);
                break;
            default:
                Console.WriteLine("Operação inválida!");
                return; 
        }


        Console.WriteLine($"Resultado: {resultado}");
    }
}