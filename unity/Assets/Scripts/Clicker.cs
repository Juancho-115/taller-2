namespace Taller2.Clicker
{
    public class Clicker : IClicker
    {
        private int cantidadClicks;

        public void ProcesarClick()
        {
            cantidadClicks++;
        }

        public int ObtenerCantidadClicks()
        {
            return cantidadClicks;
        }

        public void Reiniciar()
        {
            cantidadClicks = 0;
        }
    }
}