using System.Collections;
using UnityEngine;
using TMPro;

public class DinoResults : MonoBehaviour
{
    [SerializeField]private int _currentScore=0;
    [SerializeField] private TMP_Text _textScore;
    private void Start()
    {
        StartCoroutine(AddScore());
    }
    IEnumerator AddScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            _currentScore += 1;
            _textScore.text = _currentScore.ToString();
        }
    }
}
