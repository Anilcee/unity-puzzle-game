using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializer : MonoBehaviour,IUnityAdsInitializationListener
{
    [SerializeField] private string androidGameId;
    [SerializeField] private bool isTesting;


    private void Awake()
    {
        if(!Advertisement.isInitialized && Advertisement.isSupported)
        {
            Advertisement.Initialize(androidGameId,isTesting,this);
        }
    }
    

    public void OnInitializationComplete()
    {
        Debug.Log("Ads initialized.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {

    }
}
