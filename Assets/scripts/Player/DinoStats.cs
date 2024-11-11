using Assets.scripts.Player;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class DinoStats : MonoBehaviour
{
    private int _score;
    private int _money;
    private int _jumpForce=8;
    private string _path = "save.txt";
    public static DinoStats Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);

        if (!CheckSave())
        {
            _money = 0;
            _score = 0;
            SaveGame();
        }
        else
        {
            LoadGame();
        }
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
    }
    private void LoadGame()
    {
        using(FileStream fs=new FileStream(_path,FileMode.Open))
        {
            
            BinaryFormatter bf = new BinaryFormatter();
            PlayerData pd = (PlayerData)bf.Deserialize(fs);
            _money = pd.playerData.Money;
            _score = pd.playerData.Score;
        }
    }
    public void SaveGame()
    {
        using (FileStream fs=new FileStream(_path,FileMode.Create))
        {
            PlayerData pd = new PlayerData(_score,_money);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,pd);
        }
    }
    public bool CheckSave()
    {
        if (!File.Exists(_path))
        {
            return false;
        }
        return true;
    }
}
