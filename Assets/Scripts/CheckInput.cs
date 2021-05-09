using UnityEngine;
using UnityEngine.UI;
using static Generator;

public class CheckInput : MonoBehaviour
{
    public CanvasGroup numbers, letters;
    public Drawer drawer;
    public Text info;
    public RusNumber rusNumber;
    private string _number = "";

    public void Buttons(string a)
    {
        _number += a;
        Switch();
        drawer.DrawNumber(_number);
    }

    public void Delete()
    {
        if (_number.Length > 0) _number = _number.Substring(0, _number.Length - 1);
        Switch();
        drawer.DrawNumber(_number);
    }

    private void Switch()
    {
        switch (_number.Length)
        {
            case 0:
            case 4:
            case 5:
                letters.interactable = true;
                numbers.interactable = false;
                break;
            case 1:
            case 2:
            case 3:
            case 6:
            case 7:
            case 8:
                letters.interactable = false;
                numbers.interactable = true;
                break;
            case 9:
                letters.interactable = false;
                numbers.interactable = false;
                break;
        }
    }

    public void Check()
    {
        if (_number.Length < 8)
        {
            info.text = "Неверный номер.";
        }
        else
        {
            rusNumber.ClearData();
            rusNumber.Separate(_number);
            if (0 < rusNumber.Num)
            {
                if (Region.ContainsKey(rusNumber.Reg))
                {
                    info.text = $"{Region[rusNumber.Reg]}.\n";
                    Analizator.Analize(rusNumber);
                    if (rusNumber.Info == "") info.text += "Обычный номер.";
                    else info.text += rusNumber.Info;
                }
                else
                {
                    info.text = "Неверный регион.";
                }
            }
            else
            {
                info.text = "Неверный номер.";
            }
        }
    }
}