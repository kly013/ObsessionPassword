using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour
{
    // �I����U�ɶ�
    float clickTime = 0;
    // �I�@����}�l�p��
    float delayTime = 0;
    // �I������
    float clickNum = 0;
    // �]�w�h���ɶ����I�⦸������
    float lagTime = 0.2f;

    // �I�����j�i�H���ʪ�����
    public GameObject[] objects;

    private void Update()
    {
        // �I����}�l�p��
        if (clickTime != 0)
        {
            delayTime += Time.deltaTime;
            // print("delaytime = " + delayTime);
        }

        // �ɶ��j��ҳ]�P�_�����ɶ�
        if (delayTime >= lagTime)
        {
            // �ɶ����S�I����⦸
            if (clickNum < 2)
            {
                // print("���O����");
                onceClickEvent();
            }
            // �ɶ����I�⦸�H�W
            else
            {
                // print("����");
                doubleClickEvent();
            }

            // �N�Ҧ��p�ɭp���k�s
            delayTime = 0;
            clickTime = 0;
            clickNum = 0;
        }

    }

    // �ƹ��I��
    void OnMouseDown()
    {
        // �� UI ���n����᭱���󪺻y�k
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

    // �����ƥ�
    void onceClickEvent()
    {

    }

    // �����ƥ�
    void doubleClickEvent()
    {

    }
}
