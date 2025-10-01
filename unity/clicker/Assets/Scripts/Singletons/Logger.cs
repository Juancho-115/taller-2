using UnityEngine;

public class Logger : MonoBehaviour, clicker.Interfaces.ILogger
{
    private static Logger _instance;
    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject loggerObject = new GameObject("Logger");
                _instance = loggerObject.AddComponent<Logger>();
                DontDestroyOnLoad(loggerObject);
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void Log(string message)
    {
        Debug.Log(message);
    }
}