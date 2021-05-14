using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class RegPrefab : MonoBehaviour
{
	public Text regionNumber;
	public Text regionName;

	public void SetText(string newRegionNumber, string newRegionName)
	{
		regionNumber.text = newRegionNumber;
		regionName.text = newRegionName;
	}
}