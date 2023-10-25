using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayScript : MonoBehaviour
{

    Ray ray;
    float raylength = 1.5f;
    static public RaycastHit hit;

    public GameObject PressE;

    public string[] Tags;

    // Start is called before the first frame update
    void Start()
    {
        PressE.SetActive(false);
<<<<<<< HEAD
        DialogueBG.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
=======
>>>>>>> origin/main
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (isTalking == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }



=======
>>>>>>> origin/main
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        //由攝影機射到是畫面正中央的射線

        if (Physics.Raycast(ray, out hit, raylength))
        // (射線,out 被射線打到的物件,射線長度)，out hit 意思是：把"被射線打到的物件"帶給hit
        {
            hit.transform.SendMessage("HitByRaycast", gameObject, SendMessageOptions.DontRequireReceiver);

            HitByRaycast2();

            //向被射線打到的物件呼叫名為"HitByRaycast"的方法，不需要傳回覆

            Debug.DrawLine(ray.origin, hit.point, Color.yellow);
            //當射線打到物件時會在Scene視窗畫出黃線，方便查閱

            //print("這個在射線名字是"+hit.transform.name);
            //print("這個Tag是"+hit.transform.tag);
            //在Console視窗印出被射線打到的物件名稱，方便查閱                       
        }

<<<<<<< HEAD
        if (Input.GetMouseButton(0))
        {
            for (int i = 0; i < ClickObjTalk.Length; i++)
            {

                if (hit.transform.gameObject == ClickObjTalk[i])
                {
                    isTalking = true;
                    DialogueBG.SetActive(true);
                    break;

                }


            }
            RayOnUI();
            ClickObjectDialogueText();
            ClickTable();
        }
    }


    void ClickTable()
    {
        if(hit.collider.gameObject.name== "Table002")
        {
            hit.transform.SendMessage("ClickTable02", gameObject, SendMessageOptions.DontRequireReceiver);
        }
    }


    void RayOnUI()
    {

        if (Physics.Raycast(ray, out hit, raylength) && !EventSystem.current.IsPointerOverGameObject())
        {

            Debug.Log("點擊");

        }
=======
>>>>>>> origin/main
    }

    void HitByRaycast2()
    {

        foreach (string tag in Tags)
        {
            if (string.Equals(tag, hit.transform.tag))
            {
                
                PressE.SetActive(true);
                break;

            }
            else
            {

                PressE.SetActive(false);

            }

        }


    }

<<<<<<< HEAD
    void ClickObjectDialogueText()
    {
        if (RayScript.hit.collider.gameObject == ClickObjTalk[0])
        {
            ObjTalk.text = "一張普通的床";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[1])
        {
            ObjTalk.text = "一個看起來很好吃的蛋糕";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[2])
        {
            ObjTalk.text = "一堆普通的作業本";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[3])
        {
            ObjTalk.text = "一堆普通的作業本";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[4])
        {
            ObjTalk.text = "一堆普通的作業本";
        }

        if (RayScript.hit.collider.gameObject == ClickObjTalk[5])
        {
            ObjTalk.text = "打不開，應該是沒電";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[6])
        {
            ObjTalk.text = "一張普通的椅子";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[7])
        {
            ObjTalk.text = "看起來就是普通的充電線";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[8])
        {
            ObjTalk.text = "看起來是爺爺的衣服";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[9])
        {
            ObjTalk.text = "看起來很普通的咖啡";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[10])
        {
            ObjTalk.text = "好多狗飼料";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[11])
        {
            ObjTalk.text = "普通的狗窩";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[12])
        {
            ObjTalk.text = "看起來很普通的牛奶";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[13])
        {
            ObjTalk.text = "普通的筆";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[14])
        {
            ObjTalk.text = "普通的筆";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[15])
        {
            ObjTalk.text = "好熱好想吃";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[16])
        {
            ObjTalk.text = "不要浪費水";
        }

        if (RayScript.hit.collider.gameObject == ClickObjTalk[17])
        {
            ObjTalk.text = "看起來像普通的飼料碗";

        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[18])
        {
            ObjTalk.text = "看起來像普通的飼料碗";
        }




    }

    public void ButtonClick()
    {
        isTalking = false;
        DialogueBG.SetActive(false);
    }




=======
>>>>>>> origin/main
}
