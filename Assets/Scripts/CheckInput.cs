using UnityEngine;
using UnityEngine.UI;

public class CheckInput : MonoBehaviour
{
	public CanvasGroup numbers, letters;
	public Drawer drawer;
	public Text info;
	public Number russianNumber;
	private string _number = "";

	public void Buttons(string a)
	{
		_number += a;
		Switch();
		drawer.DrawNumberPlate(_number);
	}

	public void Delete()
	{
		if (_number.Length > 0) _number = _number.Substring(0, _number.Length - 1);
		Switch();
		drawer.DrawNumberPlate(_number);
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
			russianNumber.ClearData();
			if (0 < russianNumber.Digits)
			{
				//if (RussianRegions.ContainsKey(russianNumber.Region))
				// {
				// 	info.text = $"{RussianRegions[russianNumber.Region]}.\n";
				// 	Analyzer.AnalyzeNumber(russianNumber);
				// 	if (russianNumber.Info == "") info.text += "Обычный номер.";
				// 	else info.text += russianNumber.Info;
				// }
				// else
				// {
				// 	info.text = "Неверный регион.";
				// }
			}
			else
			{
				info.text = "Неверный номер.";
			}
		}
	}
}