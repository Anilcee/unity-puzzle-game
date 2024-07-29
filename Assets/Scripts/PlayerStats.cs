using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    
    public Text playedGames;
    public Text totalWin;
    public Text currentStreak;
    public Text maxStreak;
    public GameObject StatsScreen;
    public int totalPlayedGames=0,winCounter=0,winStreak=0,maxWinStreak=0;
    public GameObject bar1,bar2,bar3,bar4,bar5;
    public float x1=0,x2=0,x3=0,x4=0,x5=0,score1=0,score2=0,score3=0,score4=0,score5=0;
    public Text bar1Text,bar2Text,bar3Text,bar4Text,bar5Text;
    
    
    void Start()
    {
        currentStreak.text=PlayerPrefs.GetInt("CurrentStreak",winStreak).ToString();
        maxStreak.text=PlayerPrefs.GetInt("MaxWinStreak",maxWinStreak).ToString();
        playedGames.text=PlayerPrefs.GetInt("TotalplayedGames",totalPlayedGames).ToString();
            totalWin.text=PlayerPrefs.GetInt("victory",winCounter).ToString();
            RectTransform rt1 = bar1.GetComponent<RectTransform>();
            x1=score1=PlayerPrefs.GetFloat("score1",score1)/10;
            bar1Text.text=PlayerPrefs.GetFloat("score1",score1).ToString();
            rt1.anchorMax=new Vector2(x1+0.5f,0.5f);
            RectTransform rt2 = bar2.GetComponent<RectTransform>();
            x2=score2=PlayerPrefs.GetFloat("score2",score2)/10;
            bar2Text.text=PlayerPrefs.GetFloat("score2",score2).ToString();
            rt2.anchorMax=new Vector2(x2+0.5f,0.5f);
            RectTransform rt3 = bar3.GetComponent<RectTransform>();
            x3=score3=PlayerPrefs.GetFloat("score3",score3)/10;
            bar3Text.text=PlayerPrefs.GetFloat("score3",score3).ToString();
            rt3.anchorMax=new Vector2(x3+0.5f,0.5f);
            RectTransform rt4 = bar4.GetComponent<RectTransform>();
            x4=score4=PlayerPrefs.GetFloat("score4",score4)/10;
            bar4Text.text=PlayerPrefs.GetFloat("score4",score4).ToString();
            rt4.anchorMax=new Vector2(x4+0.5f,0.5f);
            RectTransform rt5 = bar5.GetComponent<RectTransform>();
            x5=score5=PlayerPrefs.GetFloat("score5",score5)/10;
            bar5Text.text=PlayerPrefs.GetFloat("score5",score5).ToString();
            rt5.anchorMax=new Vector2(x5+0.5f,0.5f);
    }

    
    public void buttonStatsOnClick()
    {
        if(!StatsScreen.activeSelf)
        {
            currentStreak.text=PlayerPrefs.GetInt("CurrentStreak",winStreak).ToString();
            maxStreak.text=PlayerPrefs.GetInt("MaxWinStreak",maxWinStreak).ToString();
            playedGames.text=PlayerPrefs.GetInt("TotalplayedGames",totalPlayedGames).ToString();
            totalWin.text=PlayerPrefs.GetInt("victory",winCounter).ToString();
            RectTransform rt1 = bar1.GetComponent<RectTransform>();
            x1=score1=PlayerPrefs.GetFloat("score1",score1)/10;
            bar1Text.text=PlayerPrefs.GetFloat("score1",score1).ToString();
            rt1.anchorMax=new Vector2(x1+0.5f,0.5f);
            RectTransform rt2 = bar2.GetComponent<RectTransform>();
            x2=score2=PlayerPrefs.GetFloat("score2",score2)/10;
            bar2Text.text=PlayerPrefs.GetFloat("score2",score2).ToString();
            rt2.anchorMax=new Vector2(x2+0.5f,0.5f);
            RectTransform rt3 = bar3.GetComponent<RectTransform>();
            x3=score3=PlayerPrefs.GetFloat("score3",score3)/10;
            bar3Text.text=PlayerPrefs.GetFloat("score3",score3).ToString();
            rt3.anchorMax=new Vector2(x3+0.5f,0.5f);
            RectTransform rt4 = bar4.GetComponent<RectTransform>();
            x4=score4=PlayerPrefs.GetFloat("score4",score4)/10;
            bar4Text.text=PlayerPrefs.GetFloat("score4",score4).ToString();
            rt4.anchorMax=new Vector2(x4+0.5f,0.5f);
            RectTransform rt5 = bar5.GetComponent<RectTransform>();
            x5=score5=PlayerPrefs.GetFloat("score5",score5)/10;
            bar5Text.text=PlayerPrefs.GetFloat("score5",score5).ToString();
            rt5.anchorMax=new Vector2(x5+0.5f,0.5f);
            StatsScreen.SetActive(true);
        }
        else
        StatsScreen.SetActive(false);
            
        
            
            
    }
    public void buttonExitOnClick()
    {
       StatsScreen.SetActive(false);
       
    }
}

