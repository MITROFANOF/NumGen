using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Generators;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static StatsCounter;

public class NumberSpawner : MonoBehaviour
{
	public GeneratorType generatorType;
	public Transform soloNumParent;
	public Transform multiNumParent;

	public Text regionText, infoText, countText;
	private bool _paused;
	public UnityEvent winEvent;
	public UnityEvent newNumberEvent;

	private readonly List<NumberGenerator> _numberGenerators = new List<NumberGenerator>
	{
		new RussianNumberGenerator(),
		new UkrainianNumberGenerator(),
	};

	public NumberGenerator CurrentGenerator;

	private void Start()
	{
		foreach (var generator in _numberGenerators)
		{
			generator.LoadAndParseRegionList();
		}

		//UpdateNumCountOnBox();
	}

	public void SpawnNewNumber()
	{
		if (_paused) return;

		newNumberEvent.Invoke();

		foreach (var generator in _numberGenerators.Where(generator => generator.Type == generatorType))
		{
			CurrentGenerator = generator;
		}

		var newNumber = CurrentGenerator.GenerateNumber();
		Debug.Log(newNumber.FullNumber);


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