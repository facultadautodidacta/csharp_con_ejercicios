

/*
 * 74 - Escribe un programa que 
 * lance una excepción manualmente
 * para validar la edad
*/

class Validar
{
    public void ValidarEdad(int edad)
    {
        try
        {
            if (edad < 0 || edad > 120)
            {
                throw new Exception("Edad invalida!!");
            }

            Console.WriteLine("Edad Valida!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
class Program
{
    static void Main()
    {
        Validar edad = new Validar();
        edad.ValidarEdad(5);
        edad.ValidarEdad(-5);
    }
}

