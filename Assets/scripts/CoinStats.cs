using TMPro;
using UnityEngine;

public class CoinStats : MonoBehaviour
{
    [SerializeField] private TMP_Text _textMoney;
    [SerializeField] private int _currentmoney;
    public void AddMoney()
    {
        _currentmoney += 1;
        _textMoney.text = _currentmoney.ToString();
    }
    public int CurrentMoney
    {
        get => _currentmoney;
    }
}
