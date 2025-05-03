class Program
{
    static void Main(string[] args)
    {
        /*
         * 42 - Recorre un array 
         * de enteros y muestra sus valores.
         */

        int[] numeros = { 9, 2, 3, 4, 5 };

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}