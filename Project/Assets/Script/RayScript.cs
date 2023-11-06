using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RayScript : MonoBehaviour
{
    // 射線
    Ray ray;
    // 射線長度
    float raylength = 1.5f;
    // 打到的東西
    static public RaycastHit hit;

    // 按 E 出現的字
    public GameObject PressE;

    public LevelText01 levelText01;

    //public string[] Tags;


    ////public GameObject[] ClickObjTalk;
    ////public GameObject[] DogListener;

    // 對話框
    public GameObject DialogueBG;
    // 按空白處
    public GameObject clickSpace;
    ////對話框文字
    //public Text ObjTalk;

    // 判斷是不是聽得懂動物語
    bool CanHear = false;

    public ClickComputer clickComputer;

    //public GameObject CameraShelf;

    void Start()
    {
        // 開始關掉提示和對話框
        PressE.SetActive(false);
        //DialogueBG.SetActive(false);

        // 鼠標設定視窗中
        Cursor.lockState = CursorLockMode.Locked;
        // 隱藏鼠標
        Cursor.visible = false;
    }

    void Update()
    {
        // 對話時
        if (LevelText01.isTalking)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        // 攝影機射到畫面正中央的射線
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        // (射線,out 被射線打到的物件,射線長度)，out hit 意思是：把"被射線打到的物件"帶給hit
        if (Physics.Raycast(ray, out hit, raylength) && !EventSystem.current.IsPointerOverGameObject())
        {
            // 向被射線打到的物件呼叫名為"HitByRaycast"的方法
            hit.transform.SendMessage("HitByRaycast", gameObject, SendMessageOptions.DontRequireReceiver);

            if (string.Equals(hit.collider.tag, "pressE"))
            {
                PressE.SetActive(true);
            }
            else
            {
                PressE.SetActive(false);
            }

            //當射線打到物件時會在Scene視窗畫出黃線，方便查閱
            Debug.DrawLine(ray.origin, hit.point, Color.yellow);

            //在Console視窗印出被射線打到的物件名稱，方便查閱
            //print("這個在射線名字是" + hit.transform.name);
        }

        if (Input.GetMouseButton(0))
        {
            if (hit.collider != null && hit.collider.gameObject != null)
            {
                if (hit.collider.gameObject.tag == "key")
                {
                    print(hit.collider.name);
                    CanHear = true;
                }

                if (CanHear)
                {
                    //HearDogText();
                    levelText01.canHearText(hit.collider.name);
                }
                else
                {
                    //ClickObjectDialogueText();
                    levelText01.notHearText(hit.collider.name);
                }

                if(hit.collider.name == "Computer")
                {
                    clickComputer.OnClick();
                    LevelText01.isTalking = true;
                }

                ClickBedRoomTable();
                ClickShelf02();
            }
        }
    }

    void ClickBedRoomTable()
    {
        if(hit.collider.name== "Table002")
        {
            hit.transform.SendMessage("ClickBedRoomTable", gameObject, SendMessageOptions.DontRequireReceiver);
        }
    }

    void ClickShelf02()
    {
        if (hit.collider.name == "Shelf002")
        {
            hit.transform.SendMessage("ClickShelf", gameObject, SendMessageOptions.DontRequireReceiver);
        }
    }

    public void ButtonClick()
    {
        LevelText01.isTalking = false;
        DialogueBG.SetActive(false);
        clickSpace.SetActive(false);
    }
}
