﻿using POO.model;
using POO.modelo;

Veiculos obj = new Veiculos("type R", "civic", 2020, 330.00);
obj.acelerar();
obj.Freiar();

Carro carro = new Carro("bmw", "320i", 2024, 330.00, true, 4);
carro.AbrirPortas();

Moto moto = new Moto("pop", "100", 2011, 330.00, true, true);
moto.Empinar();