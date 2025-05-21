
/*
    * 65 - Crea una clase Estudiante 
    * que herede de Persona y 
    * añade una propiedad Matricula.
*/
class Estudiante : Persona
{
    public string Matricula { get; set; }
}
class Persona
{
    public string Nombre { get; set; }
    public int Edad {  get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();
        estudiante.Nombre = "Roldan";
        estudiante.Matricula = "123456";

        Console.WriteLine(estudiante.Nombre);
        Console.WriteLine(estudiante.Matricula);
    }
}