using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterTextDisplay : MonoBehaviour
{
    private Text? counterText;

    private void Awake()
    {
        counterText = GetComponent<Text>();
    }

    public void UpdateCounter(int newCount)
    {
        if (counterText == null)
        {
            counterText = GetComponent<Text>();
        }
        counterText.text = $"Clicks: {newCount.ToString()}";
    }
}
