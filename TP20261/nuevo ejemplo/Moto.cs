
public class Moto : Vehiculo 

{
    //Vehiculo
    public Moto(string marca, string modelo) : base(marca, modelo)

    {

    }

    //Metodo numerico
    public override void MostrarInfo()
    {
        /*
        base.MostrarInfo();
        */
        Console.WriteLine($"Moto: {marca},{modelo}, Velocidad: {velocidadActual} km/h");

    }
}