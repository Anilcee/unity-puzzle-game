using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howToPlay : MonoBehaviour
{
    public PlayerStats vic;
    public GameObject info;
    public void buttonQuitOnClick()
    {
        info.SetActive(false);
    }
    public void infoButton()
    {
        if(!info.activeSelf)
        info.SetActive(true);
        else
        info.SetActive(false);
    }
}
