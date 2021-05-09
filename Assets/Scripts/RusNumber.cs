using UnityEngine;

public class RusNumber : MonoBehaviour
{
    public string Number { get; set; }
    public string Let { get; set; }
    public int Num { get; set; }
    public int Reg { get; set; }
    public int Rang { get; private set; }
    public string Info { get; set; }

    public void Separate(string number)
    {
        Number = number;
        Let = number[0].ToString() + number[4] + number[5];
        Num = int.Parse(number.Substring(1, 3));
        Reg = int.Parse(number.Substring(6, Number.Length - 6));
    }

    public void SetData(int rang, string info)
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