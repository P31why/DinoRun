using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _collectedMoneyText;
    [SerializeField] private DinoResults _dinoScore;
    [SerializeField] private CoinStats _coinScr;
    public void RestartGame()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
    public void ShowStatistics()
    {
        _scoreText.text = _dinoScore.CurrentScore.ToString();
        _collectedMoneyText.text = _coinScr.CurrentMoney.ToString();
        DinoStats.Instance.Money += _coinScr.CurrentMoney;
        DinoStats.Instance.SaveGame();
    }
}
