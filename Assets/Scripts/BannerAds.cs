using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAds : MonoBehaviour
{
    [SerializeField] private string androidUnitId;

    private void Awake()
    {
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
    }

    public void LoadBannerAd()
    {
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback=BannerLoaded,
            errorCallback=BannerLoadedError
        };
        Advertisement.Banner.Load(androidUnitId,options);
    }

    public void ShowBannerAd()
    {
        BannerOptions options= new BannerOptions
        {
            showCallback= BannerShown,
            clickCallback=BannerClicked
        };
    }

    private void BannerClicked()
    {
        throw new NotImplementedException();
    }

    private void BannerShown()
    {
        Debug.Log("Banner shown");
    }

    private void BannerLoadedError(string message)
    {

    }

    private void BannerLoaded()
    {
        Debug.Log("Banner Ad Loaded");
    }
}
