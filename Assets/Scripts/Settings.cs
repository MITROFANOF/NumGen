using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using static Generator;

public class Settings : MonoBehaviour
{
    public Dropdown regionSelect;
    public Button prewSelect, themeSelect;
    public Text deleteAll, count;
    public CanvasGroup solo, multy;
    public bool darkTheme;
    private Coroutine _deleteTimerCoroutine;

    private void Awake()
    {
        //Регионы
        regionSelect.ClearOptions();
        regionSelect.options.Add(new Dropdown.OptionData {text = "Случайный"});
        foreach (var region in Region)
            regionSelect.options.Add(new Dropdown.OptionData {text = $"{region.Key}|{region.Value}"});
        if (!PlayerPrefs.HasKey("region")) PlayerPrefs.SetInt("region", 0);
        regionSelect.value = PlayerPrefs.GetInt("region"); 
        
        //Показывать предыдущие номера
        if (!PlayerPrefs.HasKey("prew")) PlayerPrefs.SetInt("prew", 0);
        SetPrew();
        
        //Темная тема
        if (!PlayerPrefs.HasKey("dark")) PlayerPrefs.SetInt("dark", 0); 
        darkTheme = PlayerPrefs.GetInt("dark") == 1;
        SetTheme(darkTheme);
    }

    public static event EventHandler<ChangeThemeEventArgs> OnChangeTheme;
    
    //Регион
    public void ChangeReg()
    {
        PlayerPrefs.SetInt("region", regionSelect.value);
        PlayerPrefs.Save();
    }

    //Отображение предыдущих номеров
    private void SetPrew()
    {
        if (PlayerPrefs.GetInt("prew") == 0)
        {
            solo.alpha = 1f;
            multy.alpha = 0f;
            prewSelect.GetComponentInChildren<Text>().text = "Не показывать";
        }
        else
        {
            solo.alpha = 0f;
            multy.alpha = 1f;
            prewSelect.GetComponentInChildren<Text>().text = "Показывать";
        }
    }
    public void ChangePrew()
    {
        PlayerPrefs.SetInt("prew", PlayerPrefs.GetInt("prew") == 0 ? 1 : 0);
        PlayerPrefs.Save();
        SetPrew();
    }
 
    //Темная тема
    private void SetTheme(bool dark)
    {
        themeSelect.GetComponentInChildren<Text>().text = dark ? "Тёмная" : "Светлая";
        PlayerPrefs.SetInt("dark", dark ? 1 : 0);
        PlayerPrefs.Save();
        OnChangeTheme?.Invoke(this, new ChangeThemeEventArgs {darkTheme = dark});
    }
    public void ChangeTheme()
    {
        darkTheme = !darkTheme;
        SetTheme(darkTheme);
    }

    //Сброс статистики
    public void DeleteData()
    {
        if (_deleteTimerCoroutine != null)
        {
            StopCoroutine(_deleteTimerCoroutine);
            _deleteTimerCoroutine = null;
            deleteAll.text = "Сбросить статистику";
            StatsCounter.ResetAllData();
            count.text = "0";
        }
        else
        {
            _deleteTimerCoroutine = StartCoroutine(DeleteTimer(5));
        }
    }

    private IEnumerator DeleteTimer(int time)
    {
        while (time > 0)
        {
            deleteAll.text = $"Вы уверены? ({time})";
            yield return new WaitForSeconds(1f);
            time--;
        }

        _deleteTimerCoroutine = null;
        deleteAll.text = "Сбросить статистику";
    }

    public class ChangeThemeEventArgs : EventArgs
    {
        public bool darkTheme;
    }
}