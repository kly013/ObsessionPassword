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

    // �ƹ��I��
    void OnMouseDown()
    {
        clickNum++;
        print("clickNum = " + clickNum);

        if (clickNum == 1)
        {
            clickTimer = LevelController.gameTimer;
            print("�}�l�p��");
        }
    }

    void onceClickEvent()
    {
        print("Ĳ�o�����ƥ�");
    }
    void doubleClickEvent()
    {
        print("Ĳ�o�����ƥ�");
    }
}
