using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] music;
    private List<MusicDisk> unlMusic;
    private int minMusic = 0;
    private int maxMusic = 4;
    private int currentMusic;
    public void Start()
    {
        unlMusic = DinoStats.Instance.musicUnlock;
        int buff= DinoStats.Instance.PlayFirstUnlockMusic();
        if(buff != -1)
        {
            audioSource.clip = music[buff];
            audioSource.Play();
        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            NextMusic();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            PreviosMusic();
        }
    }
    private void NextMusic()
    {
        ++currentMusic;
        if (currentMusic > maxMusic)
        {
            currentMusic = 0;
            if (unlMusic[currentMusic].acquired)
            {
                audioSource.clip = music[0];
                audioSource.Play();
            }
        }
        else
        {
            if (unlMusic[currentMusic].acquired)
            {
                audioSource.clip = music[currentMusic];
                audioSource.Play();
            }
        }
    }
    private void PreviosMusic()
    {
        --currentMusic;
        if (currentMusic < minMusic)
        {
            currentMusic = 4;
            if (unlMusic[currentMusic].acquired)
            {
                audioSource.clip = music[4];
                audioSource.Play();
            }
        }
        else
        {
            if (unlMusic[currentMusic].acquired)
            {
                audioSource.clip = music[currentMusic];
                audioSource.Play();
            }
        }
    }
}
