using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
	private const string GameId = "4070207";
	private const string SurfacingId = "Banner";


	private void Start()
	{
		Advertisement.Initialize(GameId);
		Debug.Log("Unity Ads is initialized.");
		StartCoroutine(ShowBannerWhenInitialized());
	}

	private static IEnumerator ShowBannerWhenInitialized()
	{
		while (!Advertisement.isInitialized)
		{
			yield return new WaitForSeconds(1f);
		}

		Debug.Log("Banner is initialized.");
		Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
		Advertisement.Banner.Show(SurfacingId);
	}
}