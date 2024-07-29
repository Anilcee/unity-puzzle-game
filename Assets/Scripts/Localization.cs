using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Localization : MonoBehaviour
{
    // Start is called before the first frame update
    public int launguageID;
    public void Awake()
    {
        if(Application.systemLanguage==SystemLanguage.Turkish)
        {
            launguageID=1;
            changeLaunguage(launguageID);
        }
        else
        {
            launguageID=0;
            changeLaunguage(launguageID);

        }
    }

    public void changeLaunguage(int localeID)
    {
        LocalizationSettings.SelectedLocale=LocalizationSettings.AvailableLocales.Locales[localeID];
    }
}
