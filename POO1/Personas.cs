
public class Persona
{
    //Propiedades/ Atributos

    public string Name { get; set; }

    public int Edad { get; set; }

    //Constructor
    public Persona(string nombre, int edad);
    {
        Name = nombre;
        Edad = edad; 
    }

    //Metodos
    public void MostrarDatos()
    {
        Console.Write("Nombre:");
        Console.WriteLine(Name);
        Console.Write("Edad:");
        Console.WriteLine(Edad);
    }
    
    
}