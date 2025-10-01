namespace Consola
{
    class Clicker : IClicker
    {
        private int cantidadClicks;

        public Clicker()
        {
            cantidadClicks = 0;
        }

        public void ProcesarClick()
        {
            cantidadClicks++;
        }

        public int ObtenerCantidadClicks()
        {
            return cantidadClicks;
        }
    }
}