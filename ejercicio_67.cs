/*
    * 67 - Usa propiedades con 
    * getters y setters en la clase 
    * Persona.
*/

class Persona
{
    private string _nombre;
    private int _edad;
    public string Nombre 
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public int Edad 
    {
        get { return _edad; }
        set {
            if(value >= 0) _edad = value;
        }
    }
    public virtual string saludar()
    {
        return $"Hola {this.Nombre}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Nombre = "Roldan";
        Console.WriteLine(persona.saludar());
    }
}