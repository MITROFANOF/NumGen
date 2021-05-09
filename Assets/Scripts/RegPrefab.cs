using UnityEngine;
using UnityEngine.UI;

public class RegPrefab : MonoBehaviour
{
    public Text num, nam;

    public void SetText(string num, string nam)
    {
        this.num.text = num;
        this.nam.text = nam;
    }
}