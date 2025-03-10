using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using classes.Modelo;

namespace classes.Modelo
{}
    public class Pessoa
    {
        // atributos
        string nome;
        int idade;
        double altura;
        double peso;

        //Construtor
        public Pessoa(string nome, int idade, double altura, double peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
        }
    // metodo falar e andar
    public void Andar()
    {
        Console.WriteLine($"{nome} está andando.");
    }
    public void Falar()
    {
    Console.WriteLine($"{nome} Vou ficar rico programando em C#!");
    }


}