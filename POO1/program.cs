//Programa estructutado
Console.WriteLine("Hola mundo");

Console.WriteLine("Ingresa el nombre de la persona");
string nombre = Console.ReadLine()??"";

Console.WriteLine("Ingresa la edad");
int edad = int.Parse(Console.ReadLine());

//Mostrar datos
Console.WriteLine("Los datos de la persona son:");
Console.WriteLine($"Nombre:,{nombre}");
Console.WriteLine($"Edad:,{edad}");

//Programa orientado a objetos 

//Crear objeeto de tipo persona

Persona unEnteAlien = new Persona("Alien", 580);
/*
Console.Write("Nombre:");
Console.WriteLine(unEnteAlien.Name);
Console.Write("Edad:");
Console.WriteLine(unEnteAlien.Edad);
*/

//Ejecutar el metodo de Persona

unEnteAlien.MostrarMetodos();
