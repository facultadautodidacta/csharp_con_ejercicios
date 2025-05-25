/*
 * 73 - Escribe un programa que 
 * use finally para ejecutar código 
 * después de un try-catch.
*/

class Archivo
{
    public void ProcesaArchivo(bool causaError)
    {
        Console.WriteLine("Abriendo ...");
        try
        {
            if (causaError) 
            {
                throw new Exception("Error simulado");
            }
            Console.WriteLine("Procesado con exito!!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error {ex.Message}");
        } 
        finally
        {
            Console.WriteLine("Cerrando archivo...");
        }
    }
}
class Program
{
    static void Main()
    {
        Archivo archivo = new Archivo();
        archivo.ProcesaArchivo(true);
        archivo.ProcesaArchivo(false);
    }
}
