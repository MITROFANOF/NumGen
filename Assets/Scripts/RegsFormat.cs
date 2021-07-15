using UnityEngine;
using UnityEngine.Serialization;

public class RegsFormat : MonoBehaviour
{
    [FormerlySerializedAs("RegPrefab")] public GameObject regPrefab;

    [SerializeField] private NumberSpawner spawner;
    
    private void Start()
    {
        foreach (var region in spawner.CurrentGenerator.Regions)
        {
            var newReg = Instantiate(regPrefab, transform);
            newReg.GetComponent<RegPrefab>().SetText(region.Key, region.Value);
        }
    }
}
