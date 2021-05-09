using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class MenuManager : MonoBehaviour
{
    private static readonly int Opened = Animator.StringToHash("opened");
    [FormerlySerializedAs("Menu")] public Animator menu;
    [FormerlySerializedAs("Screens")] public GameObject screens;
    private Coroutine move;

    public void SetOpened(bool state)
    {
        menu.SetBool(Opened, state);
    }

    public void OpenWindow(int a)
    {
        if (move != null) StopCoroutine(move);
        move = StartCoroutine(MoveTo(a));
        SetOpened(false);
    }

    private IEnumerator MoveTo(int a)
    {
        var target = new Vector3(-2160f * a, 0f, 0f);
        while (Vector3.Distance(screens.transform.localPosition, target) > 0.01f)
        {
            screens.transform.localPosition =
                Vector3.Lerp(screens.transform.localPosition, target, Time.deltaTime * 10f);
            yield return null;
        }
    }
}