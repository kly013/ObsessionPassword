using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RayScript : MonoBehaviour
{

    Ray ray;
    float raylength = 1.5f;
    static public RaycastHit hit;

    public GameObject PressE;

    public string[] Tags;

    static public bool isTalking = false;
    public GameObject[] ClickObjTalk;
    public GameObject[] DogListener;
    public GameObject DialogueBG;
    public Text ObjTalk;
    bool CanHearDog=false;

    public GameObject CameraShelf;
    // Start is called before the first frame update
    void Start()
    {
        PressE.SetActive(false);
        DialogueBG.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
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



        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        //由攝影機射到是畫面正中央的射線

        if (Physics.Raycast(ray, out hit, raylength) && !EventSystem.current.IsPointerOverGameObject())
        // (射線,out 被射線打到的物件,射線長度)，out hit 意思是：把"被射線打到的物件"帶給hit
        {
            hit.transform.SendMessage("HitByRaycast", gameObject, SendMessageOptions.DontRequireReceiver);

            HitByRaycast2();

            //向被射線打到的物件呼叫名為"HitByRaycast"的方法，不需要傳回覆

            Debug.DrawLine(ray.origin, hit.point, Color.yellow);
            //當射線打到物件時會在Scene視窗畫出黃線，方便查閱

            //print("這個在射線名字是"+hit.transform.name);
            //在Console視窗印出被射線打到的物件名稱，方便查閱



        }

        if (Input.GetMouseButton(0))
        {

            if (hit.collider.gameObject.name == "DogCollar")
            {
                CanHearDog = true;
            }


            for (int i = 0; i < ClickObjTalk.Length; i++)
            {

                if (hit.transform.gameObject == ClickObjTalk[i])
                {
                    isTalking = true;
                    DialogueBG.SetActive(true);
                    break;
                }

            }
            for(int r = 0; r < DogListener.Length; r++)
            {
                if (hit.transform.gameObject == DogListener[r])
                {
                    isTalking = true;
                    DialogueBG.SetActive(true);
                    break;
                }
            }



            if (CanHearDog == true)
            {
                HearDogText();
            }
            else
            {
                ClickObjectDialogueText();
            }
            
            ClickBedRoomTable();
            ClickShelf02();
        }
    }


    void ClickBedRoomTable()
    {
        if(hit.collider.gameObject.name== "Table002")
        {
            
            hit.transform.SendMessage("ClickBedRoomTable", gameObject, SendMessageOptions.DontRequireReceiver);
        }
    }

    void ClickShelf02()
    {
        if (hit.collider.gameObject.name == "Shelf002")
        {
            hit.transform.SendMessage("ClickShelf", gameObject, SendMessageOptions.DontRequireReceiver);
            
        }
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

    void HearDogText()
    {

        if (RayScript.hit.collider.gameObject == DogListener[0]) //水龍頭
        {
            ObjTalk.text = "渴了我都自己打開喝，但忘記關的時候都被罵。";
        }
        if (RayScript.hit.collider.gameObject == DogListener[1]) //狗飼料
        {
            ObjTalk.text = "好香，聞到又餓了，好想吃呀~";
        }
        if (RayScript.hit.collider.gameObject == DogListener[2]) //蛋糕
        {
            ObjTalk.text = "最喜歡每年跟主人一起幫爺爺過生日了！";
        }

        if (RayScript.hit.collider.gameObject == DogListener[3]) //咖啡
        {
            ObjTalk.text = "爺爺平常很喜歡喝這個。";
        }

        if (RayScript.hit.collider.gameObject == DogListener[4]) //牛奶
        {
            ObjTalk.text = "主人最喜歡喝的！跟我喜歡喝的顏色一樣！";
        }
        if (RayScript.hit.collider.gameObject == DogListener[5]) //冰
        {
            ObjTalk.text = "雖然爺爺不常讓主人吃，但主人每次吃都很開心。";
        }

        if (RayScript.hit.collider.gameObject == DogListener[6]) //椅子
        {
            ObjTalk.text = "主人常坐的位置，偷偷跑上去總是被抱下來。";
        }

        if (RayScript.hit.collider.gameObject == DogListener[7]) //作業本
        {
            ObjTalk.text = "主人好像很不喜歡這些東西。";
        }
        if (RayScript.hit.collider.gameObject == DogListener[8]) //充電線
        {
            ObjTalk.text = "不懂為什麼主人都要插在牆上。";
        }
        if (RayScript.hit.collider.gameObject == DogListener[9]) //筆
        {
            ObjTalk.text = "主人常常拿著。";
        }
        if (RayScript.hit.collider.gameObject == DogListener[10]) //剪刀
        {
            ObjTalk.text = "看起來圓圓的，但主人總是不讓我碰。";
        }
        if (RayScript.hit.collider.gameObject == DogListener[11]) //書
        {
            ObjTalk.text = "主人平常會拿下來看。";
        }
        if (RayScript.hit.collider.gameObject == DogListener[12]) //手機
        {
            ObjTalk.text = "不太喜歡，主人有了之後看他都比看我多。";
        }

        if (RayScript.hit.collider.gameObject == DogListener[13]) //狗窩
        {
            ObjTalk.text = "很柔軟，喜歡待在上面等主人回家。";
        }
        if (RayScript.hit.collider.gameObject == DogListener[14]) //水碗
        {
            ObjTalk.text = "喝水的時候圖案會慢慢不見，很好玩。";
        }
        if (RayScript.hit.collider.gameObject == DogListener[15]) //飼料碗
        {
            ObjTalk.text = "好想要裡面一直裝滿滿的。";
        }
        if (RayScript.hit.collider.gameObject == DogListener[16]) //衣服
        {
            ObjTalk.text = "爺爺每天都會穿不一樣的。";
        }
        if (RayScript.hit.collider.gameObject == DogListener[17]) //床
        {
            ObjTalk.text = "喜歡趁爺爺不在偷偷跑上去睡，好溫暖！";
        }

    
    }

    public void ButtonClick()
    {
        isTalking = false;
        DialogueBG.SetActive(false);
    }




}
