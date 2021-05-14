using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UkrainianNumberGenerator : INumberGenerator
{
	private const string Letters = "ABEIKMHOPCTX";
	public SortedDictionary<string, string> Regions { get; } = new SortedDictionary<string, string>();

	public void LoadAndParseRegionList()
	{
		var rawData = Resources.Load<TextAsset>("Sheets/UkrainianRegions");
		var rowsData = rawData.text.Split('\n').ToList();
		foreach (var rowPart in rowsData.Select(row => row.Split(';')))
		{
			Regions.Add(rowPart[0], rowPart[1]);
		}
	}

	public int RandomDigits()
	{
		return Random.Range(1, 10000);
	}

	public string RandomRegion()
	{
		return Regions.Keys.ElementAt(Random.Range(0, Regions.Count));
	}

	public string RandomLetter()
	{
		return Letters[Random.Range(0, Letters.Length)].ToString();
	}

	public void GenerateNumber(ref INumber number)
	{
		number.Digits = RandomDigits();
		number.Letters = RandomLetter() + RandomLetter();
		number.Region = RandomRegion();

		number.Join();
	}
}