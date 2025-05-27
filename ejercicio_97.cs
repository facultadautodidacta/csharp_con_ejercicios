



/*
 * 97 -  Crea un juego de piedra, 
 * papel o tijera contra la computadora.
*/

class JuegoPPT
{
    private string[] opciones = {"piedra", "papel", "tijera"};
    private Random random = new Random();
    public void Jugar(string jugador)
    {
        string compu = opciones[random.Next(opciones.Length)];
        Console.WriteLine("Compu eligio " + compu);

        if (jugador == compu)
        {
            Console.WriteLine("Empate!!");
        }
        else if (jugador == "piedra" && compu == "tijera" ||
                 jugador == "papel" && compu == "piedra" ||
                 jugador == "tijera" && compu == "papel")
        {
            Console.WriteLine("Tu ganas!!");
        }
        else
        {
            Console.WriteLine("Tu pierdes!");
        }
    }
}
class Program
{
    static void Main()
    {
        JuegoPPT juegoPPT = new JuegoPPT();
        Console.WriteLine("Escribe piedra, papel o tijera");
        string seleccion = Console.ReadLine().ToLower();

        juegoPPT.Jugar(seleccion);
    }
}
