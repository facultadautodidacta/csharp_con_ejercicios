



/*
 * 100 -   Crea un juego de memoria 
 * donde el usuario deba recordar 
 * secuencias de números.
*/

class JuegoMemoria
{
    private Random random = new Random();
    private List<int> secuencia = new List<int>();
    public void GenerarSecuencia(int cantidad)
    {
        secuencia.Clear();
        for (int i = 0; i < cantidad; i++)
        {
            secuencia.Add(random.Next(1, 10));
        }
    }

    public void MostrarSecuencia()
    {
        Console.WriteLine("Memoriza esta secuencia");
        foreach (var item in secuencia)
        {
            Console.WriteLine(item + " ");
            Thread.Sleep(700);
        }

        Console.Clear();
    }

    public bool Verificar(string respuestaUsuario)
    {
        string secuenciaCorrecta = string.Join(",", secuencia);
        return respuestaUsuario == secuenciaCorrecta;
    }
}

class Program
{
    static void Main()
    {
        JuegoMemoria juego = new JuegoMemoria();
        juego.GenerarSecuencia(4);
        juego.MostrarSecuencia();
        Console.WriteLine("Escribe la secuencia que viste!!");
        string respuesta = Console.ReadLine();

        if (juego.Verificar(respuesta))
        {
            Console.WriteLine("Correcto, Excelente memoria!!");
        } else
        {
            Console.WriteLine("Incorrecto, sigue practicando!!");
        }
    }
}
