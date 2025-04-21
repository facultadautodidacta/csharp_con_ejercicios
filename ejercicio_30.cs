class Program
{
    static void Main(string[] args)
    {
        /*
         * 30 -   Escribe un programa
         * que use break y 
         * continue en un bucle.
         */

        for (int i = 0; i < 10; i++)
        {
            if (i == 2)
            {
                Console.WriteLine("salto la it 2");
                continue;
            }

            if (i == 7)
            {
                Console.WriteLine("Termino el bucle");
                break;
            }

            Console.WriteLine(i);
        }
    }
}