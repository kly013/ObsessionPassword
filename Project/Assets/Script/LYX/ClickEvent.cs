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
    float timelag = 0.3f;

    // bool isSelected = false;

    GameObject obj;

    public BagController bagController;

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
        Image buttonImage = GetComponent<Image>();
        Sprite sourceSprite = buttonImage.sprite;

        for (int i = 0; i < 3; i++)
        {
            if (LevelController.toolsList[i].name == sourceSprite.name)
            {
                obj = LevelController.toolsList[i];
                break;
            }
        }

        if (obj != null)
        {
            // 暫放
            //print("not null , "+ this.gameObject.name);
            print(obj.name);

            obj.gameObject.SetActive(true);
            bagController.onChangePos(this.gameObject.name);
        }
    }
}
