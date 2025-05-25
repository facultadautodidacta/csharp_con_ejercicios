

/*
 * 77 - Escribe un método que 
 * lance una excepción y manéjala 
 * en otro lugar.
*/

class Program
{
    static void Main()
    {
        try
        {
            RegistrarUsuario();
        }
        catch (Exception e) { 
            Console.WriteLine(e.Message);
        }
    }
    static void RegistrarUsuario()
    {
        int edad = 10;

        if (edad < 18)
        {
            throw new Exception("Debes tener 18");
        }
        else {
            Console.WriteLine("Registro exitoso!");
        }
    }

}

