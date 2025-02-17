using Proyecto_Producto.Negocios.Entidades;
using Proyecto_Producto.Negocios;
main();

void main()
{
    Negocio_Producto negocio_producto = new Negocio_Producto();

    //Ingresar productos
    for (int i = 0; i < 3; i++)
    {
        Producto producto = new Producto();

        Console.WriteLine("Ingrese el ID");
        producto.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el Nombre");
        producto.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el Precio");
        producto.Precio = decimal.Parse(Console.ReadLine());

        bool estado = negocio_producto.GuardarProducto(producto);

        if (estado)
        {
            Console.WriteLine("Producto guardado");
        }
        else
        {
            Console.WriteLine("Producto no guardado");
        }

        Console.ReadKey();
        Console.Clear();
    }

    //Mostrar Productos actuales
    Producto[] productosActuales = negocio_producto.ListarProductos();

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Id: " + productosActuales[i].Id);
        Console.WriteLine("Nombre: " + productosActuales[i].Nombre);
        Console.WriteLine("Precio: " + productosActuales[i].Precio);
    }

}

//class Producto
//{
//    public int Id { get; set; }
//    public string Nombre { get; set; }
//    public decimal Precio { get; set; }
//}

//class Negocio_Producto
//{
//    Producto[] productos = new Producto[3];
//    int pos = 0;
//    public bool GuardarProducto(Producto producto)
//    {
//        bool estado = false;
//        if (pos < 3)
//        {
//            productos[pos] = producto;
//            pos++;
//            estado = true;
//        }
//        return estado;
//    }

//    public Producto[] ListarProductos()
//    {
//        return productos;
//    }
//}