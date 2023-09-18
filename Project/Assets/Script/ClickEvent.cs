using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour
{
    // �I���ɶ�
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
        print("Ĳ�o�����ƥ�");
        objectCanvas.SetActive(true);
        objectText.SetActive(true);

        /*
         * �����ƥ�g�b�o
         */
    }

    void doubleClickEvent()
    {
        print("Ĳ�o�����ƥ�");

        objectImg.SetActive(true);

        /*
         * �����ƥ�g�b�o
         */
    }
}
