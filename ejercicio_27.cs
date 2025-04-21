class Program
{
    static void Main(string[] args)
    {
        /*
         * 27 -  Escribe un programa 
         * que use switch 
         * para determinar 
         * el día de la semana 
         * basado en un número.
         */

        //1 lunes

        int dia = 10;

        switch (dia)
        {
            case 1:
                Console.WriteLine("Es lunes");
                break;
            case 2:
                Console.WriteLine("Es martes");
                break;
            case 3:
                Console.WriteLine("Es miercoles");
                break;
            case 4:
                Console.WriteLine("Es jueves");
                break;
            case 5:
                Console.WriteLine("Es viernes");
                break;
            case 6:
                Console.WriteLine("Es sabado");
                break;
            case 7:
                Console.WriteLine("Es domingo");
                break;
            default:
                Console.WriteLine("No es un dia valido");
                break ;
        }

    }
}