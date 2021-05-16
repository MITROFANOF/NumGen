using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static StatsCounter;

public enum GeneratorType
{
	Russian = 0,
	Ukrainian = 1
}

public class GameManager : MonoBehaviour
{
	public GeneratorType generatorType;
	public Transform soloNumParent;
	public Transform multiNumParent;
	
	public Text regionText, infoText, countText;
	private bool _paused;
	public UnityEvent winEvent, newNumEvent;

	private static readonly NumberGenerator[] NumberGenerators = {
		new RussianNumberGenerator(),
		new UkrainianNumberGenerator(),
	};
	
	private void Start()
	{
		foreach (var generator in NumberGenerators)
		{
			generator.LoadAndParseRegionList();
		}

		//UpdateNumCountOnBox();
	}

	public void NewNum()
	{
		if (_paused) return;
		
		newNumEvent.Invoke();
		var number = NumberGenerators[(int) generatorType].GenerateNumber();
		infoText.text = number.Info;
		Debug.Log(number.FullNumber);
		
		//number.PlateDrawer.DrawNumberPlate(number.FullNumber);
		// 
		// 
		//
		//
		// soloNumParent.GetChild(soloNumParent.childCount - 1).GetComponent<Animator>()
		// 	.SetTrigger(Animator.StringToHash("DeSpawn"));
		// var newNum = Instantiate(numberPlatePrefab, soloNumParent.transform);
		// _number = newNum.GetComponent<RussianNumber>();
		//
		// //GenerateNumber(_number);
		// newNum.name = _number.Number;
		// //AnalyzeNumber(_number);
		//
		// //regionText.text = RussianRegions[_number.Region];
		//
		//
		// newNum.GetComponent<Drawer>().DrawNumberPlate(_number.Number);
		//
		//
		// foreach (Transform item in multyNumParent.transform)
		// 	item.GetComponent<Animator>().SetTrigger(Animator.StringToHash("DeSpawn 2"));
		// Instantiate(newNum, multyNumParent.transform);
		//
		// PlayServices.UnlockAchievement(GPGSIds.achievement);
		//
		// switch (_number.Rang)
		// {
		// 	case 1:
		// 		PlayServices.UnlockAchievement(GPGSIds.achievement_2);
		// 		break;
		// 	case 2:
		// 		PlayServices.UnlockAchievement(GPGSIds.achievement_3);
		// 		break;
		// 	case 3:
		// 		PlayServices.UnlockAchievement(GPGSIds.achievement_4);
		// 		break;
		// 	case 4:
		// 		PlayServices.UnlockAchievement(GPGSIds.achievement_5);
		// 		break;
		// 	case 5:
		// 		PlayServices.UnlockAchievement(GPGSIds.achievement_6);
		// 		break;
		// }
		//
		// if (_number.Rang > 0)
		// {
		// 	AddNumber(_number.Rang);
		// 	ParticleEffects.Play(_number.Rang);
		// 	winEvent.Invoke();
		// }
	}

	public void UpdateNumCountOnBox()
	{
		countText.text = GetNumber(0).ToString();
	}

	public void WinCoroutine()
	{
		StartCoroutine(Win());
	}

	private IEnumerator Win()
	{
		_paused = true;
		yield return new WaitForSeconds(.5f);
		_paused = false;
	}
}
