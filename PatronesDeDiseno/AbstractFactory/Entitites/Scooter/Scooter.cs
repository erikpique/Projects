namespace AbstractFactory
{
    public abstract class Scooter
    {
        protected string modelo;
        protected string color;
        protected int    potencia;

        public Scooter(string _modelo, string _color, int _potencia)
        {
            modelo     = _modelo;
            potencia   = _potencia;
            color      = _color;

        }
        public abstract void mostrarCaracteristicas();
    }
}