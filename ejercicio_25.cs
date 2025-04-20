class Program
{
    static void Main(string[] args)
    {
        /*
        * 25 - Escribe un programa
        * que verifique si un número
        * es mayor que 10 y menor que 20.
        */
        int numero = 11;
        if (numero > 10 && numero < 20)
        {
            Console.WriteLine("Cumple el rango");
        }
        else 
        {
            Console.WriteLine("No cumple");
        }
    }
}