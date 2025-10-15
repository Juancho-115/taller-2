using UnityEngine;
using UnityEngine.Events;

namespace Taller2.Clicker
{
    [System.Serializable]
    public sealed class IntEvent : UnityEvent<int> { }

    [DisallowMultipleComponent]
    public class Game : MonoBehaviour
    {
        [SerializeField]
        private bool habilitarLogs;

        [SerializeField]
        private IntEvent alActualizarClicks = new();

        [SerializeField]
        private UnityEvent alReiniciar = new();

        private IClicker? clicker;

        private void Awake()
        {
            EnsureClicker();
            NotificarCambio();
        }

        public void ProcesarClick()
        {
            EnsureClicker();
            clicker!.ProcesarClick();
            NotificarCambio();
            if (habilitarLogs)
            {
                Logger.Instancia.Log($"Se procesó un click. Total: {clicker.ObtenerCantidadClicks()}");
            }
        }

        public void Reiniciar()
        {
            EnsureClicker();
            clicker!.Reiniciar();
            NotificarCambio();
            alReiniciar.Invoke();
            if (habilitarLogs)
            {
                Logger.Instancia.Log("Se reinició el contador de clicks.");
            }
        }

        public int ObtenerCantidadClicks()
        {
            EnsureClicker();
            return clicker!.ObtenerCantidadClicks();
        }

        private void EnsureClicker()
        {
            if (clicker == null)
            {
                clicker = (IClicker)new Clicker();
            }
        }

        private void NotificarCambio()
        {
            alActualizarClicks.Invoke(ObtenerCantidadClicks());
        }
    }
}