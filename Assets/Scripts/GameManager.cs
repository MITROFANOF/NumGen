using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static StatsCounter;

public enum GeneratorType
{
	Russian,
	Ukrainian
}

public class GameManager : MonoBehaviour
{
	public GeneratorType generatorType;
	[SerializeField] private GameObject numberPlatePrefab;
	[SerializeField] private GameObject numberUaPlatePrefab;
	public Transform soloNumParent, multyNumParent;
	
	public Text regionText, infoText, countText;
	private bool _paused;
	public UnityEvent winEvent, newNumEvent;
	private readonly RussianNumberGenerator _russianNumberGenerator = new RussianNumberGenerator();
	private readonly UkrainianNumberGenerator _ukrainianNumberGenerator = new UkrainianNumberGenerator();
	
	private readonly Generator _generators = new Generator(); 
	
	
	private void Start()
	{
		UpdateNumCountOnBox();
		
		//TODO - Работает только первый лоад.
		_ukrainianNumberGenerator.LoadAndParseRegionList();
		_russianNumberGenerator.LoadAndParseRegionList();
	}

	public void NewNum()
	{
		INumber number;
		
		switch (generatorType)
		{
			case GeneratorType.Russian:
				var rusNumber = Instantiate(numberPlatePrefab, soloNumParent.transform);
				number = rusNumber.GetComponent<RussianNumber>();
				_generators.Generate(_russianNumberGenerator, number);
				break;
			case GeneratorType.Ukrainian:
				var uaNumber = Instantiate(numberUaPlatePrefab, soloNumParent.transform);
				number = uaNumber.GetComponent<UkrainianNumber>();
				_generators.Generate(_ukrainianNumberGenerator, number);
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}

		Debug.Log(number.Number);

		// if (_paused) return;
		// newNumEvent.Invoke();
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
		// infoText.text = _number.Info;
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
