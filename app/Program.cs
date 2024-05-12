namespace app;

class Program
{
    static void Main(string[] args)
    {
        Usuario usuario1 = new();
        Producto producto1 = new();
        ProductoVendido productoVendido1 = new();
        Venta venta1 = new();

        Console.WriteLine("{0}{1}{2}{3}",
            usuario1, producto1, productoVendido1, venta1);
    }
}
