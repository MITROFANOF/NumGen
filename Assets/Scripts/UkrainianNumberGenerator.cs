using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UkrainianNumberGenerator : NumberGenerator
{
	protected override string Path => "Sheets/UkrainianRegions";
	protected override string Letters => "ABEIKMHOPCTX";

	protected override int RandomDigits()
	{
		return Random.Range(1, 10000);
	}

	public override Number GenerateNumber()
	{
		Number number = new UkrainianNumber();
		number.Digits = RandomDigits();
		number.Letters = new string(new[] {RandomLetter(), RandomLetter()});
		number.Region = RandomRegion();

		number.Join();
		return number;
	}
}