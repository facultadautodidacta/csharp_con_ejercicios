class Program
{
    static void Main(string[] args)
    {
        /*
         * 39 -  Escribe un programa 
         * que imprima las tablas de 
         * multiplicar usando 
         * bucles for anidados.
         */

        for (int tabla = 1; tabla < 11; tabla++)
        {
            for (int m = 1; m < 11; m++)
            {
                int r = tabla * m;
                Console.WriteLine(tabla + "x" + m + "=" + r);
            }
            Console.WriteLine("===============");
        }

    }
}
