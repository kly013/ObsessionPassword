using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    // 點擊時間
    float clickTimer = 0;
    int clickNum = 0;
    float timelag = 0.5f;

    public GameObject DialogueBG;

    public GameObject[]  ClickObjTalk;
    public Text ObjTalk;

    static public bool isTalking=false;

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
    }

    void onceClickEvent()
    {
        print("觸發單擊事件");
    }
    void doubleClickEvent()
    {
        print("觸發雙擊事件");
    }
}
