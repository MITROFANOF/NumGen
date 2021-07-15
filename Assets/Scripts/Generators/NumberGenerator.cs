using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Generators
{
	public abstract class NumberGenerator
	{
		public abstract GeneratorType Type { get; }
		protected abstract string Path { get; }
		protected abstract string SymbolSet { get; }
		public SortedDictionary<string, string> Regions { get; } = new SortedDictionary<string, string>();

		public void LoadAndParseRegionList()
		{
			var rawData = Resources.Load<TextAsset>(Path);
			var rowsData = rawData.text.Split('\n').ToList();
			foreach (var rowPart in rowsData.Select(row => row.Split(';')))
			{
				if(rowPart[0]!="")
					Regions.Add(rowPart[0], rowPart[1]);
			}
		}

		protected abstract int RandomDigits();

		protected string RandomRegion()
		{
			return Regions.Keys.ElementAt(Random.Range(0, Regions.Count));
		}

		protected char RandomLetter()
		{
			return SymbolSet[Random.Range(0, SymbolSet.Length)];
		}

		public abstract Number GenerateNumber();
	}
}