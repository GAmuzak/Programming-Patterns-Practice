using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    private int score;
    public int Score => score;

    public static GameManager Instance
    {
        get
        {
            if (_instance != null) return _instance;
            _instance = FindObjectOfType<GameManager>();
            if (_instance != null) return _instance;
            GameObject gg = new GameObject();
            gg.AddComponent<GameManager>();
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
        _instance = this;
    }
    
    public void AddCoin()
    {
        score += 1;
    }
}
