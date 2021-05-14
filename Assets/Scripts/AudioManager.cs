using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
	private AudioSource _source;
	[SerializeField] private AudioClip click, win;

	private void Start()
	{
		_source = GetComponent<AudioSource>();
	}

	public void PlayClick()
	{
		_source.PlayOneShot(click);
	}

	public void PlayWin()
	{
		_source.PlayOneShot(win);
	}
}