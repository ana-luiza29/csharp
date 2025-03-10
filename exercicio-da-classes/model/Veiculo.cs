using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_da_classes.model
{
    public class Veiculos
    {
        // atributos
        string marca;
        string modelo;
        int ano;
    
   
        public Veiculos(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        //metodo acelerar e freiar 
        public void Acelerar()
        {
            Console.WriteLine($"{marca} {modelo} {ano} está acelerando.");
            
        }
        public void Freiar()
        {
            Console.WriteLine($"{marca} {modelo} {ano} está freiando.");
        }

    }

}