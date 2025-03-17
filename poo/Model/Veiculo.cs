using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace poo.Modelo
{
    public abstract class Veiculo
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
           this.velocidadeAtual = velocidadeAtual;
       }
       
       public string GetMarca()
       {
        return marca;
       }
       public void SetMarca(string marca)
       {
        this.marca = marca;
       }

       public string GetModelo()
       {
        return modelo;
       }
       public void SetModelo(string modelo)
       {
        this.modelo = modelo;
       }

       public int GetAno()
       {
        return ano;
       }
       public void SetAno(int ano)
       {
        this.ano = ano;
       }

       public double GetVelocidadeAtual()
       {
        return velocidadeAtual;
       }
       public void SetVelocidadeAtual(double velocidadeAtual)
       {
        this.velocidadeAtual = velocidadeAtual;
       }
       
        //Métodos Andar e Falar
        public virtual void Acelerar(double incremento)
        {
            velocidadeAtual += incremento;
            Console.WriteLine($"Acelerando... Velocidade atual {velocidadeAtual} Km/h.");
        }
        public void Freiar(double decremento)
        {
            velocidadeAtual += decremento;
            Console.WriteLine($"Freiando...Velocidade atual {velocidadeAtual} Km/h.");
        }

        public void Freiar(double decremento, bool puxarFreioDeMao)
        {
            velocidadeAtual += decremento;
            if(puxarFreioDeMao)
            {
                Console.WriteLine($"o carro freou ate a velocidade de (velocidadeAtual) km/h para nao bater");
            }
            else 
            {
                Console.WriteLine($" o carro ficou lentamento ate (velocidadeAtual) km/h ");
            }
        }

       public void Freiar(double decremento, bool puxarFreioDeMao, bool virouVolante)
       {
           velocidadeAtual += decremento;
            if(puxarFreioDeMao&&virouVolante)
            {
                Console.WriteLine($"o carro esta realizando um cavlinho de pau com intesidade de frenagem (velocidadeAtual)!");
            }
            else 
            {
                Console.WriteLine($" o carro freou ate (velocidadeAtual) km/h ");
            }
       }
       public abstract class Veiculo
       { 
        // Atributos

        // Construtor

        //Getters e setters para cada atributo 

        // Metodos acelerar

       }
        public abstract void ObterDadosDoVeiculo();

       
    }
}
    