



/*
 * 96 -  Crea un programa que genere 
 * contraseñas aleatorias.

*/

class GenerarPassword
{
    private const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
    private Random random = new Random();
    public string Generar(int longitud)
    {
        string password = "";
        for (int i = 0; i < longitud; i++)
        {
            password = password + caracteres[random.Next(caracteres.Length)];
        }

        return password;
    }
}

class Program
{
    static void Main()
    {
        GenerarPassword password = new GenerarPassword();
        string contrasena = password.Generar(8);
        Console.WriteLine(contrasena);
    }
}
