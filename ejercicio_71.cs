/*
 * 71 - Divide dos números 
 * y maneja la excepción de 
 * división por cero
*/

class Division
{
    public void Dividir(int a, int b)
    {
        try
        {
            int r = 0;
            r = a / b;
            Console.WriteLine(r);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("no hay division por cero");
        }
    }
}
class Program
{
    static void Main()
    {
        Division division = new Division();
        division.Dividir(10,2);
        division.Dividir(10,0);
    }
}