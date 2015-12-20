using System;

namespace AbstractFactory
{
    public class AutomovilElectrico : Automovil
    {
        public AutomovilElectrico(string modelo, string color, int potencia, double espacio, int esGasolina=-1)
            : base(modelo, color, potencia, espacio, esGasolina)
        { }

        public override void mostrarCaracteristicas()
        {
            Console.WriteLine("Automovil Electrico Modelo: " + modelo);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Potencia:" + potencia);
            Console.WriteLine("Espacio: " + espacio);
        }
    }
}