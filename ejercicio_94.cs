
/*
 * 94 -  Crea una aplicación que
 * permita registrar y mostrar usuarios.

*/
class Usuario
{
    public string Nombre { get; set; }
    public string Email { get; set; }
    public void Mostrar()
    {
        Console.WriteLine($"Nombre {Nombre}, Email {Email}");
    }
}
class RegistrarUsuarios
{
    private List<Usuario> usuarios = new List<Usuario>();
    public void Registrar(string nombre, string email)
    {
        Usuario usuario = new Usuario();
        usuario.Nombre = nombre;
        usuario.Email = email;
        usuarios.Add(usuario);
    }
    public void MostrarUsuarios()
    {
        Console.WriteLine("Usuarios registrados");
        foreach (var item in usuarios)
        {
            item.Mostrar();
        }
    }
}
class Program
{
    static void Main()
    {
        RegistrarUsuarios usuarios = new RegistrarUsuarios();
        usuarios.Registrar("Ana", "ana@gmail.com");
        usuarios.Registrar("Juan", "juan@gmail.com");
        usuarios.MostrarUsuarios();
    }
}
