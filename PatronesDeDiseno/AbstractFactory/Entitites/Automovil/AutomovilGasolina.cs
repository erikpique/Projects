using System;

namespace AbstractFactory
{
    public class AutomovilGasolina : Automovil
    {
        public AutomovilGasolina(string modelo, string color, int potencia, double espacio, int esGasolina)
            : base(modelo, color, potencia, espacio, esGasolina)
        { }

        public override void mostrarCaracteristicas()
        {
            Console.WriteLine("Automovil Electrico Modelo: " + modelo);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Potencia:" + potencia);
            Console.WriteLine("Espacio: " + espacio);

            switch (esGasolina)
            {
                case -1:
                    Console.Write("Combustible: Eléctrico");
                    break;
                case 0:
                    Console.Write("Combustible: Gasolina");
                    break;
                case 1:
                    Console.Write("Combustible: Diesel");
                    break;
                default:
                    Console.WriteLine("Combustible no especificado");
                    break;
            }
        }
    }
}