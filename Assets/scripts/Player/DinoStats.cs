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
    public List<MusicDisk> musicUnlock;
    private int _setSkin;
    private int _jumpForce=8;
    private string _path = "save.txt";
    public float volume = 10;
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
            _setSkin = 0;
           skinsUnlock = new List<DinoSkin> { 
                new DinoSkin(0,true,"green"),
                new DinoSkin(1,false,"red"),
                new DinoSkin(2,false,"blue"),
                new DinoSkin(3,false,"yellow"),
            };
            musicUnlock = new List<MusicDisk>
            {
                new MusicDisk(0,false,"EveryBody",2),
                new MusicDisk(1,false,"ColoRU",4),
                new MusicDisk(2,false,"RiseofCheshyr",4),
                new MusicDisk(3,false,"Incedent1000a",5),
                new MusicDisk(4,false,"MC10 OST",20),
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
            _setSkin = pd.playerData.skinSet;
            skinsUnlock = pd.playerData.unlockSkins;
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

[Serializable]
public class MusicDisk
{
    public int musicId;
    public bool acquired;
    public string musicName;
    public int price;
    public MusicDisk() { }
    public MusicDisk(int musicId, bool acquired, string musicName,int price)
    {
        this.musicId = musicId;
        this.acquired = acquired;
        this.musicName = musicName;
        this.price = price;
    }
}
