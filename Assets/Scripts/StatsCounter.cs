using UnityEngine;
using UnityEngine.UI;

public class StatsCounter : MonoBehaviour
{
    private static readonly string[] RangPrefs = {"countTotal","countRang1","countRang2","countRang3","countRang4","countRang5"};
    public Text[] count;
    private void Start()
    {
        InitPlayerPrefs();
    }

    private static void InitPlayerPrefs()
    {
        foreach (var count in RangPrefs)
        {
            if (!PlayerPrefs.HasKey(count)) PlayerPrefs.SetInt(count, 0);
        }
    }

    public static void AddNumber(int rang)
    {
        rang = Mathf.Clamp(rang, 0, 5);
        PlayerPrefs.SetInt(RangPrefs[rang], PlayerPrefs.GetInt(RangPrefs[rang]) + 1);
        PlayServices.AddScoreToLeaderboard(PlayerPrefs.GetInt(RangPrefs[0]));
    }
    
    public static int GetNumber(int rang)
    {
        return PlayerPrefs.GetInt(RangPrefs[rang]);
    }

    public static void SaveAll()
    {
        PlayerPrefs.Save();
    }

    public void RefreshCounters()
    {
        var rang = 0;
        foreach (var v in count)
        {
            v.text = GetNumber(rang++).ToString();
        }
    }

    public static void ResetAllData()
    {
        foreach (var v in RangPrefs)
        {
            PlayerPrefs.SetInt(v, 0);
        }
    }
}
