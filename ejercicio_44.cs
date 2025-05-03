class Program
{
    static void Main(string[] args)
    {
        /*
         * 44 - Busca un elemento en 
         * un array de enteros.
         */

        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int elementoBuscar = 11;

        foreach (int numero in numeros) 
        {
            if (elementoBuscar == numero)
            {
                Console.WriteLine("Encontrado!!");
            } 
        }
    }
}