main();
void main()
{
    // 1 forma de crear un nuevo objeto Auto:
    // Auto auto1 = new Auto(); 
    // otra forma:
    // Auto auto1;
    // auto1 = new Auto();
    // otra forma, más habitual:
    Auto auto1 = new();
    auto1.Color = "Rojo"; // set
    string color = auto1.Color; //get
    Console.WriteLine("El auto1 es de color " + color);
}

public class Auto
{
    public string Color { get; set; } // declaración de atributo con sus métodos get y set
    public string Nombre { get; set; }
    public string Matricula { get; set; }
    public string Modelo { get; set; }

}
