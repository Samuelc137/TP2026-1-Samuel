/*
Console.WriteLine("Hello, World!");

//If 

int numero = 0;

Console.WriteLine("Ingrese un número entero:");
numero = int.Parse(Console.ReadLine() ??"");

if (numero > 10)
{
    Console.WriteLine("El número es mayor que 10.");
}
else if (numero >5)
{
    Console.WriteLine("El número es mayor a 5.");
}
else
{
    Console.WriteLine("Ninguna de las anteriores.");
}

//For

for (int i = 1; i <= 9; i++)
{
    Console.WriteLine(i);
}
*/




//Calculo del factotorial

int f = 0;
Console.WriteLine("Ingrese un número entero:");
f = int.Parse(Console.ReadLine() ?? "");

if (f > 1)
{
    for (int i =  f-1 ;i >=1; i--)
    {
        f = f *i ;
    }
    Console.WriteLine($"Factorial es: {f}");
}
else if (f == 1 || f==0)
{
    Console.WriteLine("El factorial de 1 es 1.");
}
else
{

}
{
    Console.WriteLine("No se puede calcular.");
}
