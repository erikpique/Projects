namespace AbstractFactory
{
    public abstract class Automovil
    {
        protected string modelo;
        protected string color;
        protected int    potencia; 
        protected double espacio;
        protected int    esGasolina;

        public Automovil(string _modelo, string _color, int _potencia, double _espacio, int _esGasolina)
        {
            modelo      = _modelo;
            color       = _color;
            potencia    = _potencia;
            espacio     = _espacio;
            esGasolina  = _esGasolina;
        }
        public abstract void mostrarCaracteristicas();
    }  
}
