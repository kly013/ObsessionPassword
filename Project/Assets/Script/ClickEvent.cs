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

    public GameObject objectCanvas;
    public GameObject spaceCanvas;
    public GameObject objectImg;
    public GameObject objectText;

    public GameObject ClickObjTalk;
    public Text ObjTalk;

    private void Start()
    {
        

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
        
    }

    /*void OnMouseUp()
    {
        //print("click down");
        //print(this.gameObject.name);
    }*/

    void onceClickEvent()
    {
        print("Ĳ�o�����ƥ�");
        
        //objectCanvas.SetActive(true);
        //objectText.SetActive(true);
        //spaceCanvas.SetActive(true);

        //print(this.gameObject.name);

        /*
         * �����ƥ�g�b�o
         */

        if (RayScript.hit.collider.gameObject == ClickObjTalk)
        {
            ObjTalk.text = "�@�i���q����";
        }
        else
        {
            print(RayScript.hit.collider.gameObject);
        }


        //if (RayScript.hit.collider.gameObject == ClickObjTalk[0])
        //{
        //    ObjTalk.text = "�@�i���q����";           
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[1])
        //{
        //    ObjTalk.text = "�@�Ӭݰ_�ӫܦn�Y���J�|";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[2])
        //{
        //    ObjTalk.text = "�@�ﴶ�q���@�~��";
        //}
        //if (RayScript.hit.collider.gameObject ==  ClickObjTalk[3])
        //{
        //    ObjTalk.text = "�@�ﴶ�q���@�~��";
        //}
        //if (RayScript.hit.collider.gameObject ==  ClickObjTalk[4])
        //{
        //    ObjTalk.text = "�@�ﴶ�q���@�~��";
        //}

        //if (RayScript.hit.collider.gameObject == ClickObjTalk[5])
        //{
        //    ObjTalk.text = "�����}�A���ӬO�S�q";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[6])
        //{
        //    ObjTalk.text = "�@�i���q���Ȥl";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[7])
        //{
        //    ObjTalk.text = "�ݰ_�ӴN�O���q���R�q�u";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[8])
        //{
        //    ObjTalk.text = "�ݰ_�ӬO�ݷݪ���A";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[9])
        //{
        //    ObjTalk.text = "�ݰ_�ӫܴ��q���@��";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[10])
        //{
        //    ObjTalk.text = "�n�h���}��";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[11])
        //{
        //    ObjTalk.text = "���q������";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[12])
        //{
        //    ObjTalk.text = "���q����j��A����j�r���\��";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[13])
        //{
        //    ObjTalk.text = "�ݰ_�ӫܴ��q������";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[14])
        //{
        //    ObjTalk.text = "���q����";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[15])
        //{
        //    ObjTalk.text = "���q����";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[16])
        //{
        //    ObjTalk.text = "�n���n�Q�Y";
        //}

        //if (RayScript.hit.collider.gameObject == ClickObjTalk[17])
        //{
        //    ObjTalk.text = "���n���O��";

        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[18])
        //{
        //    ObjTalk.text = "�ݰ_�ӹ����q���}�ƸJ";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[19])
        //{
        //    ObjTalk.text = "�ݰ_�ӹ����q���}�ƸJ";
        //}


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
