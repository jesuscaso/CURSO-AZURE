main();

void main () {
    NegocioCliente negocio_cliente = new NegocioCliente();

    //Ingresar clientes
    for (int i = 0; i < 2; i++)
    {
        Cliente cliente = new Cliente();

        Console.WriteLine("Ingrese el DNI del cliente: ");
        cliente.DNI = Console.ReadLine();

        Console.WriteLine("Ingrese el Nombre del cliente: ");
        cliente.Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el Apellido del cliente: ");
        cliente.Apellido = Console.ReadLine();

        Console.WriteLine("Ingrese la Dirección del cliente: ");
        cliente.Direccion = Console.ReadLine();

        Console.WriteLine("Ingrese el Movil del cliente: ");
        cliente.Movil = Console.ReadLine();

        negocio_cliente.AgregarCliente(cliente);
        Console.Clear();
    }

    //Mostrar clientes
    Cliente[] ClientesActuales = negocio_cliente.MostrarCliente();
    for(int i = 0; i < ClientesActuales.Length; i++)
    {
        Console.WriteLine("DNI: " + ClientesActuales[i].DNI);
        Console.WriteLine("Nombre: " + ClientesActuales[i].Nombre);
        Console.WriteLine("Apellido: " + ClientesActuales[i].Apellido);
        Console.WriteLine("Dirección: " + ClientesActuales[i].Direccion);
        Console.WriteLine("Movil: " + ClientesActuales[i].Movil);
    }

}

class Cliente
{
    public string DNI { get; set; }    
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Movil { get; set; }
}

class NegocioCliente
{
    Cliente[] clientes = new Cliente[2];
    int pos = 0;
    public bool AgregarCliente(Cliente cliente)
    {
        bool estado = false;
        if ( pos < 2)
        {
            clientes[pos] = cliente;
            pos++;
            estado = true;
        }
        return estado;
    }
    public Cliente[] MostrarCliente()
    {
        return clientes;
    }
}