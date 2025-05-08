class Program
{
    static int factorial(int numero)
    {
        if (numero <= 1)
        {
            return 1;
        }

        return numero * factorial(numero - 1);
    }
    static void Main(string[] args)
    {
        /*
         * 56 - Escribe una función 
         * recursiva que calcule el
         * factorial de un número.
         */
        Console.WriteLine(factorial(5));

    }
}