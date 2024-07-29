using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject howToPlay;
    public List<Image> Letterlist= new List<Image>();
    public List<Image> backColor= new List<Image>();
    public List<Text> textColor= new List<Text>();
     async void Awake(){  
        for(int i=0; i<8;i++)
        {
            await Task.Delay(100);
            Letterlist[i].transform.LeanRotate(new Vector2(90,0),0.10f);
            await Task.Delay(100);
            backColor[i].color = new Color(0, 0.50f, 0, 1);
            textColor[i].color = Color.white;
            Letterlist[i].color=new Color(0, 0.50f, 0, 1);
            Letterlist[i].transform.LeanRotate(new Vector2(0,0),0.10f);
        }
    }
    public void playButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void howToPlayButton()
    {
        howToPlay.SetActive(true);
    }
    public void exitButton()
    {
        howToPlay.SetActive(false);
    }
    public void quitButton()
    {
        Application.Quit();
    }
    
}
