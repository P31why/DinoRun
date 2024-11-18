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

    [SerializeField] private TMP_Text _moneyCountTextSkin;
    [SerializeField] private TMP_Text _moneyCountTextMusic;

    [SerializeField] private TMP_Text _buyMusic1;
    [SerializeField] private TMP_Text _buyMusic2;
    [SerializeField] private TMP_Text _buyMusic3;
    [SerializeField] private TMP_Text _buyMusic4;
    [SerializeField] private TMP_Text _buyMusic5;

    public void LoadStore()
    {
        List<DinoSkin> buff = DinoStats.Instance.skinsUnlock;
        foreach (DinoSkin i in buff)
        {
            if (i.skinId == 1 && i.acquired)
            {
                _buyRedText.text = "�������";
            }
            else if (i.skinId == 1 && !i.acquired)
            {
                _buyRedText.text = "������ �� 10$";
            }

            if (i.skinId == 2 && i.acquired)
            {
                _buyBlueText.text = "�������";
            }
            else if (i.skinId == 1 && !i.acquired)
            {
                _buyBlueText.text = "������ �� 40$";
            }

            if (i.skinId == 3 && i.acquired)
            {
                _buyYellowText.text = "�������";
            }
            else if (i.skinId == 1 && !i.acquired)
            {
                _buyYellowText.text = "������ �� 30$";
            }
        }


        if (DinoStats.Instance.SetSkin == 0)
        {
            _aplGreenText.text = "�������";
        }
        else if (DinoStats.Instance.SetSkin == 1)
        {
            _aplRedText.text = "�������";
        }
        else if (DinoStats.Instance.SetSkin == 2)
        {
            _aplBlueText.text = "�������";
        }
        else if (DinoStats.Instance.SetSkin == 3)
        {
            _aplYellowText.text = "�������";
        }
        Debug.Log(DinoStats.Instance.SetSkin);
        _moneyCountTextSkin.text = DinoStats.Instance.Money.ToString();
    }

    public void AplGreenDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[0].acquired)
        {
            DinoStats.Instance.SetSkin = 0;
            _aplGreenText.text = "�������";
            _aplRedText.text = "���������";
            _aplBlueText.text = "���������";
            _aplYellowText.text = "���������";
        }
    }
    public void BuyRedDino()
    {
        if (!DinoStats.Instance.skinsUnlock[1].acquired && DinoStats.Instance.Money>=10)
        {
            DinoStats.Instance.skinsUnlock[1].acquired = true;
            DinoStats.Instance.Money -= 10;
            _buyRedText.text = "�������";
            _moneyCountTextSkin.text = DinoStats.Instance.Money.ToString();
            DinoStats.Instance.SaveGame();
        }
    }
    public void AplRedDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[1].acquired)
        {
            DinoStats.Instance.SetSkin = 1;
            _aplRedText.text = "�������";
            _aplGreenText.text = "���������";
            _aplBlueText.text = "���������";
            _aplYellowText.text = "���������";

        }
    }
    public void BuyBlueDino()
    {
        if (!DinoStats.Instance.skinsUnlock[2].acquired && DinoStats.Instance.Money>=40)
        {
            DinoStats.Instance.skinsUnlock[2].acquired = true;
            DinoStats.Instance.Money -= 40;
            _moneyCountTextSkin.text = DinoStats.Instance.Money.ToString();
            _buyBlueText.text = "�������";
            DinoStats.Instance.SaveGame();
        }
    }
    public void AplBlueDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[2].acquired)
        {
            DinoStats.Instance.SetSkin = 2;
            _aplBlueText.text = "�������";
            _aplGreenText.text = "���������";
            _aplRedText.text = "���������";
            _aplYellowText.text = "���������";
        }
    }
    public void BuyYellowDino()
    {
        if (!DinoStats.Instance.skinsUnlock[3].acquired && DinoStats.Instance.Money>=30)
        {
            DinoStats.Instance.skinsUnlock[3].acquired = true;
            DinoStats.Instance.Money -= 30;
            _moneyCountTextSkin.text = DinoStats.Instance.Money.ToString();
            _buyBlueText.text = "�������";
            DinoStats.Instance.SaveGame();
        }
    }
    public void AplYellowDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[3].acquired)
        {
            DinoStats.Instance.SetSkin = 3;
            _aplYellowText.text = "�������";
            _aplGreenText.text = "���������";
            _aplBlueText.text = "���������";
            _aplRedText.text = "���������";
        }
    }

    public void LoadMusicStore()
    {
        List<MusicDisk> buff = DinoStats.Instance.musicUnlock;
        if (buff[0].acquired)
        {
            _buyMusic1.text = "�������";
        }
        else _buyMusic1.text = "������ �� 2$";

        if (buff[1].acquired)
        {
            _buyMusic2.text = "�������";
        }
        else _buyMusic2.text = "������ �� 4$";

        if (buff[2].acquired)
        {
            _buyMusic3.text = "�������";
        }
        else _buyMusic3.text = "������ �� 4$";

        if (buff[3].acquired)
        {
            _buyMusic4.text = "�������";
        }
        else _buyMusic4.text = "������ �� 5$";

        if (buff[4].acquired)
        {
            _buyMusic5.text = "�������";
        }
        else _buyMusic5.text = "������ �� 10$";
    }

    public void BuyMusic1()
    {
        MusicDisk buff=DinoStats.Instance.musicUnlock[0];
        if (!buff.acquired && DinoStats.Instance.Money>=buff.price)
        {

        }
    }
}
