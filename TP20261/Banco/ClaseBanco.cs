public class ClaseBanco
{


    //Atributos
    private ClaseBancaria[] cuentas;

    //constructor

    public ClaseBanco()
    {
        cuentas = new ClaseBancaria[]
        {
            new ClaseBancaria("AA01", 10),
            new ClaseBancaria("AA02", 10000),
            new ClaseBancaria("AA03", 0),
            new ClaseBancaria("AA04", (decimal)400.3),
            new ClaseBancaria("AA05", (decimal)75.5)


        }
        ;
    }
    //Metodos

    public ClaseBancaria BuscarCuenta(string numeroCuenta)
    {
        foreach (ClaseBancaria cuenta in cuentas)
        {
            if (cuenta.NumeroCuenta == numeroCuenta )
            {
                return cuenta; // Se devuelve la cuenta si se encuentra
            }
        }

        return null; // Si no se encuentra la cuenta, se devuelve null
    }
}