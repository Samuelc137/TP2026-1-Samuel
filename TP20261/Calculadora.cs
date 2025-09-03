public class Calculadora
{
//Atributos
    public double N1 { get; set; }
    public double N2 { get; set; }

    //Atributo reservado

    private double Resulatdo;

    
    
    // Constructor



    public Calculadora(double numero1, double numero2)
    {
        N1 = numero1;
        N2 = numero2;
    }
    // Metodos
    public void Sumar()
    {
        double Suma_ = N1 + N2;
        Console.WriteLine($"La suma de {N1} y {N2} es: {Suma_}");
    }
    public void Restar()
    {
        double restar_ = N1 - N2;
           Console.WriteLine($"La resta de {N1} y {N2} es: {restar_}");
    }
    public void Multiplicar()
    {
        double multiplicar = N1 * N2;
        Console.WriteLine($"La multiplicación de {N1} y {N2} es: {multiplicar}");
    }
    public void Dividir()
    {
        if (N2 == 0)
        {
            Console.WriteLine("No se puede dividir por cero.");
        }
        double division = N1 / N2;
        Console.WriteLine($"La división de {N1} y {N2} es: {division}");
    }
}