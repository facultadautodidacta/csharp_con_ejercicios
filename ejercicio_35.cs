class Program
{
    static void Main(string[] args)
    {
        /*
         * 35 - Escribe un programa 
         * que recorra un array de 
         * números usando foreach.
         */

        int[] numeros = { 1, 2, 3, 4 };

        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}