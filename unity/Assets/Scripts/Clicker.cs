namespace Taller2.Clicker
{
    public class Clicker
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