using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Drawer : MonoBehaviour
{
    [SerializeField] private Image[] symbol = new Image[11];

    [FormerlySerializedAs("symbolsSA")] public SpriteAtlas symbolsSpriteAtlas;
    [FormerlySerializedAs("Transparent")] public Sprite transparent;
    
    public void DrawNumber(string inputNumber)
    {
        for (var i = 0; i < inputNumber.Length; i++)
            symbol[i].sprite = symbolsSpriteAtlas.GetSprite(inputNumber[i].ToString());
        for (var i = inputNumber.Length; i < 9; i++) symbol[i].sprite = transparent;
        if (inputNumber.Length == 9)
        {
            symbol[6].transform.parent.gameObject.SetActive(false);
            symbol[8].transform.parent.gameObject.SetActive(true);
            for (var i = 6; i < inputNumber.Length; i++)
                symbol[i + 2].sprite = symbolsSpriteAtlas.GetSprite(inputNumber[i].ToString());
        }
        else
        {
            symbol[6].transform.parent.gameObject.SetActive(true);
            symbol[8].transform.parent.gameObject.SetActive(false);
        }
    }
}