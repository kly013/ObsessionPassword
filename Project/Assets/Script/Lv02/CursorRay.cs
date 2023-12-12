using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CursorRay : MonoBehaviour
{
    // 射線
    Ray ray;
    // 射線長度
    float raylength = 10f;
    // 打到的東西
    public static RaycastHit hit;
    // 判斷是不是聽得懂動物語
    bool CanHear = false;

    // 判斷是否有打到東西
    public static bool isHit = false;

    // 打到東西對應顯示的文字
    public LevelText02 levelText02;

    public BagController02 bagController02;

    void Start()
    {
        // 鼠標設定視窗中
        Cursor.lockState = CursorLockMode.Locked;
        // 隱藏鼠標
        Cursor.visible = false;
    }

    void Update()
    {
        // 按alt或對話時
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            LevelText02.isTalking = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            LevelText02.isTalking = false;
        }
        
        if (LevelText02.isTalking)
        {
            // 解鎖控制鼠標在視窗內
            Cursor.lockState = CursorLockMode.None;
            // 鼠標出現
            Cursor.visible = true;
        }
        else
        {
            // 控制鼠標在視窗內
            Cursor.lockState = CursorLockMode.Locked;
            // 鼠標隱藏
            Cursor.visible = false;
        }

        // 攝影機射到畫面正中央的射線
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        // （射線, out 被射線打到的物件, 射線長度），out hit 意思是：把"被射線打到的物件"帶給hit
        if (Physics.Raycast(ray, out hit, raylength))
        {
            // 打到物體（用來給其他script判斷，避免 hit == null 情形）
            isHit = true;

            //當射線打到物件時會在Scene視窗畫出黃線，方便查閱
            Debug.DrawLine(ray.origin, hit.point, Color.yellow);

            // 按下滑鼠右鍵
            if (Input.GetMouseButtonDown(0))
            {
                LevelController.clickName = hit.collider.name;

                print(hit.collider.name);

                // 點場景內 tag 設定成 key 的物件，切換 CanHear
                if (hit.collider.gameObject.tag == "key")
                {
                    CanHear = !CanHear;
                }

                
                if (!LevelText02.isTalking)
                {
                    print("aaaa");
                    if (CanHear)
                    {
                        // canHear 的文字內容
                        levelText02.canHearText(hit.collider.name);
                    }
                    else
                    {
                        // notHear 的文字內容
                        levelText02.notHearText(hit.collider.name);
                    }
                }

                if (hit.collider.tag != "Untagged" && hit.collider.tag != "key")
                {
                    print("bbbbb");
                    bagController02.changeToolsImg(hit.collider.tag);
                }
            }
        }
        else
        {
            isHit = false;
        }
    }
}
