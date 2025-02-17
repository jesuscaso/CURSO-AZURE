using Gestion_Cliente_3_Capas.Negocio;
using Gestion_Cliente_3_Capas.Negocio.Entidades;

main();

void main()
{
    // -------------------------------------------------------- //
    // ------------------- AGREGAR CLIENTES ------------------- //
    // -------------------------------------------------------- //
    
    Operaciones_Clientes operaciones_clientes = new Operaciones_Clientes();

    for (int i = 0; i < 3; i++)
    {
        Cliente cliente = new Cliente();
        
        // Pedimos DNI
        Console.WriteLine("Ingrese DNI: ");
        cliente.DNI = Console.ReadLine();

        // Pedimos Nombre
        Console.WriteLine("Ingrese Nombre: ");
        cliente.Nombre = Console.ReadLine();

        // Pedimos Apellido
        Console.WriteLine("Ingrese Apellido: ");
        cliente.Apellido = Console.ReadLine();

        // Pedimos Direccion
        Console.WriteLine("Ingrese Direccion: ");
        cliente.Direccion = Console.ReadLine();

        // Pedimos Movil
        Console.WriteLine("Ingrese Movil: ");
        cliente.Movil = Console.ReadLine();

        bool estado = operaciones_clientes.Agregar_Cliente(cliente);

        if (estado)
        {
            Console.WriteLine("Cliente agregado correctamente");
        }
        else
        {
            Console.WriteLine("Error al agregar cliente");
        }

        Console.ReadKey();
        Console.Clear();
    }

    // ------------------------------------------------------- //
    // ------------------- LISTAR CLIENTES ------------------- //
    // ------------------------------------------------------- //
    
    Cliente[] clientes = operaciones_clientes.Listar_Clientes();

    for (int i = 0; i < clientes.Length; i++)
    {
        Console.WriteLine("DNI: " + clientes[i].DNI);
        Console.WriteLine("Nombre: " + clientes[i].Nombre);
        Console.WriteLine("Apellido: " + clientes[i].Apellido);
        Console.WriteLine("Direccion: " + clientes[i].Direccion);
        Console.WriteLine("Movil: " + clientes[i].Movil);
        Console.WriteLine();
    }
}