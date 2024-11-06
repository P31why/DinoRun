using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _storeMenu;
    private void Awake()
    {
        _mainMenu.SetActive(true);
        _storeMenu.SetActive(false);
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
