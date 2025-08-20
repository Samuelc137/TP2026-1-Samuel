
public class Persona
{
    //Propiedades/ Atributos

    public string Name { get; set; }

    public int Edad { get; set; }
    public string Pais { get; set; }

    //Constructor
    public Persona(string nombre, int edad, string pais)
    {
        Name = nombre;
        Edad = edad; 
        Pais = pais;
    }

    //Metodos
    public void MostrarDatos()
    {
        Console.Write("Nombre:");
        Console.WriteLine(Name);
        Console.Write("Edad:");
        Console.WriteLine(Edad);
    }
    
    public void MostrarPais()
{
    Console.WriteLine($"Pais:{Pais}");
}
}