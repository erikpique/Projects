namespace AbstractFactory
{
    public interface IFabricarVehiculo
    {
        //Es gasolina -1:Electrico; 0:Gasolina, 1:Diesel
        Automovil NuevoAutomovil(string modelo, string color, int potencia, double espacio, int esGasolina);
        Scooter NuevaScooter(string modelo, string color, int potencia);
    }
}