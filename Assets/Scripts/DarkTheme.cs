using System;
using UnityEngine;
using UnityEngine.UI;

public class DarkTheme : MonoBehaviour
{
    public Text text;
    public Image bg;
    public bool reversed;
    private Color _textColor, _bgColor;

    
    private void OnEnable()
    {
        Settings.OnChangeTheme += SetDarkTheme;
    }

    private void OnDisable()
    {
        Settings.OnChangeTheme -= SetDarkTheme;
    }

    private void OnDestroy()
    {
        Settings.OnChangeTheme -= SetDarkTheme;
    }


    private void SetDarkTheme(object sender, Settings.ChangeThemeEventArgs e)
    {
        if (!reversed)
        {
            _textColor = e.darkTheme ? new Color(0.75f, 0.75f, 0.75f) : new Color(0.25f, 0.25f, 0.25f);
            _bgColor = e.darkTheme ? new Color(0.25f, 0.25f, 0.25f) : Color.white;
        }
        else
        {
            _textColor = e.darkTheme ? new Color(0.25f, 0.25f, 0.25f) : new Color(0.75f, 0.75f, 0.75f);
            _bgColor = e.darkTheme ? new Color(0.75f, 0.75f, 0.75f) : new Color(0.25f, 0.25f, 0.25f);
        }

        if (text is { }) text.color = _textColor;
        if (bg is { }) bg.color = _bgColor;
    }
}