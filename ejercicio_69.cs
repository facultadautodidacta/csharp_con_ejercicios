/*
69 - Crear una clase vehiculo y clase hija Auto, con método MostrarTipo sobrescrito
*/
class Vehiculo
{
    public virtual void MostrarTipo()
    {
        Console.WriteLine("Soy un vehiculo");
    }
}
class Auto : Vehiculo
{
    public override void MostrarTipo()
    {
        Console.WriteLine("Soy un auto");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Auto auto = new Auto();
        auto.MostrarTipo();
    }
}