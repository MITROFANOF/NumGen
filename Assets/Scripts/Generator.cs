using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class Generator : MonoBehaviour
{
    private const string Letter = "ABEKMHOPCTYX";
    public static readonly SortedDictionary<int, string> Region = new SortedDictionary<int, string>();

    private void Awake()
    {
        var regions = Resources.Load<TextAsset>("Sheets/Regions");
        var data = regions.text.Split('\n');
        for (var i = 0; i < data.Length - 1; i++)
        {
            var row = data[i].Split(';');
            Region.Add(Convert.ToInt32(row[0]), row[1]);
        }
    }

    private static int Nums()
    {
        return Random.Range(1, 1000);
    }

    private static int Reg()
    {
        return Region.Keys.ElementAt(Random.Range(0, Region.Count - 1));
    }

    private static string Letters()
    {
        return Letter[Random.Range(0, 12)].ToString() + Letter[Random.Range(0, 12)] + Letter[Random.Range(0, 12)];
    }

    public static void GenerateNumber(RusNumber number)
    {
        number.Num = Nums();
        number.Reg = PlayerPrefs.GetInt("region") == 0 ? Reg() : Region.ElementAt(PlayerPrefs.GetInt("region") - 1).Key;
        number.Let = Letters();
        number.Number = number.Let[0] +
                        number.Num.ToString("D3") +
                        number.Let[1] +
                        number.Let[2] +
                        number.Reg.ToString("D2");
    }
}