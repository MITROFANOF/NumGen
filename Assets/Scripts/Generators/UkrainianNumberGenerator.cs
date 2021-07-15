using UnityEngine;
using UnityEngine.Serialization;

namespace Generators
{
	public class UkrainianNumberGenerator : NumberGenerator
	{
		public override GeneratorType Type => GeneratorType.Ukrainian;
		protected override string Path => "Sheets/UkrainianRegions";
		protected override string SymbolSet => "ABEIKMHOPCTX";

		protected override int RandomDigits()
		{
			return Random.Range(1, 10000);
		}

		public override Number GenerateNumber()
		{
			var number = new Number
			{
				Digits = RandomDigits(),
				Series = new string(new[] {RandomLetter(), RandomLetter()}),
				Region = RandomRegion(),
				GeneratorType = Type
			};
			number.FullNumber = number.Region + number.Digits.ToString("D4") + number.Series;
			return number;
		}
	}
}