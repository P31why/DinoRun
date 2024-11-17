using Assets.scripts.Player;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class DinoStats : MonoBehaviour
{
    private int _score;
    private int _money;
    public List<DinoSkin> skinsUnlock;
    private int _setSkin=-1;
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
            skinsUnlock = new List<DinoSkin> { 
                new DinoSkin(0,true,"green"),
                new DinoSkin(1,false,"red"),
                new DinoSkin(2,false,"blue"),
                new DinoSkin(3,false,"yellow"),
            };
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
    public int SetSkin
    {
        get => _setSkin;
        set => _setSkin = value;
    }
    public void GetUnlockSkins()
    {
        
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
            PlayerData pd = new PlayerData(_score,_money,skinsUnlock,_setSkin);
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
[Serializable]
public class DinoSkin
{
    public int skinId;
    public bool acquired;
    public string skinName;
    public DinoSkin() { }
    public DinoSkin(int id, bool ac, string name)
    {
        skinId = id;
        acquired = ac;
        skinName = name;
    }
}
