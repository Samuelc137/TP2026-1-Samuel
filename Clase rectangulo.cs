public class Rectangulo
{
    // Atributos
    public float Base { get; set; }
    public float Altura { get; set; }

    // Constructor
    public Rectangulo(float baseRectangulo, float altura)
    {
        Base = baseRectangulo;
        Altura = altura;
    }

    public void Perimetro()
    {
        float perimetro = 2 * (Base + Altura);
        Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
    }

    public void Area()
    {
        float area = Base * Altura;
        Console.WriteLine($"El área del rectángulo es: {area}");
    }
}