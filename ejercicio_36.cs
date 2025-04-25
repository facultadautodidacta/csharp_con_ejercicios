class Program
{
    static void Main(string[] args)
    {
        /*
         * 36 -  Escribe un programa 
         * que use break para salir 
         * de un bucle cuando se 
         * cumpla una condición.
         */

        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Bucle terminado");
                break;
            } else
            {
                Console.WriteLine("Bucle sigue");
            }
        }
    }
}
