using UnityEngine;

public class UkrainianNumber : MonoBehaviour, INumber
{
	public string Number { get; set; }
	public string Letters { get; set; }
	public int Digits { get; set; }
	public string Region { get; set; }
	public int Rang { get; set; }
	public string Info { get; set; }


	public void Join()
	{
		Number = Region + Digits.ToString("D4") + Letters;
	}

	public void Separate()
	{
		Letters = Number.Substring(6, 2);
		Digits = int.Parse(Number.Substring(2, 4));
		Region = Number.Substring(0, 2);
	}

	public void AddData(int rang, string info)
	{
		Rang += rang;
		Info += info;
	}

	public void ClearData()
	{
		Rang = 0;
		Info = "";
	}
}