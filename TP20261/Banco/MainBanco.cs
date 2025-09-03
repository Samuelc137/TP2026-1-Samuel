//Programa principal del banco

Banco banco = new Banco();

try
{

    Console.WriteLine(" Ingresa tu numero de cuenta");
    string numeroCuenta = Console.ReadLine() ?? "";

    ClaseBancaria cuentaOrigen = banco.BuscarCuenta(numeroCuenta);

    //Depositar
    Console.WriteLine("Ingresa la cantidad a transferir");

    decimal num = Convert.ToDecimal(Console.ReadLine() ?? "");

    cuentaOrigen.Depositar((decimal)num);



    //Transferir

    Console.WriteLine("Ingresa el numero de cuenta destino");

    string numeroCuentaDestino = Console.ReadLine() ?? "";
    ClaseBancaria numeroCuentaDestino = banco.BuscarCuenta(numeroCuentaDestino);
    Console.WriteLine("Ingresa la cantidad a transferir");
    decimal numTrans = double.Parse(Console.ReadLine() ?? "");

    cuentaOrigen.Transferir((decimal)numTrans, cuentaDestino);

    //retirar

    Console.WriteLine("Ingresa la cantidad a retirar");
    double numRet = double.Parse(Console.ReadLine() ?? "");
    cuentaOrigen.Retirar((decimal)numRet);
}

catch (SaldoInsuficienteException e)
{
    Console.WriteLine(e.Message);
}

catch (CuentaNoEncontradaExcepcion e)
{
    Console.WriteLine(e.Message);
}

catch (DepositoInvalidoException e)
{
    Console.WriteLine(e.Message);
}