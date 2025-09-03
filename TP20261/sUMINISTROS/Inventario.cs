
public class Inventario

{
    //Atributos
    private Suministro[] suministros;

    //Constructor
    public Inventario()
    {
        suministros = new Suministro[]
        {
            new Suministro("Comida",5,1),
            new Suministro("Agua",10,1),
            new Suministro("Ropa",7,2),
            new Suministro("Antibioticos",0,1),
            new Suministro("Herrramientas"),
            new Suministro("Oxigeno"),
            new Suministro("Combustible")
        };

    }

    //Metodos

    public void MostrarSumnistros()
    {
        Console.WriteLine("Inventario actual:");

        foreach(Suministro item in suministros)
        {
            item.MostrarInfo();
        }
    }

    public void BuscarSuministro(string nombre)
    {
        int indice = Array.FindIndex(suministros,s => s.Nombre.ToLower() == nombre.ToLower()); //Tolower manda la cadena de caracteres  a minusculas

        if(indice >=0)
        {
            Console.WriteLine($"{nombre} encontrado en la posicion  {indice}");
        }
        else
        {
            Console.WriteLine($"{nombre} no encontrado en el inventario");
        }
    }

    //Ordenar suministro por nombre

    public void OrdenarPorNombre()
    {
        Array.Sort(suministros, (x,y) => x.Nombre.CompareTo(y.Nombre));
        Console.WriteLine("Inventario ordenado por nombre ");
    }

    //Invertir el orden

    public void InvertirOrden()

    {
        Array.Reverse(suministros);
        Console.WriteLine("Orden de los suminstrs invertidos");
    }

    //Vaciar inventario

    public void VaciarInventario()
    {
        Array.Clear(suministros, 0, suministros.Length);
        Console.WriteLine("Inventario ah sido borrado");
        Console.WriteLine($"Longitud: {suministros.Length}");

    }

    //Agregar suministro 3

    public void AgregarSuministro(string nombre, int cantidad, int prioridad)
    {
        int indice = Array.FindIndex(suministros, s => s.Nombre.ToLower() == nombre.ToLower()); //Tolower manda la cadena de caracteres  a minusculas

        if (indice >= 0)
        {

            Console.WriteLine($"Ya existe y {nombre} encontrado en la posicion  {indice}");
        }
        else
        {
            Array.Resize(ref suministros, suministros.Length + 1);
            suministros[suministros.Length - 1] = new Suministro(nombre, cantidad, prioridad);
            Console.WriteLine($"{nombre} ah sido al inventario");
        }
    }

    

    

    //Agregar suministro unicaente con nombre
    public void AgregarSuministro(string nombre)
    {
        AgregarSuministro(nombre, 1, 2);
    }

    //Eliminar suministro
    public void EliminarSuministro(string nombre)
    {
        int indice = Array.FindIndex(suministros, s => s.Nombre.ToLower() == nombre.ToLower()); //Tolower manda la cadena de caracteres  a minusculas
        if (indice >= 0)
        {
            for (int i = indice; i < suministros.Length - 1; i++)
            {
                suministros[i] = suministros[i + 1];
            }
            Array.Resize(ref suministros, suministros.Length - 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{nombre} ah sido eliminado del inventario");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{nombre} no encontrado en el inventario");
        }
    }
}