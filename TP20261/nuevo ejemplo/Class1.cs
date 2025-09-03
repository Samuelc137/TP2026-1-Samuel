//una agencia de autos.representar un auto que acelera y frena

using System.Runtime.Intrinsics;

public class Auto : Vehiculo

{
    //Constructor

    public Auto(string marca, string modelo) : base(marca, modelo)
    {

    }

    //Modificar metodo del padre

    public override void MostrarInfo()
    {
        /*
        base.MostrarInfo();
        */
        Console.WriteLine($"Auto: {marca},{modelo}, Velocidad: {velocidadActual} km/h");

    }
    
}