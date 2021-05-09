using UnityEngine;
using UnityEngine.Serialization;
using static Generator;

public class RegsFormat : MonoBehaviour
{
    [FormerlySerializedAs("RegPrefab")] public GameObject regPrefab;
    void Start()
    {
        foreach (var region in Region)
        {
            var newReg = Instantiate(regPrefab, transform);
            newReg.GetComponent<RegPrefab>().SetText(region.Key.ToString("D2"), region.Value);
        }
    }
}
