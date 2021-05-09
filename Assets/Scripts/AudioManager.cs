using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource click, win;

    public void PlayClick()
    {
        click.Play();
    }

    public void PlayWin()
    {
        win.Play();
    }
}