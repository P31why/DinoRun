using UnityEngine;

public class DinoStats : MonoBehaviour
{
    private int _score;
    private int _money;
    private int _speed;
    public static DinoStats Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
        
    }
    public int Score
    {
        get => _score;
        set => _score = value;
    }
    public int Money
    {
        get => _money;
        set => _money = value;
    }
    public int Speed
    {
        get => _speed;
        set => _speed = value;
    }
}
