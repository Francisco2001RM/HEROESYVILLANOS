// See https://aka.ms/new-console-template for more information
using System;

var spiderman = new Modelos.Heroe { Id = 1, Name = "", Surname = "", Power = "Araña" };
Console.WriteLine(spiderman.Power);
Modelos.Villano KingPin = new () { Id = 2, Name = String.Empty, Surname = "Fisk", Power=String.Empty };
Modelos.Heroe Venom = new Modelos.Heroe();
Console.WriteLine(KingPin.Surname);
Console.WriteLine(Venom.Power);


Console.WriteLine("Hello, World!");
