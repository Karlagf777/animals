class Perro : Animal
{
    public string Raza;
    public Perro (string nombre, int edad, string raza) : base (nombre, edad)
    {
        Raza = raza;
    }
    public new void HacerSonido()
    {
        Console.WriteLine(Nombre + " dice: ¡Guau!");
    }
    public void Buscar()
    {
        Console.WriteLine(Nombre + " esta buscando algo...");
    }
}

class Program
{
    static void Main()
    {
        Perro miPerro = new Perro("Akira",4,"Pastor Belga");
        miPerro.MostrarInfo();
        miPerro.HacerSonido();
        miPerro.Buscar();

        Console.WriteLine("Raza:" + miPerro.Raza);
    }
}