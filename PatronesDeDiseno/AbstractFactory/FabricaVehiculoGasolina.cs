namespace AbstractFactory
{
    public class FabricaVehiculoGasolina : IFabricarVehiculo
    {
        public Automovil NuevoAutomovil(string modelo, string color, int potencia, double espacio, int esGasolina)
        {
            return new AutomovilGasolina(modelo, color, potencia, espacio, esGasolina);
        }

        public Scooter NuevaScooter(string modelo, string color, int potencia)
        {
            return new ScooterGasolina(modelo, color, potencia);
        }
    }
}