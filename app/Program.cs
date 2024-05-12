namespace app;

class Program
{
    static void Main(string[] args)
    {
        Usuario usuario1 = new(1,"Juan","Perez","juan.perez","1234","juan.perez@mail.com");
        Producto producto1 = new(1, "Computadora", 1000000.00f, 1500000.00f, 10, 1);
        ProductoVendido productoVendido1 = new(1, 1, 2, 1);
        Venta venta1 = new(1, "2 x Computadora", 1);

        Console.WriteLine(producto1.Costo);

        Console.WriteLine("{0}{1}{2}{3}",
            usuario1, producto1, productoVendido1, venta1);
    }
}
