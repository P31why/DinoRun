using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    private void Awake()
    {
        Time.timeScale = 1;
        _pauseMenu.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.W))
        {
            GamePause();
        }
    }
    private void GamePause()
    {
        Time.timeScale = 0;
        _pauseMenu.SetActive(true);
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
        _pauseMenu.SetActive(false);
    }
    public void ExiteGame()
    {
        SceneManager.LoadScene(0);
        DinoStats.Instance.SaveGame();
    }
}
