using System;

namespace AbstractFactory
{
    public class ScooterGasolina : Scooter
    {
        public ScooterGasolina(string modelo, string color, int potencia) 
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