using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class StoreDino : MonoBehaviour
{
    [SerializeField] private TMP_Text _aplGreenText;
    [SerializeField] private TMP_Text _buyRedText;
    [SerializeField] private TMP_Text _aplRedText;
    [SerializeField] private TMP_Text _buyBlueText;
    [SerializeField] private TMP_Text _aplBlueText;
    [SerializeField] private TMP_Text _buyYellowText;
    [SerializeField] private TMP_Text _aplYellowText;
    [SerializeField] private TMP_Text _moneyCountText;

    public void LoadStore()
    {
        List<DinoSkin> buff = DinoStats.Instance.skinsUnlock;
        foreach (DinoSkin i in buff)
        {
            if (i.skinId == 1 && i.acquired)
            {
                _buyRedText.text = "Куплено";
            }
            else if (i.skinId == 1 && !i.acquired)
            {
                _buyRedText.text = "Купить за 10$";
            }

            if (i.skinId == 2 && i.acquired)
            {
                _buyBlueText.text = "Куплено";
            }
            else if (i.skinId == 1 && !i.acquired)
            {
                _buyBlueText.text = "Купить за 40$";
            }

            if (i.skinId == 3 && i.acquired)
            {
                _buyYellowText.text = "Куплено";
            }
            else if (i.skinId == 1 && !i.acquired)
            {
                _buyYellowText.text = "Купить за 30$";
            }
        }


        if (DinoStats.Instance.SetSkin == 0)
        {
            _aplGreenText.text = "Выбрано";
        }
        else if (DinoStats.Instance.SetSkin == 1)
        {
            _aplRedText.text = "Выбрано";
        }
        else if (DinoStats.Instance.SetSkin == 2)
        {
            _aplBlueText.text = "Выбрано";
        }
        else if (DinoStats.Instance.SetSkin == 3)
        {
            _aplYellowText.text = "Выбрано";
        }
        Debug.Log(DinoStats.Instance.SetSkin);
        _moneyCountText.text = DinoStats.Instance.Money.ToString();
    }

    public void AplGreenDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[0].acquired)
        {
            DinoStats.Instance.SetSkin = 0;
            _aplGreenText.text = "Выбрано";
            _aplRedText.text = "Применить";
            _aplBlueText.text = "Применить";
            _aplYellowText.text = "Применить";
        }
    }
    public void BuyRedDino()
    {
        if (!DinoStats.Instance.skinsUnlock[1].acquired && DinoStats.Instance.Money>=10)
        {
            DinoStats.Instance.skinsUnlock[1].acquired = true;
            DinoStats.Instance.Money -= 10;
            _buyRedText.text = "Куплено";
            _moneyCountText.text = DinoStats.Instance.Money.ToString();
            DinoStats.Instance.SaveGame();
        }
    }
    public void AplRedDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[1].acquired)
        {
            DinoStats.Instance.SetSkin = 1;
            _aplRedText.text = "Выбрано";
            _aplGreenText.text = "Применить";
            _aplBlueText.text = "Применить";
            _aplYellowText.text = "Применить";

        }
    }
    public void BuyBlueDino()
    {
        if (!DinoStats.Instance.skinsUnlock[2].acquired && DinoStats.Instance.Money>=40)
        {
            DinoStats.Instance.skinsUnlock[2].acquired = true;
            DinoStats.Instance.Money -= 40;
            _moneyCountText.text = DinoStats.Instance.Money.ToString();
            _buyBlueText.text = "Куплено";
            DinoStats.Instance.SaveGame();
        }
    }
    public void AplBlueDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[2].acquired)
        {
            DinoStats.Instance.SetSkin = 2;
            _aplBlueText.text = "Выбрано";
            _aplGreenText.text = "Применить";
            _aplRedText.text = "Применить";
            _aplYellowText.text = "Применить";
        }
    }
    public void BuyYellowDino()
    {
        if (!DinoStats.Instance.skinsUnlock[3].acquired && DinoStats.Instance.Money>=30)
        {
            DinoStats.Instance.skinsUnlock[3].acquired = true;
            DinoStats.Instance.Money -= 30;
            _moneyCountText.text = DinoStats.Instance.Money.ToString();
            _buyBlueText.text = "Куплено";
            DinoStats.Instance.SaveGame();
        }
    }
    public void AplYellowDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[3].acquired)
        {
            DinoStats.Instance.SetSkin = 3;
            _aplYellowText.text = "Выбрано";
            _aplGreenText.text = "Применить";
            _aplBlueText.text = "Применить";
            _aplRedText.text = "Применить";
        }
    }
}
