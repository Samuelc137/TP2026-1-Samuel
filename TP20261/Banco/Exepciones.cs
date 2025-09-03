

//Programa de exepciones

class SaldoInsuficienteException : Exception //Clase completa de saldo insuficiente
{
    public SaldoInsuficienteException(string mensaje): base(mensaje)
    {

    }

    
}

public class  CuentaNoEncontradaExcepcion : Exception
{
    public CuentaNoEncontradaExcepcion(string mensaje) : base(mensaje)
    {
    }

}

class DepositoInvalidoException : Exception
{
    public DepositoInvalidoException(string mensaje) : base(mensaje)
    {
    }
}
