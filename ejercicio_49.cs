class Program
{
    static void Main(string[] args)
    {
        /*
         * 49 - Busca un elemento 
         * en una lista de enteros.
         */

        List<int> numeros = new List<int> { 11,28,3,4 };

        int elementoBuscar = 29;

        foreach (int numero in numeros) 
        {
            if (elementoBuscar == numero)
            {
                Console.WriteLine("Encontrado!");
            }
        }
    }
}