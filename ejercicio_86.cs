



/*
 * 86 -  Escribe un programa para 
 * eliminar un archivo
*/

using System.IO;
public class Archivo
{
   public void Eliminar(string ruta)
   {
        if (File.Exists(ruta))
        {
            File.Delete(ruta);
            Console.WriteLine("Eliminado!!");
        } else
        {
            Console.WriteLine("El archivo no existe!");
        }
   }
}
class Program
{
    static void Main()
    {
        string ruta = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\movidos\\archivo2.txt";
        Archivo archivo = new Archivo();
        archivo.Eliminar(ruta);

    }
}
