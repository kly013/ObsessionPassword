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

    bool isSelected = false;
    Button button;

    private void Start()
    {
        button = GetComponent<Button>();
    }

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
    public void OnClick()
    {
        clickNum++;
        //print("clickNum = " + clickNum);

        if (clickNum == 1)
        {
            clickTimer = LevelController.gameTimer;
            //print("開始計時");
        }
    }

    void onceClickEvent()
    {
        //print("觸發單擊事件");
        //print(gameObject.name);

        Image buttonImage = GetComponent<Image>();
        Sprite sourceSprite = buttonImage.sprite;
        LevelController.selectName = sourceSprite.name;
        //Debug.Log("按鈕的 Source Image 是：" + sourceSprite.name);
    }
    void doubleClickEvent()
    {
        //print("觸發雙擊事件");
    }
}
