class Program
{
    static void mostrarInfo<T>(T dato)
    {
        Console.WriteLine($"Tipo {typeof(T).Name}");
    }
    static void Main(string[] args)
    {
        /*
         * 60 -  Escribe una función
         * que use parámetros 
         * de tipo genérico.
         */

        mostrarInfo(10);
        mostrarInfo(true);
        mostrarInfo(3.14);
    }
}