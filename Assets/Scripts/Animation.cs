using UnityEngine;
using System.Threading.Tasks;

public class Animation : MonoBehaviour
{
    public Buttons buttons;
    int a=0,b=0,c=0,d=0,e=0;
        public async void enterOnClick(){
            if(buttons.satir==2&&a<1)
            for(int i=0; i<5;i++){
                a++;
                await Task.Delay(140);
                buttons.cellList[i].transform.LeanRotate(new Vector2(90,0),0.140f);
                await Task.Delay(140);
                buttons.cellList[i].transform.LeanRotate(new Vector2(0,0),0.140f);
            }
            else if(buttons.satir==3&&b<1)
            for(int i=5; i<10;i++){
                b++;
                await Task.Delay(140);
                buttons.cellList[i].transform.LeanRotate(new Vector2(90,0),0.140f);
                await Task.Delay(140);
                buttons.cellList[i].transform.LeanRotate(new Vector2(0,0),0.140f);
            }
            else if(buttons.satir==4&&c<1)
            for(int i=10; i<15;i++){
                c++;
                await Task.Delay(140);
                buttons.cellList[i].transform.LeanRotate(new Vector2(90,0),0.140f);
                await Task.Delay(140);
                buttons.cellList[i].transform.LeanRotate(new Vector2(0,0),0.140f);
            }
            else if(buttons.satir==5&&d<1)
            for(int i=15; i<20;i++){
                d++;
                await Task.Delay(140);
                buttons.cellList[i].transform.LeanRotate(new Vector2(90,0),0.140f);
                await Task.Delay(140);
                buttons.cellList[i].transform.LeanRotate(new Vector2(0,0),0.140f);
            }
            else if(buttons.satir==6&&e<1)
            for(int i=20; i<25;i++){
                e++;
                await Task.Delay(140);
                buttons.cellList[i].transform.LeanRotate(new Vector2(90,0),0.140f);
                await Task.Delay(140);
                buttons.cellList[i].transform.LeanRotate(new Vector2(0,0),0.140f);
                
            }
        }
    }
 
