using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Clicker : MonoBehaviour, IClicker
{
    private int _cantidadClicks = 0;

    public Text contadorClicksText;

    public Clicker()
    {
        _cantidadClicks = 0;
    }

    private void Start()
    {
        _cantidadClicks = 0;
        MyLogger.Instance.Log("Clicker inicializado con 0 clicks.");
        Update();
    }
    public void OnClick()
    {
        _cantidadClicks++;
        MyLogger.Instance.Log($"Click registrado. Total clicks: {_cantidadClicks}");
        Update();
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
        MyLogger.Instance.Log("Contador de clicks reseteado a 0.");
        Update();
    }

    public string ObtenerClicksComoString()
    {
        return _cantidadClicks.ToString();
    }

    private void Update()
    {
        if (contadorClicksText != null)
        {
            contadorClicksText.text = _cantidadClicks.ToString();
        }
    }
}