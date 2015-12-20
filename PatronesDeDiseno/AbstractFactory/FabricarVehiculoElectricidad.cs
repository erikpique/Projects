using System.Runtime.CompilerServices;

namespace AbstractFactory
{
    public class FabricarVehiculoElectricidad : IFabricarVehiculo
    {
        public Automovil NuevoAutomovil(string modelo, string color, int potencia, double espacio, int esGasolina)
        {
            return new AutomovilElectrico(modelo, color, potencia, espacio, esGasolina);
        }

        public Scooter NuevaScooter(string modelo, string color, int potencia)
        {
            return new ScooterElectrico(modelo, color, potencia);
        }
    }
}