



/*
 * 98 -  Crea una aplicación 
 * que simule operaciones bancarias básicas.
*/

class CuentaBancaria
{
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public CuentaBancaria(string titular, double saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }
    public void Depositar(double monto)
    {
        Saldo += monto;
        Console.WriteLine($"Depositaste ${monto}. Saldo actual ${Saldo}");
    }
    public void Retirar(double monto)
    {
        if (monto <= Saldo)
        {
            Saldo -= monto;
            Console.WriteLine($"Retiraste ${monto}. Saldo actual ${Saldo}");
        } else
        {
            Console.WriteLine("No te alcanza!!");
        }
    }
    public void MostrarSaldo()
    {
        Console.WriteLine($"Titular: {Titular}, Saldo ${Saldo}");
    }
}
class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria("Carlos", 100);
        cuenta.MostrarSaldo();
        cuenta.Depositar(500);
        cuenta.Retirar(200);
        cuenta.Retirar(2000);
    }
}
