class Program
{
    static void Main(string[] args)
    {
        /*
         * 29 -  Escribe un programa 
         * que use goto para saltar 
         * a una etiqueta.
         */

        Console.WriteLine("Inicio del programa");
        //salta directamente a la etiqueta
        goto salto;
        Console.WriteLine("No se muestra");
        salto:

        Console.WriteLine("Hemos saltado con goto");
    }
}