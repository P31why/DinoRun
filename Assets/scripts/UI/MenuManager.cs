using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _storeMenu;
    [SerializeField] private GameObject _storeSkins;
    [SerializeField] private GameObject _storeMusic;
    [SerializeField] private TMP_Text _bestTextScore;
    private void Awake()
    {
        _mainMenu.SetActive(true);
        _storeMenu.SetActive(false);
        _storeSkins.SetActive(false);
        _storeMusic.SetActive(false);
    }
    private void Start()
    {
        _bestTextScore.text = "Рекорд: "+DinoStats.Instance.Score.ToString();
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
