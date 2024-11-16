using System.Collections;
using TMPro;
using UnityEngine;

public class CoinStats : MonoBehaviour
{
    [SerializeField] private TMP_Text _textMoney;
    [SerializeField] private int _currentmoney;
    private bool _doubleMoney = false;
    public bool DoubleMoney
    {
        get => _doubleMoney;
        set => _doubleMoney = value;
    }
    public void DoubleMoneyON()
    {
        _doubleMoney = true;
        StartCoroutine(x2coins());
    }
    public void AddMoney()
    {
        if (_doubleMoney)
        {
            _currentmoney += 5;
            _textMoney.text = _currentmoney.ToString();
        }
        else
        {
            _currentmoney += 1;
            _textMoney.text = _currentmoney.ToString();
        }

    }
    public int CurrentMoney
    {
        get => _currentmoney;
    }
    IEnumerator x2coins()
    {
        yield return new WaitForSeconds(12);
        _doubleMoney = false;
    }
}
