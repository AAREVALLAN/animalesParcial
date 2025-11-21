using System;

class Program
{
    static void Main(string[] args)
    {
        Animal miPerro = new Perro("Max", 3);
        Animal miGato = new Gato("Luna", 2);
        Animal miLeon = new Leon("Simba", 5);

        miPerro.MostrarInformacion();
        miPerro.EmitirSonido();

        Console.WriteLine();

        miGato.MostrarInformacion();
        miGato.EmitirSonido();

        Console.WriteLine();

        miLeon.MostrarInformacion();
        miLeon.EmitirSonido();
    }
}
