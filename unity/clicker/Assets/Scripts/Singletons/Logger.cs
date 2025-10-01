using UnityEngine;

public class MyLogger : MonoBehaviour, IMyLogger
{
    private static MyLogger _instance;
    public static MyLogger Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject loggerObject = new GameObject("Logger");
                _instance = loggerObject.AddComponent<MyLogger>();
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
