public class Cadrado
{
    // Atributos
    public float Lado { get; set; }

    // Constructor
    public Cadrado(float lado)
    {
        Lado = lado;
    }

    // Métodos
    public void Perimetro()
    {
        float perimetro = 4 * Lado;
        Console.WriteLine($"El perimetro del cuadrado es: {perimetro}");
        
    }

    public void Area()
    {
        float area = Lado * Lado;
        Console.WriteLine($"El area del cuadrado es: {area}");
        
    }
}