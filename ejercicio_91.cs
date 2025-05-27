/*
 * 91 -  Crea una calculadora 
 * que sume, reste, multiplique y divida.
*/

class Calculadora
{
    public double Sumar(double a, double b) => a + b;
    public double Restar(double a, double b) => a - b;
    public double Multiplicar(double a, double b) => a * b;
    public double Dividir(double a, double b) => a / b;
}
class Program
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();
        Console.WriteLine("suma " + calculadora.Sumar(10,5));
        Console.WriteLine("resta " + calculadora.Restar(10, 5));
        Console.WriteLine("multiplicar " + calculadora.Multiplicar(10, 5));
        Console.WriteLine("dividir " + calculadora.Dividir(10, 5));
    }
}
