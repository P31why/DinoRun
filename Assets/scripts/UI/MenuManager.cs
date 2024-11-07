using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _storeMenu;
    [SerializeField] private GameObject _storeSkins;
    [SerializeField] private GameObject _storeMusic;
    private void Awake()
    {
        _mainMenu.SetActive(true);
        _storeMenu.SetActive(false);
        _storeSkins.SetActive(false);
        _storeMusic.SetActive(false);
    }
    public void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuiteGame()
    {
        Application.Quit();
    }
}
