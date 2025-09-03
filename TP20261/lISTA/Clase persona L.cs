

public class personaL
{
    // Atributos de la clase
    public string nombre;
    public int edad;

    // Constructor de la clase
    public personaL(string nombre, int edad)
    {
        nombre = nombre;
        edad = edad;
    }
    // Metodo para mostrar la informacion de la persona

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
    }

}
