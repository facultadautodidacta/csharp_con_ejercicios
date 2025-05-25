

/*
 * 78 - Escribe un constructor
 * que lance una excepción
 * y manéjala.
*/
class Persona
{
    public Persona(string nombre)
    {
        if (string.IsNullOrEmpty(nombre))
        {
            throw new ArgumentException("El nombre no puede estar vacio!!");
        }
    }
} 
class Program
{
    static void Main()
    {
        try
        {
            Persona persona = new Persona("Rol");
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        
    }
}

