using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;


public class Buttons : MonoBehaviour
{
        int [] greenList= new int[5];
        int [] orangeLİst= new int[5];
        int [] grayList= new int[5];
    public List<Button> bt= new List<Button>();
    public List<Text> textList = new List<Text>();
    public List<Text> buttonList = new List<Text>();
    public List<Image> imageList = new List<Image>();
    public List<Image> cellList = new List<Image>();
    public int hucre = 0, satir = 1, rastgeleSayi = 0,dogrusayaci=0;
    public char[] cevapKontrol = new char[5];
    string cevap = "";

    public async void Button0OnClick()
    {
        if (hucre < satir * 5)
        {
            cellList[hucre].transform.LeanScale(new Vector2(1.15f,1.15f),0.1f);
            await Task.Delay(100);
            textList[hucre].text = buttonList[0].text;
            cellList[hucre].color=Color.black;
            cellList[hucre].transform.LeanScale(new Vector2(1,1),0.1f);
            hucre++;
            await Task.Delay(100);
        }
    }
    public void Start()
    {
        rastgeleSayi = Random.Range(10000, 99999);
        cevap = rastgeleSayi.ToString();
    }

    public async void Button1OnClick()
    {
        if (hucre < satir * 5)
        {
            cellList[hucre].transform.LeanScale(new Vector2(1.15f,1.15f),0.1f);
            await Task.Delay(100);
            textList[hucre].text = buttonList[1].text;
            cellList[hucre].color=Color.black;
            cellList[hucre].transform.LeanScale(new Vector2(1,1),0.1f);
            hucre++;
            await Task.Delay(100);
        }

    }
    public async void Button2OnClick()
    {
        if (hucre < satir * 5)
        {
            cellList[hucre].transform.LeanScale(new Vector2(1.15f,1.15f),0.1f);
            await Task.Delay(100);
            textList[hucre].text = buttonList[2].text;
            cellList[hucre].color=Color.black;
            cellList[hucre].transform.LeanScale(new Vector2(1,1),0.1f);
            hucre++;
            await Task.Delay(100);
        }
    }
    public async void Button3OnClick()
    {
        if (hucre < satir * 5)
        {
            cellList[hucre].transform.LeanScale(new Vector2(1.15f,1.15f),0.1f);
            await Task.Delay(100);
            textList[hucre].text = buttonList[3].text;
            cellList[hucre].color=Color.black;
            cellList[hucre].transform.LeanScale(new Vector2(1,1),0.1f);
            hucre++;
            await Task.Delay(100);
        }
    }
    public async void Button4OnClick()
    {
        if (hucre < satir * 5)
        {
            cellList[hucre].transform.LeanScale(new Vector2(1.15f,1.15f),0.1f);
            await Task.Delay(100);
            textList[hucre].text = buttonList[4].text;
            cellList[hucre].color=Color.black;
            cellList[hucre].transform.LeanScale(new Vector2(1,1),0.1f);
            hucre++;
            await Task.Delay(100);
        }
    }
    public async void Button5OnClick()
    {
        if (hucre < satir * 5)
        {
            cellList[hucre].transform.LeanScale(new Vector2(1.15f,1.15f),0.1f);
            await Task.Delay(100);
            textList[hucre].text = buttonList[5].text;
            cellList[hucre].color=Color.black;
            cellList[hucre].transform.LeanScale(new Vector2(1,1),0.1f);
            hucre++;
            await Task.Delay(100);
        }
    }
    public async void Button6OnClick()
    {
        if (hucre < satir * 5)
        {
            cellList[hucre].transform.LeanScale(new Vector2(1.15f,1.15f),0.1f);
            await Task.Delay(100);
            textList[hucre].text = buttonList[6].text;
            cellList[hucre].color=Color.black;
            cellList[hucre].transform.LeanScale(new Vector2(1,1),0.1f);
            hucre++;
            await Task.Delay(100);
        }
    }
    public async void Button7OnClick()
    {
        if (hucre < satir * 5)
        {
            cellList[hucre].transform.LeanScale(new Vector2(1.15f,1.15f),0.1f);
            await Task.Delay(100);
            textList[hucre].text = buttonList[7].text;
            cellList[hucre].color=Color.black;
            cellList[hucre].transform.LeanScale(new Vector2(1,1),0.1f);
            hucre++;
            await Task.Delay(100);
        }
    }
    public async void Button8OnClick()
    {
        if (hucre < satir * 5)
        {
            textList[hucre].text = buttonList[8].text;
            cellList[hucre].transform.LeanScale(new Vector2(1.15f,1.15f),0.1f);
            await Task.Delay(100);
            cellList[hucre].color=Color.black;
            cellList[hucre].transform.LeanScale(new Vector2(1,1),0.1f);
            hucre++;
            await Task.Delay(100);  
        }
    }
    public async void Button9OnClick()
    {
        if (hucre < satir * 5)
        {
            cellList[hucre].transform.LeanScale(new Vector2(1.15f,1.15f),0.1f);
            await Task.Delay(100);
            cellList[hucre].color=Color.black;
            textList[hucre].text = buttonList[9].text;
            cellList[hucre].transform.LeanScale(new Vector2(1,1),0.1f);
            hucre++;
            await Task.Delay(100);
            
        }
    }
    public void ButtonDelOnClick()
    {
        if (satir == ((hucre - 1) / 5) + 1 && hucre > 0)
        {
            textList[hucre - 1].text = "";
            cellList[hucre-1].color=Color.gray;
            hucre--;
        }
    }
    public async void ButtonEnterOnClick()
    {
        int a=0,b=0,c=0;
         dogrusayaci = 0;
        if (satir != 6)
            if (hucre == satir * 5)
            {
                cevapKontrol = (cevap.ToString()).ToCharArray();
                for (int i = 0; i < 5; i++)
                {
                    if (cevapKontrol[i].ToString() == (textList[hucre - 5 + i].text))
                    {
                        
                        imageList[hucre - 5 + i].color = new Color(0, 0.50f, 0, 1);
                        textList[hucre - 5 + i].color = Color.white;
                        cevapKontrol[i] = 'a';
                        dogrusayaci++;
                        greenList[a]=hucre - 5 + i;
                        a++;
                    }
                }
                for (int i = 0; i < 5; i++)
                    for (int j = hucre - 5; j < hucre; j++)
                    {
                        if (cevapKontrol[i].ToString() == (textList[j].text) && imageList[j].color != new Color(0.7882354f, 0.7058824f, 0.345098f, 1) && imageList[j].color != new Color(0, 0.50f, 0, 1))
                        {
                            imageList[j].color = new Color(0.7882354f, 0.7058824f, 0.345098f, 1);
                            textList[j].color = Color.white;
                            cevapKontrol[i] = 'a';
                            orangeLİst[b]=j;
                            b++;
                        }
                    }
                for (int j = hucre - 5; j < hucre; j++)
                {
                    if (imageList[j].color != new Color(0.7882354f, 0.7058824f, 0.345098f, 1) && imageList[j].color != new Color(0, 0.50f, 0, 1))
                    {
                        imageList[j].color = Color.gray;
                        textList[j].color = Color.white;
                        grayList[c]=j;
                        c++;
                    }
                }
                satir++;
                cevapKontrol = "".ToCharArray();

                for (int i =a;i<5;i++)
                {
                    greenList[i]=40;
                }
                for (int i=b;i<5;i++)
                {
                    orangeLİst[i]=40;
                }
                for (int i=c;i<5;i++)
                {
                    grayList[i]=40;
                }
                for(int i=hucre-5;i<hucre;i++)
                {
                    imageList[i].color = Color.white;
                    textList[i].color = Color.black;
                }
                for(int i=hucre-5;i<hucre;i++)
                {
                    for(int j=0;j<5;j++)
                    {
                        if(imageList[i].color!=new Color(0.7882354f, 0.7058824f, 0.345098f, 1)&&imageList[i].color != new Color(0, 0.50f, 0, 1))
                        {
                            if(greenList[j]==i)
                            {
                                await Task.Delay(145);
                                imageList[i].color = new Color(0, 0.50f, 0, 1);
                                 cellList[i].color = new Color(0, 0.50f, 0, 1);
                                textList[i].color = Color.white;
                                await Task.Delay(135);
                            }
                            else if(orangeLİst[j]==i)
                            {
                                await Task.Delay(145);
                                imageList[i].color = new Color(0.7882354f, 0.7058824f, 0.345098f, 1);
                                cellList[i].color = new Color(0.7882354f, 0.7058824f, 0.345098f, 1);
                                textList[i].color = Color.white;
                                await Task.Delay(135);
                            }
                            else if(grayList[j]==i)
                            {
                                await Task.Delay(145);
                                imageList[i].color = Color.gray;
                                cellList[i].color = Color.gray;
                                textList[i].color = Color.white;
                                await Task.Delay(135);
                            }
                        }
                    }
                }
            }
            else
            {
                
                
            }
    }
}
