using UnityEngine;

public class RussianNumber : MonoBehaviour, INumber
{
	public string Number { get; set; }
	public string Letters { get; set; }
	public int Digits { get; set; }
	public string Region { get; set; }
	public int Rang { get; set; }
	public string Info { get; set; }

	public void Join()
	{
		Number = Letters.Insert(1, Digits.ToString()) + Region;
	}

	public void Separate()
	{
		Letters = Number[0].ToString() + Number[4] + Number[5];
		Digits = int.Parse(Number.Substring(1, 3));
		Region = Number.Substring(6, Number.Length - 6);
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