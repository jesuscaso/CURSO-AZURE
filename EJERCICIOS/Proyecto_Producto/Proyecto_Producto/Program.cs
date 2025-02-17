using System;
using Proyecto_Producto.Negocios.Entidades;
using Proyecto_Producto.Negocios;

class Program
{
    static void Main()
    {
        Negocio_Producto negocioProducto = new Negocio_Producto();
        Negocio_Cliente negocioCliente = new Negocio_Cliente();
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("   GESTIÓN DE PRODUCTOS ");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar todos los productos");
            Console.WriteLine("3. Buscar producto por ID");
            Console.WriteLine("4. Actualizar producto");
            Console.WriteLine("5. Eliminar producto");
            Console.WriteLine("6. Agregar cliente");
            Console.WriteLine("7. Mostrar todos los clientes");
            Console.WriteLine("8. Buscar cliente por ID");
            Console.WriteLine("9. Actualizar cliente");
            Console.WriteLine("10. Eliminar cliente");
            Console.WriteLine("11. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    AgregarProducto(negocioProducto);
                    break;
                case "2":
                    MostrarProductos(negocioProducto);
                    break;
                case "3":
                    BuscarProducto(negocioProducto);
                    break;
                case "4":
                    ActualizarProducto(negocioProducto);
                    break;
                case "5":
                    EliminarProducto(negocioProducto);
                    break;
                case "6":
                    AgregarCliente(negocioCliente);
                    break;
                case "7":
                    MostrarClientes(negocioCliente);
                    break;
                case "8":
                    BuscarCliente(negocioCliente);
                    break;
                case "9":
                    ActualizarCliente(negocioCliente);
                    break;
                case "10":
                    EliminarCliente(negocioCliente);
                    break;
                case "11":
                    salir = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione Enter para continuar...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void AgregarProducto(Negocio_Producto negocio)
    {
        Console.Clear();
        Console.WriteLine("=== Agregar Producto ===");

        Console.Write("Ingrese el ID del producto: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese el precio del producto: ");
        decimal precio = decimal.Parse(Console.ReadLine() ?? "0");

        Producto nuevoProducto = new Producto { Id = id, Nombre = nombre, Precio = precio };

        if (negocio.Create(nuevoProducto))
            Console.WriteLine("Producto agregado con éxito.");
        else
            Console.WriteLine("Error al agregar el producto.");

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

    static void MostrarProductos(Negocio_Producto negocio)
    {
        Console.Clear();
        Console.WriteLine("=== Lista de Productos ===");

        var productos = negocio.ReadAll();
        if (productos.Count > 0)
        {
            foreach (var prod in productos)
            {
                Console.WriteLine($"ID: {prod.Id} | Nombre: {prod.Nombre} | Precio: {prod.Precio:C} Eur.");
            }
        }
        else
        {
            Console.WriteLine("No hay productos registrados.");
        }

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

    static void BuscarProducto(Negocio_Producto negocio)
    {
        Console.Clear();
        Console.WriteLine("=== Buscar Producto ===");

        Console.Write("Ingrese el ID del producto a buscar: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        var producto = negocio.Read(id);
        if (producto != null)
        {
            Console.WriteLine($"ID: {producto.Id} | Nombre: {producto.Nombre} | Precio: {producto.Precio:C}");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

    static void ActualizarProducto(Negocio_Producto negocio)
    {
        Console.Clear();
        Console.WriteLine("=== Actualizar Producto ===");

        Console.Write("Ingrese el ID del producto a actualizar: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ingrese el nuevo nombre del producto: ");
        string nuevoNombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese el nuevo precio del producto: ");
        decimal nuevoPrecio = decimal.Parse(Console.ReadLine() ?? "0");

        Producto productoActualizado = new Producto { Id = id, Nombre = nuevoNombre, Precio = nuevoPrecio };

        if (negocio.Update(productoActualizado))
            Console.WriteLine("Producto actualizado con éxito.");
        else
            Console.WriteLine("No se pudo actualizar el producto.");

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

    static void EliminarProducto(Negocio_Producto negocio)
    {
        Console.Clear();
        Console.WriteLine("=== Eliminar Producto ===");

        Console.Write("Ingrese el ID del producto a eliminar: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Producto producto = new Producto { Id = id };
        if (negocio.Delete(producto))
            Console.WriteLine("Producto eliminado con éxito.");
        else
            Console.WriteLine("No se pudo eliminar el producto.");

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
    static void AgregarCliente(Negocio_Cliente negocio)
    {
        Console.Clear();
        Console.WriteLine("=== Agregar Cliente ===");

        Console.Write("Ingrese el ID del cliente: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese los apellidos del cliente: ");
        string apellidos = Console.ReadLine() ?? "";

        Console.Write("Ingrese los dirección del cliente: ");
        string direccion = Console.ReadLine() ?? "";

        Cliente nuevoCliente = new Cliente { Id = id, Nombre = nombre, Apellidos = apellidos, Direccion = direccion };

        if (negocio.Create(nuevoCliente))
            Console.WriteLine("Cliente agregado con éxito.");
        else
            Console.WriteLine("Error al agregar el cliente.");

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

    static void MostrarClientes(Negocio_Cliente negocio)
    {
        Console.Clear();
        Console.WriteLine("=== Lista de Clientes ===");

        var clientes = negocio.ReadAll();
        if (clientes.Count > 0)
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id} | Nombre: {cliente.Nombre} | Apellidos: {cliente.Apellidos} | Dirección: {cliente.Direccion}");
            }
        }
        else
        {
            Console.WriteLine("No hay clientes registrados.");
        }

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

    static void BuscarCliente(Negocio_Cliente negocio)
    {
        Console.Clear();
        Console.WriteLine("=== Buscar Cliente ===");

        Console.Write("Ingrese el ID del cliente a buscar: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        var cliente = negocio.Read(id);
        if (cliente != null)
        {
            Console.WriteLine($"ID: {cliente.Id} | Nombre: {cliente.Nombre} | Apellidos: {cliente.Apellidos} | Dirección: {cliente.Direccion}");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

    static void ActualizarCliente(Negocio_Cliente negocio)
    {
        Console.Clear();
        Console.WriteLine("=== Actualizar Cliente ===");

        Console.Write("Ingrese el ID del cliente a actualizar: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ingrese el nuevo nombre del cliente: ");
        string nuevoNombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese los nuevos apellidos del cliente: ");
        string nuevosApellidos = Console.ReadLine() ?? "";

        Console.Write("Ingrese la nueva dirección del cliente: ");
        string nuevaDireccion = Console.ReadLine() ?? "";

        Cliente clienteActualizado = new Cliente { Id = id, Nombre = nuevoNombre, Apellidos = nuevosApellidos, Direccion = nuevaDireccion };

        if (negocio.Update(clienteActualizado))
            Console.WriteLine("Cliente actualizado con éxito.");
        else
            Console.WriteLine("No se pudo actualizar el cliente.");

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

    static void EliminarCliente(Negocio_Cliente negocio)
    {
        Console.Clear();
        Console.WriteLine("=== Eliminar Cliente ===");

        Console.Write("Ingrese el ID del cliente a eliminar: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Cliente cliente = new Cliente{ Id = id };
        if (negocio.Delete(cliente))
            Console.WriteLine("Cliente eliminado con éxito.");
        else
            Console.WriteLine("No se pudo eliminar el cliente.");

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}
