using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent02 : MonoBehaviour
{
    float clickTimer = 0;
    int clickNum = 0;
    float timelag = 0.3f;

    GameObject obj;

    public BagController02 bagController02;

    private void Update()
    {
        if (clickNum > 0)
        {
            if (LevelController02.gameTimer - clickTimer >= timelag)
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

    // ·Æ¹«ÂIÀ»
    public void OnClick()
    {
        clickNum++;

        if (clickNum == 1)
        {
            clickTimer = LevelController02.gameTimer;
        }
    }

    void onceClickEvent()
    {
        Image buttonImage = GetComponent<Image>();
        Sprite sourceSprite = buttonImage.sprite;
        LevelController02.selectName = sourceSprite.name;
    }
    void doubleClickEvent()
    {
        Image buttonImage = GetComponent<Image>();
        Sprite sourceSprite = buttonImage.sprite;

        for (int i = 0; i < 3; i++)
        {
            if (LevelController02.toolsList[i].name == sourceSprite.name)
            {
                obj = LevelController02.toolsList[i];
                break;
            }
        }

        if (obj != null)
        {
            obj.gameObject.SetActive(true);
            bagController02.onChangePos(this.gameObject.name);
        }
    }
}
