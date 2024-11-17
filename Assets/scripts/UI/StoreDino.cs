using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class StoreDino : MonoBehaviour
{
    [SerializeField] private TMP_Text _buyGreenText;
    [SerializeField] private TMP_Text _buyRedText;
    [SerializeField] private TMP_Text _aplRedText;
    [SerializeField] private TMP_Text _buyBlueText;
    [SerializeField] private TMP_Text _aplBlueText;
    [SerializeField] private TMP_Text _buyYellowText;
    [SerializeField] private TMP_Text _aplYellowText;

    private void Start()
    {
        if (DinoStats.Instance.SetSkin == 0)
        {
            _buyGreenText.text = "�������";
        }
        else
        {
            List<DinoSkin> buff = DinoStats.Instance.skinsUnlock;
            foreach (DinoSkin i in buff)
            {
                if(i.skinId == 1 && i.acquired)
                {
                    _buyRedText.text = "�������";
                }
                else
                {
                    _buyRedText.text = "������ �� 10$";
                }

                if (i.skinId == 2 && i.acquired)
                {
                    _buyBlueText.text = "�������";
                }
                else
                {
                    _buyBlueText.text = "������ �� 40$";
                }

                if (i.skinId == 3 && i.acquired)
                {
                    _buyYellowText.text = "�������";
                }
                else
                {
                    _buyYellowText.text = "������ �� 30$";
                }
            }
        }
        
    }
}
