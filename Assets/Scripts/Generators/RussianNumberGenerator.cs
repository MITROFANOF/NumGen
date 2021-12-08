using UnityEngine;

namespace Generators
{
	public class RussianNumberGenerator : NumberGenerator
	{
		public override GeneratorType Type => GeneratorType.Russian;
		protected override string Path => "Sheets/RussianRegions";
		protected override string SymbolSet => "ABEKMHOPCTYX";

		protected override int RandomDigits()
		{
			return Random.Range(1, 1000);
		}

		public override Number GenerateNumber()
		{
			var number = new Number
			{
				Digits = RandomDigits(),
				Series = new string(new[] {RandomLetter(), RandomLetter(), RandomLetter()}),
				Region = RandomRegion(),
				GeneratorType = Type
			};
			number.FullNumber = number.Series.Insert(1, number.Digits.ToString("D3")) + number.Region;
			return number;
		}
	}
}