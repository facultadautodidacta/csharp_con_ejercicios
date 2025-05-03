class Program
{
    static void Main(string[] args)
    {
        /*
         * 50 - Ordena una lista 
         * de enteros de menor a mayor.
         */

        List<int> numeros = new List<int> { 5, 3, 8, 1 };

        numeros.Sort();

        Console.WriteLine(string.Join(",", numeros));
    }
}