//Arreglos
//Inicilizacion


int[] numeros = new int[3]; //Arreglo

//Asignar valor valores a elementos

numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;

for(int i=0; i<= 2; i++)
{
    Console.WriteLine(numeros[i]);
}

foreach(int numero in numeros)
{
    Console.WriteLine(numero);
}

if(numeros[1] == 2)
{
    Console.WriteLine("Es un dos");
}

//Obtener la longitud

Console.WriteLine(numeros.Length);

//Definicion implicita 

int[] numeros2 = new int[] {4,5,6,8,9,1,2,3,7,11};

char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

foreach (char vocal in vocales)
{
    Console.WriteLine(vocal);
}

bool[] estados = new bool[3];

estados[0] = true;
estados[1] = false;
estados[2] = false;

if (estados[0])
{
    Console.WriteLine("Aqui hay un verdadero");
}

if (!estados[0])
{
    Console.WriteLine("Aqui hay un falso");
}

//Ordenamiento de mayor a menor

Console.WriteLine("Arreglo desordenado");

foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}

Array.Sort(numeros2); //acomoda los valores del arreglo

Console.WriteLine("Arreglo ordenado");

foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}
//Arreglo ordenado de mayor a menor 
//Necesario mi arreglo ya previamente ordenado de mayor a menor 

Array.Reverse(numeros2);

Console.WriteLine("Arreglo ordenado de mayor a menor ");

foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}

//Busqueda por valor

Console.WriteLine(Array.BinarySearch(numeros2,7)); //regresa un negstivo si lo encuentra, y un cero si no


