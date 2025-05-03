class Program
{
    static void Main(string[] args)
    {
        /*
         * 48 - Suma todos los elementos
         * de una lista de enteros.
         */

        List<int> numeros = new List<int> { 1,2,3,4 };
        int totalSuma = 0;
        foreach (int num in numeros) 
        {
            totalSuma += num;
        }

        Console.WriteLine(totalSuma);

    }
}