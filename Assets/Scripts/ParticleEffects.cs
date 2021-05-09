using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleEffects : MonoBehaviour
{
    private static ParticleSystem _numberGlow;
    public Gradient[] gradients;
    private static Gradient[] _gradients;

    private void Start()
    {
        _numberGlow = GetComponent<ParticleSystem>();
        _gradients = gradients;
    }

    public void Stop()
    {
        _numberGlow.Stop();
    }

    public static void Play(int rang)
    {
        var gradientColor = _numberGlow.colorOverLifetime;
        gradientColor.color = _gradients[Mathf.Clamp(rang - 1, 0, _gradients.Length - 1)];
        _numberGlow.Play();
    }
}
