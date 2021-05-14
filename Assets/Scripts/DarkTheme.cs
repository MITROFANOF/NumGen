using UnityEngine;
using UnityEngine.UI;

public class DarkTheme : MonoBehaviour
{
	public Text text;
	public Image bg;
	public bool reversed;
	private Color _textColor, _bgColor;

	private readonly Color _white = Color.white;
	private readonly Color _dark = new Color(0.25f, 0.25f, 0.25f);
	private readonly Color _light = new Color(0.75f, 0.75f, 0.75f);
	

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
			_textColor = e.DarkTheme ? _light : _dark;
			_bgColor = e.DarkTheme ? _dark : _white;
		}
		else
		{
			_textColor = e.DarkTheme ? _dark : _light;
			_bgColor = e.DarkTheme ? _light : _dark;
		}

		if (text) text.color = _textColor;
		if (bg) bg.color = _bgColor;
	}
}