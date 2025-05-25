

/*
 * 75 - Crea una excepción personalizada
 * y úsala en un programa.
*/

//eiex = EdadInvalidaExcepcion

class Eiex :Exception
{
    public Eiex(string mensaje) : base(mensaje) { }
}
class Program
{
    static void Main()
    {
        try
        {
            int edad = 10;
            if (edad < 0)
            {
                throw new Eiex("La edad es invalida");
            }
            Console.WriteLine("Edad validad!");
        }
        catch (Eiex ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

