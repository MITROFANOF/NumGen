using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static Generator;
using static StatsCounter;

public class GameManager : MonoBehaviour
{
    public GameObject numPref;
    public Transform soloNumParent, multyNumParent;
    public Text infoText, countText;
    private bool _paused;
    private RusNumber _rusNumber;
    public UnityEvent winEvent, newNumEvent;

    private void Start()
    {
        UpdateNumCountOnBox();
    }

    public void NewNum()
    {
        if (_paused) return;
        newNumEvent.Invoke();
        
        
        soloNumParent.GetChild(soloNumParent.childCount - 1).GetComponent<Animator>().SetTrigger(Animator.StringToHash("DeSpawn"));
        var newNum = Instantiate(numPref, soloNumParent.transform);
        _rusNumber = newNum.GetComponent<RusNumber>();
        
        GenerateNumber(_rusNumber);
        newNum.name = _rusNumber.Number;
        Analizator.Analize(_rusNumber);
        infoText.text = _rusNumber.Info;
        
        newNum.GetComponent<Drawer>().DrawNumber(_rusNumber.Number);
        
        
        foreach (Transform item in multyNumParent.transform) item.GetComponent<Animator>().SetTrigger(Animator.StringToHash("DeSpawn 2"));
        Instantiate(newNum, multyNumParent.transform);
        
        PlayServices.UnlockAchievement(GPGSIds.achievement); 
        
        switch (_rusNumber.Rang)
        {
            case 1:
                PlayServices.UnlockAchievement(GPGSIds.achievement_2); break;
            case 2:
                PlayServices.UnlockAchievement(GPGSIds.achievement_3); break;
            case 3:
                PlayServices.UnlockAchievement(GPGSIds.achievement_4); break;
            case 4:
                PlayServices.UnlockAchievement(GPGSIds.achievement_5); break;
            case 5: 
                PlayServices.UnlockAchievement(GPGSIds.achievement_6); break;
        }
        
        if (_rusNumber.Rang > 0)
        {
            
            AddNumber(_rusNumber.Rang);
            ParticleEffects.Play(_rusNumber.Rang);
            winEvent.Invoke();
        }
        
        
        
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