class Program
{
    static void Main(string[] args)
    {
        /*
         * 40 -  Escribe un programa
         * que no permite salir sin 
         * confirmación
         */

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Desea salir?? S/N");
            string sino = Console.ReadLine();
            if (sino == "S" || sino == "s")
            {
                break;
            }
        }

        Console.WriteLine("Salimos!!");

    }
}
