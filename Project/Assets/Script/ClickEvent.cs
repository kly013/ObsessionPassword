using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour
{
    // 點擊時間
    float clickTimer = 0;

    public GameObject objectCanvas;
    public GameObject objectImg;
    public GameObject objectText;

    bool isClick = false;

    // 滑鼠點擊
    void OnMouseDown()
    {
        if (clickTimer == 0)
        {
            clickTimer = LevelController.gameTimer;
            print("開始計時");
            isClick = true;
        }
        
        isDoubleClick(1.0f);

        //print("click down");
        //print(this.gameObject.name);
    }

    /*void OnMouseUp()
    {
        //print("click down");
        //print(this.gameObject.name);
    }*/

    void isDoubleClick(float timelag)
    {
        float timer = 0;
        isClick = false;

        while (timer < timelag)
        {
            timer += Time.deltaTime;
            print(timer);
            if (isClick)
                break;
        }

        if (timer >= timelag)
        {
            clickTimer = 0;
            print("不是雙擊");

            objectText.SetActive(true);

            /*
             * 只點一下
             * 跳出對話框，顯示說明文字
             */
        }
        else
        {
            print("觸發雙擊事件");

            objectImg.SetActive(true);

            /*
             * 雙擊事件寫在這
             */

            clickTimer = 0;
        }
    }
}
