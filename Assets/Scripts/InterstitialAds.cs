using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class InterstitialAds : MonoBehaviour,IUnityAdsLoadListener,IUnityAdsShowListener
{
    [SerializeField] private string androidUnitId;

    public void LoadInterstitialAd()
    {
        Advertisement.Load(androidUnitId,this);
    }

    public void ShowInterstitialAd()
    {
        Advertisement.Show(androidUnitId,this);
        LoadInterstitialAd();
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("Interstitial Ad Loaded");
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {

    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        
    }
}
