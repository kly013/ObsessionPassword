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

    // 滑鼠點擊
    void OnMouseDown()
    {
        clickNum++;
        print("clickNum = " + clickNum);

        if (clickNum == 1)
        {
            clickTimer = LevelController.gameTimer;
            print("開始計時");
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
        print("觸發單擊事件");
        
        //objectCanvas.SetActive(true);
        //objectText.SetActive(true);
        //spaceCanvas.SetActive(true);

        //print(this.gameObject.name);

        /*
         * 單擊事件寫在這
         */

        if (RayScript.hit.collider.gameObject == ClickObjTalk)
        {
            ObjTalk.text = "一張普通的床";
        }
        else
        {
            print(RayScript.hit.collider.gameObject);
        }


        //if (RayScript.hit.collider.gameObject == ClickObjTalk[0])
        //{
        //    ObjTalk.text = "一張普通的床";           
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[1])
        //{
        //    ObjTalk.text = "一個看起來很好吃的蛋糕";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[2])
        //{
        //    ObjTalk.text = "一堆普通的作業本";
        //}
        //if (RayScript.hit.collider.gameObject ==  ClickObjTalk[3])
        //{
        //    ObjTalk.text = "一堆普通的作業本";
        //}
        //if (RayScript.hit.collider.gameObject ==  ClickObjTalk[4])
        //{
        //    ObjTalk.text = "一堆普通的作業本";
        //}

        //if (RayScript.hit.collider.gameObject == ClickObjTalk[5])
        //{
        //    ObjTalk.text = "打不開，應該是沒電";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[6])
        //{
        //    ObjTalk.text = "一張普通的椅子";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[7])
        //{
        //    ObjTalk.text = "看起來就是普通的充電線";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[8])
        //{
        //    ObjTalk.text = "看起來是爺爺的衣服";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[9])
        //{
        //    ObjTalk.text = "看起來很普通的咖啡";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[10])
        //{
        //    ObjTalk.text = "好多狗飼料";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[11])
        //{
        //    ObjTalk.text = "普通的狗窩";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[12])
        //{
        //    ObjTalk.text = "普通的放大鏡，有放大字的功能";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[13])
        //{
        //    ObjTalk.text = "看起來很普通的牛奶";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[14])
        //{
        //    ObjTalk.text = "普通的筆";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[15])
        //{
        //    ObjTalk.text = "普通的筆";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[16])
        //{
        //    ObjTalk.text = "好熱好想吃";
        //}

        //if (RayScript.hit.collider.gameObject == ClickObjTalk[17])
        //{
        //    ObjTalk.text = "不要浪費水";

        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[18])
        //{
        //    ObjTalk.text = "看起來像普通的飼料碗";
        //}
        //if (RayScript.hit.collider.gameObject == ClickObjTalk[19])
        //{
        //    ObjTalk.text = "看起來像普通的飼料碗";
        //}


    }

    void doubleClickEvent()
    {
        print("觸發雙擊事件");

        objectImg.SetActive(true);

        /*
         * 雙擊事件寫在這
         */
    }
}
