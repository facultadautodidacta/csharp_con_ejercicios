class Program
{
    static void duplicar(int numero, out int resultado)
    {
        resultado = numero * numero;
    }
    static void Main(string[] args)
    {
        /*
         * 58 -  Escribe una función 
         * que use parámetros de salida.
         */

        duplicar(5, out int r);
        Console.WriteLine(r);
    }
}