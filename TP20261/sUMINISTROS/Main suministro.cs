//Programa principal del inventario Mision Orion x

//Instanciar el inventario

Inventario inventario = new Inventario();

bool salir = false;
do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Menu de opciones");
    Console.WriteLine("1. Agregar suministro");
    Console.WriteLine("2. Buscar Suministros");
    Console.WriteLine("3. Eliminar Suministros");
    Console.WriteLine("4. Mostrar Inventario"); 
    Console.WriteLine("5. Limpiar suministros");
    Console.WriteLine("6. Salir");


    int opcion = int.Parse(Console.ReadLine()??"");


    switch (opcion)
    {

        case 1:
            Console.WriteLine("Ingrese el nombre del suministro a agregar:");
            string nombre = Console.ReadLine() ?? "";
            if (nombre != "")
            {
                Console.WriteLine("Desea agregar cantidad y prioridad? (1-Si, 2-No):");
                int respuesta = int.Parse(Console.ReadLine() ?? "");

                switch (respuesta)
                {
                    case 1:
                        Console.WriteLine("Ingrese la cantidad del suministro a agregar:");
                        int cantidad = int.Parse(Console.ReadLine() ?? "");
                        Console.WriteLine("Ingrese la prioridad del suministro a agregar (1-Alta, 2-Media, 3-Baja):");
                        int prioridad = int.Parse(Console.ReadLine() ?? "");
                        inventario.AgregarSuministro(nombre, cantidad, prioridad);
                        break;
                    case 2:
                        inventario.AgregarSuministro(nombre);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida, se agregara con valores por defecto.");

                        break;
                }
            }
            break;
        case 2:
            Console.WriteLine("Ingrese el nombre del suministro a buscar:");
            string nombreBuscar = Console.ReadLine() ?? "";
            if (nombreBuscar != "")
            {
                inventario.BuscarSuministro(nombreBuscar);
            }
            break;
        case 3:
            Console.WriteLine("Ingrese el nombre del suministro a eliminar:");
            string nombreEliminar = Console.ReadLine() ?? "";
            if (nombreEliminar != "")
            {
                inventario.EliminarSuministro(nombreEliminar);
            }
            break;
        case 4:
            inventario.MostrarSumnistros();
            break; 

        case 5: 
            inventario.VaciarInventario();

            break;

        case 6:
            salir = true;
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;

    }
    Console.WriteLine();
} while (!salir);
