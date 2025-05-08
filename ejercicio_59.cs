class Program
{
    static void cambio(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    static void Main(string[] args)
    {
        /*
         * 59 -   Escribe una función 
         * que use parámetros de referencia.
         */
        int x = 10;
        int y = 20;

        Console.WriteLine($"x={x} y={y}");
        Console.WriteLine("=============");
        cambio(ref x, ref y);
        Console.WriteLine($"x={x} y={y}");
    }
}