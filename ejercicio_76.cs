

/*
 * 76 - Escribe un programa que 
 * use throw para relanzar una 
 * excepción.
*/

class Program
{
    static void Main()
    {
        try
        {
            LanzarError();
        }
        catch (Exception e) 
        { 
            Console.WriteLine(e.Message);
        }
    }

    static void LanzarError()
    {
        try
        {
            throw new Exception("Esto es un error");
        } catch
        {
            Console.WriteLine("Error detectado, lo paso al main");
            throw;
        }
    }
}

