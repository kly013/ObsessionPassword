using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour
{
    // �I���ɶ�
    float clickTimer = 0;

    public GameObject objectCanvas;
    public GameObject objectImg;
    public GameObject objectText;

    bool isClick = false;

    // �ƹ��I��
    void OnMouseDown()
    {
        if (clickTimer == 0)
        {
            clickTimer = LevelController.gameTimer;
            print("�}�l�p��");
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
            print("���O����");

            objectText.SetActive(true);

            /*
             * �u�I�@�U
             * ���X��ܮءA��ܻ�����r
             */
        }
        else
        {
            print("Ĳ�o�����ƥ�");

            objectImg.SetActive(true);

            /*
             * �����ƥ�g�b�o
             */

            clickTimer = 0;
        }
    }
}
