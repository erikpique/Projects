using System;

namespace AbstractFactory
{
    public class ScooterElectrico : Scooter
    {
        public ScooterElectrico(string modelo, string color, int potencia) 
            :base (modelo, color, potencia)
        { }

        public override void mostrarCaracteristicas()
        {
            Console.WriteLine("Scooter Electrico Modelo: " + modelo);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Potencia:" + potencia);
        }
    }
}