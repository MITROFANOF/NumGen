using UnityEngine;
using UnityEngine.UI;

public class Version : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Text>().text = "Версия " + Application.version;
    }
}