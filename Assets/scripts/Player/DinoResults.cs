using System.Collections;
using UnityEngine;
using TMPro;

public class DinoResults : MonoBehaviour
{
    [SerializeField] private int _currentScore=0;
    [SerializeField] private TMP_Text _textScore;
    [SerializeField] private GameObject _textobject;
    private void Start()
    {
        StartCoroutine(AddScore());
        _textobject.SetActive(true);
        _textScore.text = "0";
    }
    private void ChangeScoreText()
    {
        _currentScore += 1;
        _textScore.text = _currentScore.ToString();
        if (_currentScore > DinoStats.Instance.Score)
        {
            DinoStats.Instance.Score = _currentScore;
        }
    }
    public int CurrentScore
    {
        get => _currentScore;
        set => _currentScore=value;
    }
    IEnumerator AddScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            ChangeScoreText();
        }
    }
}
