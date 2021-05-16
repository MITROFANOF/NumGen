using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RussianNumberGenerator : NumberGenerator
{
	protected override string Path => "Sheets/RussianRegions";
	protected override string Letters => "ABEKMHOPCTYX";

	protected override int RandomDigits()
	{
		return Random.Range(1, 1000);
	}

	public override Number GenerateNumber()
	{
		Number number = new RussianNumber();
		number.Digits = RandomDigits();
		number.Letters = new string(new[] {RandomLetter(), RandomLetter(), RandomLetter()});
		number.Region = RandomRegion();

		number.Join();
		return number;
	}
}