using UnityEngine;
using UnityEngine.Serialization;
using static Generator;

public class RegsFormat : MonoBehaviour
{
    [FormerlySerializedAs("RegPrefab")] public GameObject regPrefab;

    private readonly RussianNumberGenerator _russianNumberGenerator = new RussianNumberGenerator();
    
    private void Start()
    {
        foreach (var region in _russianNumberGenerator.Regions)
        {
            var newReg = Instantiate(regPrefab, transform);
            newReg.GetComponent<RegPrefab>().SetText(region.Key, region.Value);
        }
    }
}
