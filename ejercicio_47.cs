class Program
{
    static void Main(string[] args)
    {
        /*
         * 47 - Recorre una lista de 
         * enteros y muestra sus valores.
         */

        List<int> numeros = new List<int>();
        numeros.Add(8);
        numeros.Add(5);
        numeros.Add(10);

        foreach (int i in numeros) 
        {
            Console.WriteLine(i);
        }

    }
}