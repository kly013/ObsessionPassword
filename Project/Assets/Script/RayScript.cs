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
    float raylength = 2f;
    // 打到的東西
    public static RaycastHit hit;
    // 判斷是不是聽得懂動物語
    bool CanHear = false;

    public static bool isHit = false;

    public LevelText01 levelText01;
    public ClickComputer clickComputer;
    public OpenDoor openDoor;
    public CameraControl cameraControl;

    void Start()
    {
        // 開始關掉提示和對話框
        //PressE.SetActive(false);
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
            // 鼠標出現
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
            isHit = true;

            //當射線打到物件時會在Scene視窗畫出黃線，方便查閱
            Debug.DrawLine(ray.origin, hit.point, Color.yellow);

            if (Input.GetMouseButtonDown(0))
            {
                print(hit.transform.name);

                if (hit.collider.gameObject.tag == "key")
                {
                    //print(hit.collider.name);
                    CanHear = !CanHear;
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

                openDoor.HitByRaycast(hit.collider.name);
                //cameraControl.CameraChange(hit.collider.name);

                if (hit.collider.name == "Computer")
                {
                    clickComputer.OnClick();
                    LevelText01.isTalking = true;
                }
            }
        }
        else
        {
            isHit = false;
        }
    }
}
