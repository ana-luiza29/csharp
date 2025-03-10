using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Modelo
{
    public class Veiculo
    {
              //Atributos
       private string marca;
       private string modelo;
       private int ano;
       private double velocidadeAtual;


       //Construtor
       public Veiculo(string marca, string modelo, int ano, double velocidadeAtual)
       {
           this.marca = marca;
           this.modelo = modelo;
           this.ano = ano;
           this.velocidadeAtual  = velocidadeAtual;

           
       }
        //Métodos Andar e Falar
        public void Acelerar()
        {
            Console.WriteLine($"{marca} {modelo} de {ano} está acelerando.");
        }
        public void Freiar()
        {
            Console.WriteLine($"{marca} {modelo} de {ano} freiou rapidamente");
        }
    }
}
