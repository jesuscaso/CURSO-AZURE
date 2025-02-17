using Herencia;

main();

void main()
{
    Perro perro = new Perro();
    // Perro perro = new (); // otra forma de crear una instancia, pero solo en el caso de que san del mismo tipo
    perro.Ladrar = "guau guau";
    Console.WriteLine(perro.Caminar());
}