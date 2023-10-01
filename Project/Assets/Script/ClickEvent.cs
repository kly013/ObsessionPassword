using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour
{
    // 點擊當下時間
    float clickTime = 0;
    // 點一次後開始計時
    float delayTime = 0;
    // 點的次數
    float clickNum = 0;
    // 設定多長時間內點兩次算雙擊
    float lagTime = 0.2f;

    // 點擊後放大可以互動的物件
    public GameObject[] objects;

    private void Update()
    {
        // 點擊後開始計時
        if (clickTime != 0)
        {
            delayTime += Time.deltaTime;
            // print("delaytime = " + delayTime);
        }

        // 時間大於所設判斷雙擊時間
        if (delayTime >= lagTime)
        {
            // 時間內沒點擊到兩次
            if (clickNum < 2)
            {
                // print("不是雙擊");
                onceClickEvent();
            }
            // 時間內點兩次以上
            else
            {
                // print("雙擊");
                doubleClickEvent();
            }

            // 將所有計時計數歸零
            delayTime = 0;
            clickTime = 0;
            clickNum = 0;
        }

    }

    // 滑鼠點擊
    void OnMouseDown()
    {
        // 按 UI 不要按到後面物件的語法
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            //print("name = " + this.gameObject.name);
            clickTime = LevelController.gameTime;
            //print("clickTime = " + clickTime);
            clickNum++;
            //print("clickNum" + clickNum);
        }
    }

    /*void OnMouseUp()
    {
        //print("click down");
        //print(this.gameObject.name);
    }*/

    // 單擊事件
    void onceClickEvent()
    {

    }

    // 雙擊事件
    void doubleClickEvent()
    {

    }
}
