namespace Consola
{
    public class Logger
    {
        private const string LogFileName = "log.txt";
        private static Logger? _instancia;
        private Logger() { }

        public static Logger Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Logger();
                }
                return _instancia;
            }
        }

        public void Log(string message)
        {
            var logMessage = $"{DateTime.Now}: {message}{Environment.NewLine}";
            System.IO.File.AppendAllText(LogFileName, logMessage);
        }
    }
}