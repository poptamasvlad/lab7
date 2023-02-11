using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor1 = new Motor(1540, 200, "Benzina");
            NumarDeUsi numarDeUsi1 = new NumarDeUsi(4);
            Autoturism autoturism1 = new Autoturism("Audi", "A5", 2006, motor1, numarDeUsi1);

            Motor motor2 = new Motor(2110, 500, "Diesel");
            NumarDeUsi numarDeUsi2 = new NumarDeUsi(2);
            Autoturism autoturism2 = new Autoturism("Ferrari", "Rosu", 2015, motor2, numarDeUsi2);

            Console.WriteLine(autoturism1.GetDescription());
            autoturism1.PornesteMasina();
            Console.WriteLine(autoturism2.GetDescription());
            autoturism2.OpresteMasina();

            Console.WriteLine(Autoturism.GetNumarAutoturisme());
            Console.WriteLine(Autoturism.GetCelMaiPuternicAutoturism());

        }
    }
}
