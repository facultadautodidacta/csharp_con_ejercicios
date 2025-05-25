



/*
 * 83 -  Agregar texto a un archivo existente
*/

using System.IO;
public class Archivo
{
    public void Editar(string ruta, string texto)
    {
        File.AppendAllText(ruta, texto + Environment.NewLine);
        Console.WriteLine("Texto agregado!!");
    }
}
class Program
{
    static void Main()
    {
        string ruta = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\archivos\\archivo.txt";
        Archivo archivo = new Archivo();
        archivo.Editar(ruta, "hola de nuevo");
    }
}
