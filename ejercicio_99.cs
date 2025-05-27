



/*
 * 99 -  Crea una aplicación 
 * que permita gestionar una lista de contactos.

*/

class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public void Mostrar()
    {
        Console.WriteLine($"Nombre: {Nombre} , Telefono {Telefono}");
    }
}
class GestorContactos
{
    private List<Contacto> contactos = new List<Contacto>();
    public void AgregarContacto(string nombre, string telefono)
    {
        Contacto c = new Contacto();
        c.Nombre = nombre;
        c.Telefono = telefono;
        contactos.Add(c);
    }
    public void MostrarContactos()
    {
        Console.WriteLine("Listado de contactos");
        foreach (var item in contactos)
        {
            item.Mostrar();
        }
    }
}

class Program
{
    static void Main()
    {
        GestorContactos gestor = new GestorContactos();
        gestor.AgregarContacto("Roldan", "4569879");
        gestor.AgregarContacto("Laura", "676846874");

        gestor.MostrarContactos();
    }
}
