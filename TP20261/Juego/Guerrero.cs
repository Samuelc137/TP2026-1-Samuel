


public class Guerrero
{
    // Atributos de la clase
    public string Nombre;
    public int Ataque;
    public int Vida;

    // Constructor de la clase

    public Guerrero(string nombre, int ataque, int vida)
    {
        Nombre = nombre;
        Ataque = ataque;
        Vida = vida;
    }

    // Metodo para mostrar la informacion del guerrero

    public virtual void Atacar(Guerrero enemigo)
    {
        int danio = Ataque + new Random().Next(-3,5);
        enemigo.RecibirDanio(danio);
        Console.WriteLine($"{Nombre} ataca a {enemigo.Nombre} y le causa {danio} de daño. Vida restante de {enemigo.Nombre}: {enemigo.Vida}");
    }

    public virtual void RecibirDanio(int danio)
    {
        Vida = Math.Max(Vida-danio,0);
   
    }

    public static Guerrero operator +(Guerrero g1, Guerrero g2)
    {
       Console.WriteLine($" {g1.Nombre} y {g2.Nombre} se fusionan en un nuevo guerrero");
        return new Guerrero($"Guerrero Fusionado {g1.Nombre} + {g2.Nombre}", (g1.Ataque + g2.Ataque)/2, (g1.Vida + g2.Vida)/2);
    }

}