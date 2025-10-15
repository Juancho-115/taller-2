using System;
using UnityEngine;

namespace Taller2.Clicker
{
    public sealed class Logger : ILogger
    {
        private static Logger instancia = null;

        private Logger() { }

        public static Logger Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Logger();
                }
                return instancia;
            }
        }

        public void Log(string message)
        {
            var logMessage = $"{System.DateTime.Now}: {message}";
            UnityEngine.Debug.Log(message);
        }
    }
}