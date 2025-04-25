class Program
{
    static void Main(string[] args)
    {
        /*
         * 37 -  Escribe un programa 
         * que use continue para 
         * saltar una iteración en un bucle 
         * cuando sea número par.
         */

        for (int i = 0; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("continuar " + i);
                continue;
            } else
            {
                Console.WriteLine(i);
            }
        }

    }
}
