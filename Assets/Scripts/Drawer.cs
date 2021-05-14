using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Drawer : MonoBehaviour
{
	[SerializeField] private Image[] symbol = new Image[11];

	[SerializeField] private SpriteAtlas symbolsSpriteAtlas;
	[SerializeField] private Sprite transparent;

	public void DrawNumberPlate(string number)
	{
		for (var i = 0; i < number.Length; i++)
			symbol[i].sprite = symbolsSpriteAtlas.GetSprite(number[i].ToString());
		
		for (var i = number.Length; i < 9; i++)
			symbol[i].sprite = transparent;
		
		if (number.Length == 9)
		{
			symbol[6].transform.parent.gameObject.SetActive(false);
			symbol[8].transform.parent.gameObject.SetActive(true);
			for (var i = 6; i < number.Length; i++)
				symbol[i + 2].sprite = symbolsSpriteAtlas.GetSprite(number[i].ToString());
		}
		else
		{
			symbol[6].transform.parent.gameObject.SetActive(true);
			symbol[8].transform.parent.gameObject.SetActive(false);
		}
	}

	public void DrawUkrainianNumberPlate(string number)
	{
		for (var i = 0; i < number.Length; i++)
			symbol[i].sprite = symbolsSpriteAtlas.GetSprite(number[i].ToString());
	}
}