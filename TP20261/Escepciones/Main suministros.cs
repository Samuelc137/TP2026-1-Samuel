
int numero;

Console.WriteLine("Este programa solo divide 10 entre un numero positivo y entero");

try
{
    numero = int.Parse(Console.ReadLine() ?? "");
    if (numero <0)
    {
        throw new ArgumentException("El numero no puede ser negativo");
    }
    double division = 10 / numero;
    Console.WriteLine($"El resultado de la division es: {division}");

}

catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir entre cero");
    return;
}
catch(FormatException)
{
    Console.WriteLine("El formato del numero es incorrecto");
    return;
}
catch(ArgumentException)
{
    Console.Write("El numero no puede ser negativo");
}
catch (Exception ex) //Captura cualquier tipo de excepcion
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
    return;
}

finally //Siempre se ejecuta
{
    Console.WriteLine("Gracias por usar el programa");
}