public class CalculadoraCientifica : Calculadora
{
    // Atributos
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }

 

    // Constructor
    public CalculadoraCientifica(double numero1, double numero2) : base(numero1, numero2)
    {
    }
    // Metodos

    public int Factorial()
    {
        int f =1;
        if (N1 < 0)
        {
            Console.WriteLine("No se puede calcular el factorial de un número negativo.");
            return 0; // Indica error
        }
        if (N1 > 1)
        {
            for (int i = 1; i <= N1; i++)
            {
                f = f * i;
            }
            Console.WriteLine($"Factorial es: {f}");
        }
        else if (f == 1 || f == 0)
        {
            Console.WriteLine("El factorial de 1 es 1.");
        }
        else
        {

        }
        {
            Console.WriteLine("No se puede calcular.");
        }
    }

    public double RaizCuadrada()
    {
        return Math.Sqrt(N1);
    }

    public double Logaritmo()
    { 
        return Math.Log(N1); 
    }

}