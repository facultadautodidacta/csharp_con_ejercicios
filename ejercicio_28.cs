class Program
{
    static void Main(string[] args)
    {
        /*
         * 28 -  Escribe un programa que 
         * use switch para determinar 
         * el tipo de fruta basado en una cadena.
         */

        string fruta = "limon";
        string tipo = "";

        switch (fruta)
        {
            case "limon":
            case "kiwi":
                tipo = "Frutas Acidas";
                break;
            case "fresa":
            case "mango":
                tipo = "Frutas Semiacidas";
                break;
            default:
                tipo = "No tiene tipo";
                break;
        }

        Console.WriteLine(fruta + "||" + tipo);
    }
}