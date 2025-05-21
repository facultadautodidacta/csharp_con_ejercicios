

/*
 * 70 - Crea una clase Cuenta con:
    Un atributo privado saldo.
    Un método Depositar(decimal cantidad) 
    que sume al saldo si la cantidad es positiva.
    Un método ConsultarSaldo() 
    que devuelva el saldo.
*/

class Cuenta
{
    private decimal _saldo;
    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            _saldo += cantidad;
            Console.WriteLine("Deposito exitoso!");
        } else
        {
            Console.WriteLine("Cantidad invalida");
        }
    }
    public decimal ConsultarSaldo()
    {
        return _saldo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cuenta cuenta = new Cuenta();
        cuenta.Depositar(550);
        Console.WriteLine(cuenta.ConsultarSaldo());
        cuenta.Depositar(550);
        Console.WriteLine(cuenta.ConsultarSaldo());
    }
}