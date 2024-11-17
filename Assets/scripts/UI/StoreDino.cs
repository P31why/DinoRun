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

    }
}
