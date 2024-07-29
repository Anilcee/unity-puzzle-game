using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endGamePopUp : MonoBehaviour
{
    public PlayerStats playerStats;
    public GameObject popUp,playAgain,NEN,genius,magnificent,impressive,notBad,buzzerbeater,answer;
    public Text popUpText;
    public Buttons sonuc;
    public Image bars1,bars2,bars3,bars4,bars5;
    
    
    public void Start()
    {
        playAgain.SetActive(false);
        popUp.SetActive(false);
        bars1.color=Color.gray;
        bars2.color=Color.gray;
        bars3.color=Color.gray;
        bars4.color=Color.gray;
        bars5.color=Color.gray;
    }
    public async void PopUp()
    {
        if (sonuc.hucre != (sonuc.satir * 5) - 5)
        {
            popUp.SetActive(true);
            NEN.SetActive(true);
            await Task.Delay(1800);
            popUp.SetActive(false);
            NEN.SetActive(false);
        }
        else if (sonuc.satir == 6 && sonuc.dogrusayaci != 5)
        {
            await Task.Delay(1550);
            popUpText.text=sonuc.rastgeleSayi.ToString();
            answer.SetActive(true);
            popUp.SetActive(true);
            playerStats.totalPlayedGames=PlayerPrefs.GetInt("TotalplayedGames",playerStats.totalPlayedGames)+1;
            PlayerPrefs.SetInt("TotalplayedGames",playerStats.totalPlayedGames);
            await Task.Delay(2300);
            popUp.SetActive(false);
            answer.SetActive(false);
            playerStats.playedGames.text=PlayerPrefs.GetInt("TotalplayedGames",playerStats.totalPlayedGames).ToString();
            playerStats.winStreak=0;
            PlayerPrefs.SetInt("CurrentStreak",playerStats.winStreak);
            playerStats.currentStreak.text=PlayerPrefs.GetInt("CurrentStreak",playerStats.winStreak).ToString();
            playerStats.StatsScreen.SetActive(true);
            for(int i=0;i<12;i++)
            sonuc.bt[i].interactable=false;
            playAgain.SetActive(true);
        }
        else if(sonuc.dogrusayaci==5&&sonuc.satir!=7)
        {
            playerStats.totalPlayedGames=PlayerPrefs.GetInt("TotalplayedGames",playerStats.totalPlayedGames)+1;
            playerStats.winCounter=PlayerPrefs.GetInt("victory",playerStats.winCounter)+1;
            PlayerPrefs.SetInt("TotalplayedGames",playerStats.totalPlayedGames);
            PlayerPrefs.SetInt("victory",playerStats.winCounter);
            await Task.Delay(1550);
            popUp.SetActive(true);
            if (sonuc.satir == 2)
            {
                genius.SetActive(true);
                playerStats.score1=PlayerPrefs.GetFloat("score1",playerStats.score1)+1;
                PlayerPrefs.SetFloat("score1",playerStats.score1);
                RectTransform rt1 = playerStats.bar1.GetComponent<RectTransform>();
                playerStats.x1=playerStats.score1=PlayerPrefs.GetFloat("score1",playerStats.score1)/10;
                rt1.anchorMax=new Vector2(playerStats.x1+0.5f,0.5f);
                playerStats.bar1Text.text=PlayerPrefs.GetFloat("score1",playerStats.score1).ToString();
                bars1.color= new Color(0, 0.50f, 0, 1);
            }
                
            else if (sonuc.satir == 3)
            {
                magnificent.SetActive(true);
                playerStats.score2=PlayerPrefs.GetFloat("score2",playerStats.score2)+1;
                PlayerPrefs.SetFloat("score2",playerStats.score2);
                RectTransform rt2 = playerStats.bar2.GetComponent<RectTransform>();
                playerStats.x2=playerStats.score2=PlayerPrefs.GetFloat("score2",playerStats.score2)/10;
                rt2.anchorMax=new Vector2(playerStats.x2+0.5f,0.5f);
                playerStats.bar2Text.text=PlayerPrefs.GetFloat("score2",playerStats.score2).ToString();
                bars2.color= new Color(0, 0.50f, 0, 1);
            }
                
            else if (sonuc.satir == 4){
                
                impressive.SetActive(true);
                playerStats.score3=PlayerPrefs.GetFloat("score3",playerStats.score3)+1;
                PlayerPrefs.SetFloat("score3",playerStats.score3);
                RectTransform rt3 = playerStats.bar3.GetComponent<RectTransform>();
                playerStats.x3=playerStats.score3=PlayerPrefs.GetFloat("score3",playerStats.score3)/10;
                rt3.anchorMax=new Vector2(playerStats.x3+0.5f,0.5f);
                playerStats.bar3Text.text=PlayerPrefs.GetFloat("score3",playerStats.score3).ToString();
                bars3.color= new Color(0, 0.50f, 0, 1);
            }
                
            else if (sonuc.satir == 5){
                
                notBad.SetActive(true);
                playerStats.score4=PlayerPrefs.GetFloat("score4",playerStats.score4)+1;
                PlayerPrefs.SetFloat("score4",playerStats.score4);
                RectTransform rt4 = playerStats.bar4.GetComponent<RectTransform>();
                playerStats.x4=playerStats.score4=PlayerPrefs.GetFloat("score4",playerStats.score4)/10;
                rt4.anchorMax=new Vector2(playerStats.x4+0.5f,0.5f);
                playerStats.bar4Text.text=PlayerPrefs.GetFloat("score4",playerStats.score4).ToString();
                bars4.color= new Color(0, 0.50f, 0, 1);
            }
                
            else if (sonuc.satir == 6){
                
                buzzerbeater.SetActive(true);
                playerStats.score5=PlayerPrefs.GetFloat("score5",playerStats.score5)+1;
                PlayerPrefs.SetFloat("score5",playerStats.score5);
                RectTransform rt5 = playerStats.bar5.GetComponent<RectTransform>();
                playerStats.x5=playerStats.score5=PlayerPrefs.GetFloat("score5",playerStats.score5)/10;
                rt5.anchorMax=new Vector2(playerStats.x5+0.5f,0.5f);
                playerStats.bar5Text.text=PlayerPrefs.GetFloat("score5",playerStats.score5).ToString();
                bars5.color= new Color(0, 0.50f, 0, 1);
            }
                await Task.Delay(2300);
                genius.SetActive(false);
                magnificent.SetActive(false);
                impressive.SetActive(false);
                notBad.SetActive(false);
                buzzerbeater.SetActive(false);
                popUp.SetActive(false);
                playerStats.winStreak=PlayerPrefs.GetInt("CurrentStreak",playerStats.winStreak)+1;
                PlayerPrefs.SetInt("CurrentStreak",playerStats.winStreak);
                playerStats.currentStreak.text=PlayerPrefs.GetInt("CurrentStreak",playerStats.winStreak).ToString();
                if(playerStats.winStreak>PlayerPrefs.GetInt("MaxWinStreak",playerStats.maxWinStreak))
                {
                    playerStats.maxWinStreak=playerStats.winStreak;
                    PlayerPrefs.SetInt("MaxWinStreak",playerStats.maxWinStreak);
                    playerStats.maxStreak.text=PlayerPrefs.GetInt("MaxWinStreak",playerStats.maxWinStreak).ToString();
                }
                playerStats.playedGames.text=PlayerPrefs.GetInt("TotalplayedGames",playerStats.totalPlayedGames).ToString();
                playerStats.totalWin.text=PlayerPrefs.GetInt("victory",playerStats.winCounter).ToString();
                await Task.Delay(150);
                playerStats.StatsScreen.SetActive(true);
                for(int i=0;i<12;i++)
                sonuc.bt[i].interactable=false;
                playAgain.SetActive(true);
                
            
        }
        else
        {
            popUp.SetActive(false);
        }
        
    }
}
