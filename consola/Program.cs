namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Clicker clicker = new Clicker();

            System.Console.WriteLine("Presiona Enter para hacer click o 'q' para terminar:");

            while (true)
            {
                var tecla = System.Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Enter)
                {
                    clicker.ProcesarClick();
                    System.Console.WriteLine($"Cantidad de clicks: {clicker.ObtenerCantidadClicks()}");
                }
                else if (tecla.Key == ConsoleKey.Q)
                {
                    break;
                }
            }
        }
    }
}