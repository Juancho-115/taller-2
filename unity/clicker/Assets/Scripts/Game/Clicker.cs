using UnityEngine;
using UnityEngine.Events;
using Clicker.Interfaces;
using Clicker.Singletons;

namespace Clicker.Game
{
    public class Clicker : MonoBehaviour, IClicker
    {
        private int _cantidadClicks = 0;

        public Clicker()
        {
            _cantidadClicks = 0;
        }

        private void Start()
        {
            _cantidadClicks = 0;
            Logger.Instance.Log("Clicker inicializado con 0 clicks.");
        }
        public void OnClick()
        {
            _cantidadClicks++;
            Logger.Instance.Log($"Click registrado. Total clicks: {_cantidadClicks}");
        }

        public int ObtenerCantidadClicks()
        {
            return _cantidadClicks;
        }

        public void OnButtonClick()
        {
            OnClick();
        }

        public void ResetClicks()
        {
            _cantidadClicks = 0;
            Logger.Instance.Log("Contador de clicks reseteado a 0.");
        }

        public string ObtenerClicksComoString()
        {
            return _cantidadClicks.ToString();
        }
    }
}