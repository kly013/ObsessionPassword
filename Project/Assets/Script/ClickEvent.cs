using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour
{
    // 點擊時間
    float clickTimer = 0;
    int clickNum = 0;
    float timelag = 0.5f;

    public GameObject objectCanvas;
    public GameObject objectImg;
    public GameObject objectText;

    private void Update()
    {
        if (clickNum > 0)
        {
            if (LevelController.gameTimer - clickTimer >= timelag)
            {
                if (clickNum < 2)
                {
                    onceClickEvent();
                }
                else
                {
                    doubleClickEvent();
                }
                clickNum = 0;
            }
        }
    }

    // 滑鼠點擊
    void OnMouseDown()
    {
        clickNum++;
        print("clickNum = " + clickNum);

        if (clickNum == 1)
        {
            clickTimer = LevelController.gameTimer;
            print("開始計時");
        }

        //print("click down");
        //print(this.gameObject.name);
    }

    /*void OnMouseUp()
    {
        //print("click down");
        //print(this.gameObject.name);
    }*/

    void onceClickEvent()
    {
        print("觸發單擊事件");
        objectCanvas.SetActive(true);
        objectText.SetActive(true);

        /*
         * 單擊事件寫在這
         */
    }

    void doubleClickEvent()
    {
        print("觸發雙擊事件");

        objectImg.SetActive(true);

        /*
         * 雙擊事件寫在這
         */
    }
}
