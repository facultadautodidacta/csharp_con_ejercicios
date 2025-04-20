class Program
{
    static void Main(string[] args)
    {
        /*
        * 23 - Escribe un programa
        * que clasifique un número
        * como positivo,
        * negativo o cero.
        */
        Console.WriteLine("Escribe un numero");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El numero es positivo");
        } 
        else if (numero < 0)
        {
            Console.WriteLine("El numero es negativo");
        } 
        else
        {
            Console.WriteLine("El numero es cero");
        }
    }
}