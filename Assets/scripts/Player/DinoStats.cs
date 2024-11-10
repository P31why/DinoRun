using UnityEngine;

public class DinoStats : MonoBehaviour
{
    private int _score;
    private int _money;
    private int _jumpForce=6;
    public static DinoStats Instance { get; private set; }
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
    public int JumpForce
    {
        get => _jumpForce;
        set => _jumpForce = value;
    }
}
