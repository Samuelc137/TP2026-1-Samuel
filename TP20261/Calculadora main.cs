//Calculadora basica
Console.WriteLine("Ingrese el primer número:");
double numero1 = double.Parse(Console.ReadLine() ??"");
Console.WriteLine("Ingrese el segundo número:");
double numero2 = double.Parse(Console.ReadLine() ??"");
//Seleccion de calculadora

Console.WriteLine("Seleccione el tipo de calculadora: \n1- Calculadora basica \n 2- Calculadora cientifica");

int tipoCalculadora = int.Parse(Console.ReadLine() ?? "");

switch (tipoCalculadora)
{
    case 1:
        //Instanciar objeto calculadora

        Calculadora calculadoraBasica = new Calculadora(numero1, numero2);
        break;

    case 2:
        //Instanciar objeto calculadora cientifica
        CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica(numero1, numero2);

        break;

    default:
        Console.riteLine("Opción no válida.");
        break;

}

if(tipoCalculadora)


// Seleccion de operaciones

Console.WriteLine("Seleccione una operación:");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");    
Console.WriteLine("4. Dividir");

int opcion = int.Parse(Console.ReadLine() ??"");

switch (opcion)
{     case 1:
        calculadora.Sumar();
        break;
    case 2:
        calculadora.Restar();
        break;
    case 3:
        calculadora.Multiplicar();
        break;
    case 4:
        calculadora.Dividir();
        break;

    case 5:
        
        calcadoraCientifica.Factorial();
        break;
    case 6:
       calculadoraCientifica.RaizCuadrada();
        break;
    case 7:
        calculadoraCientifica.Logaritmo();
        break;

    default:
        Console.WriteLine("Opción no válida.");
        break;
}
