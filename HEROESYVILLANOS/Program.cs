// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

var spiderman = new Modelos.Heroe { Id = 1, Name = "Peter", Surname = "Parker", Power = "Araña" };
Console.WriteLine(spiderman.Power);
Modelos.Villano KingPin = new () { Id = 2, Name = "Willson", Surname = "Fisk", Power="Intimidación" };
Modelos.Villano Venom = new() { Id = 4, Name = "Eddie", Surname = "Brock", Power = "Alien" };
Modelos.Villano DoctorOC = new() { Id = 5, Name = "Otto", Surname = "Octavius", Power = "Tentaculos" };
Console.WriteLine(KingPin.Surname);
Console.WriteLine(Venom.Power);
Modelos.Heroe IronMan = new Modelos.Heroe() { Id = 3, Name = "Tony", Surname = "Stark", Power = "Armadrua" };

var heroes1 = new List<Modelos.Heroe>() {spiderman, IronMan };
var heroes2 = new List<Modelos.Heroe>();
heroes2.Add(spiderman);
heroes2.Add(IronMan);
List<Modelos.Heroe> heroes3 = new() { spiderman, IronMan};
List<Modelos.Heroe> heroes4 = new();
heroes4.Add(spiderman);
heroes4.Add(IronMan);
List<Modelos.Villano> Villanos = new() { Venom, DoctorOC, KingPin };

List<Object> HeroesyVilanos = new();
HeroesyVilanos.AddRange(Villanos);
HeroesyVilanos.AddRange(heroes1);
var PrimerVillano = Villanos.FirstOrDefault();
Console.WriteLine(PrimerVillano.Name);
var UltimoHeroe = heroes1.LastOrDefault();
Console.WriteLine(UltimoHeroe.Name);





Console.WriteLine("Hello, World!");
Console.WriteLine(HeroesyVilanos.Count);
Console.WriteLine(heroes1.Count);
Console.WriteLine(Villanos.Count);
