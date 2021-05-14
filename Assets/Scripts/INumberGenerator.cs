using System.Collections.Generic;

public interface INumberGenerator
{
	SortedDictionary<string, string> Regions { get; }
	void LoadAndParseRegionList();
	int RandomDigits();
	string RandomRegion();
	string RandomLetter();
	void GenerateNumber(ref INumber number);
}