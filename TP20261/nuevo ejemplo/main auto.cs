// Programa principal de auto

using System;

Auto auto1 = new Auto("Honda", "Civic");

auto1.Marca = "Honda";
auto1.Modelo = "Civic";


auto1.MostrarInfo();
auto1.Acelerar(-50);

Console.WriteLine($"El auto acelero: {auto1.VelocidadActual} km/h");

auto1.Acelerar();
Console.WriteLine($"El auto acelero: {auto1.VelocidadActual} km/h");

auto1.Frenar(20);

Console.WriteLine($"El auto ftreno: {auto1.VelocidadActual} km/h");

Moto moto1 = new Moto("Yamaha", "MT-08");

moto1.MostrarInfo();
auto1.Acelerar(-50);

Console.WriteLine($"La moto acelero: {moto1.VelocidadActual} km/h");

auto1.Frenar(20);

Console.WriteLine($"La moto frenó: {moto1.VelocidadActual} km/h");

if (auto1 > moto1)
{
    Console.WriteLine($"El numero{auto1} es mayor {moto1}");
}
else if (auto1 < moto1)
{
    Console.WriteLine($"El numero{auto1} es menor {moto1}");
}
else if (auto1 == moto1)
{
    Console.WriteLine($"El numero{auto1} es igual {moto1}");
}