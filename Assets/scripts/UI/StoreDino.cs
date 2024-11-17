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

    }

    public void AplGreenDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[1].acquired)
        {
            DinoStats.Instance.SetSkin = 0;
            _aplRedText.text = "�������";

        }
    }
    public void BuyRedDino()
    {
        if (!DinoStats.Instance.skinsUnlock[1].acquired && DinoStats.Instance.Money>=10)
        {
            DinoStats.Instance.skinsUnlock[1].acquired = true;
            DinoStats.Instance.Money -= 10;
            _buyRedText.text = "�������";
            DinoStats.Instance.SaveGame();
        }
    }
    public void AplRedDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[1].acquired)
        {
            DinoStats.Instance.SetSkin = 1;
            _aplRedText.text = "�������";

        }
    }
    public void BuyBlueDino()
    {
        if (!DinoStats.Instance.skinsUnlock[2].acquired && DinoStats.Instance.Money>=40)
        {
            DinoStats.Instance.skinsUnlock[2].acquired = true;
            DinoStats.Instance.Money -= 40;
            _buyBlueText.text = "�������";
            DinoStats.Instance.SaveGame();
        }
    }
    public void AplBlueDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[2].acquired)
        {
            DinoStats.Instance.SetSkin = 2;
            _aplRedText.text = "�������";
        }
    }
    public void BuyYellowDino()
    {
        if (!DinoStats.Instance.skinsUnlock[3].acquired && DinoStats.Instance.Money>=30)
        {
            DinoStats.Instance.skinsUnlock[3].acquired = true;
            DinoStats.Instance.Money -= 30;
            _buyBlueText.text = "�������";
            DinoStats.Instance.SaveGame();
        }
    }
    public void AplYellowDinoSkin()
    {
        if (DinoStats.Instance.skinsUnlock[3].acquired)
        {
            DinoStats.Instance.SetSkin = 3;
            _aplRedText.text = "�������";
        }
    }
}
