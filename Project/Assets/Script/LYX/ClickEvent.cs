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
        //print("clickNum = " + clickNum);

        if (clickNum == 1)
        {
            clickTimer = LevelController.gameTimer;
            //print("�}�l�p��");
        }
    }

    void onceClickEvent()
    {
        //print("Ĳ�o�����ƥ�");
        //print(gameObject.name);

        Image buttonImage = GetComponent<Image>();
        Sprite sourceSprite = buttonImage.sprite;
        LevelController.selectName = sourceSprite.name;
        //Debug.Log("���s�� Source Image �O�G" + sourceSprite.name);
    }
    void doubleClickEvent()
    {
        //print("Ĳ�o�����ƥ�");
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
            // �ȩ�
            //print("not null , "+ this.gameObject.name);
            print(obj.name);

            obj.gameObject.SetActive(true);
            bagController.onChangePos(this.gameObject.name);
        }
    }
}
