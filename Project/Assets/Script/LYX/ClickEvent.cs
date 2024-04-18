using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    // �I���ɶ�
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

    // �ƹ��I��
    public void OnClick()
    {
        clickNum++;

        // �}�l�p��
        if (clickNum == 1)
        {
            clickTimer = LevelController.gameTimer;
        }
    }

    void onceClickEvent()
    {
        // Ĳ�o�����ƥ�

        Image buttonImage = GetComponent<Image>();
        Sprite sourceSprite = buttonImage.sprite;
        LevelController.selectName = sourceSprite.name;
    }
    void doubleClickEvent()
    {
        // Ĳ�o�����ƥ�
        Image buttonImage = GetComponent<Image>();
        Sprite sourceSprite = buttonImage.sprite;

        for (int i = 0; i < LevelController.toolsList.Count; i++)
        {
            if (LevelController.toolsList[i].name == sourceSprite.name)
            {
                obj = LevelController.toolsList[i];
                break;
            }
        }

        if (obj != null)
        {
            obj.gameObject.SetActive(true);
            bagController.onChangePos(this.gameObject.name);
        }
    }
}
