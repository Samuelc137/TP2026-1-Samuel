public class ClaseBancaria
{

    //Atributos


    public string NumeroCuenta { get; set; }
    public decimal Saldo { get; set; }

    //Constructor

    public ClaseBancaria(string numeroCuenta, decimal saldo)
    {
        NumeroCuenta = numeroCuenta;
        Saldo = saldo;
    }
    //Metodos


    public void Depositar(decimal cantidad)
    {
        if (cantidad < 0)
        {
            throw new DepositoInvalidoException("La cantidad a depositar debe ser mayor que cero.");
        }
        Saldo += cantidad;
        
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad > Saldo)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente para realizar el retiro.");
        }
        Saldo -= cantidad;
       
        
    }

    public void Transferir(decimal cantidad, ClaseBancaria cuentaDestino)
    {
        if(cuentaDestino == null)

        {
            throw new CuentaNoEncontradaExcepcion("La cuenta destino no existe.");
        }
        Retirar(cantidad);

        cuentaDestino.Depositar(cantidad); 
    }

}