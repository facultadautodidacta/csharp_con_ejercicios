

/*
 * 79 -  Escribe una propiedad 
 * que lance una excepción 
 * si se asigna un valor inválido.
*/
class Producto
{
    private decimal _precio;

    public decimal Precio
    {
        get { return _precio; }
        set
        {
            if (value < 0)
            {
                throw new Exception("El precio no puede ser negativo!");
            }

            _precio = value;
        }
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Producto p = new Producto();
            p.Precio = -10;
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}

