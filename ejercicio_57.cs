class Program
{
    static int sumar(int a, int b)
    {
        return a + b;
    }
    static int sumar(int a, int b, int c)
    {
        return (a + b + c);
    }

    static void Main(string[] args)
    {
        /*
         * 57 - Escribe dos funciones 
         * con el mismo nombre 
         * pero diferentes parámetros.
         */
        
        Console.WriteLine(sumar(1, 2, 88));
    }
}