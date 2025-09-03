
/*

//lISTA

//Crear una lista

List<int> numeros = new List<int>();

List<string> nombres = new List<string>();

//Agregar elementos 

numeros.Add(10);

numeros.Add(20);
numeros.Add(30);

//Agregar varios elementos

int primerNumero = numeros[0];

Console.WriteLine($"El primer numero es: {primerNumero}");

numeros.Remove(10); //Elimina el elemento 10 de la lista
numeros.RemoveAt(1); //Elimina el elemento en la posicion 1


//Recorrer la lista

foreach (int numero in numeros)
{
    Console.WriteLine($"El numero es: {numero}");
}

*/


//Programa lista de personas


List<personaL> listaPersonas = new List<personaL>();

listaPersonas.Add(new personaL("Juan", 25));
listaPersonas.Add(new personaL("Maria", 30));
listaPersonas.Add(new personaL("Pedro", 20));
listaPersonas.Add(new personaL("Ana", 28));
listaPersonas.Add(new personaL("Luis", 22));


foreach (personaL persona in listaPersonas)
{
    if (persona.edad > 18)
    {
        persona.MostrarInformacion();
    }
}


