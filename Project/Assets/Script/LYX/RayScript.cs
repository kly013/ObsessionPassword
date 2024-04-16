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

    // 判斷是否有打到東西
    public static bool isHit = false;

    // 打到東西對應顯示的文字
    public LevelText01 levelText01;
    // 點電腦後的行為
    public ClickComputer clickComputer;
    // 點門後的開關動畫
    public OpenDoor openDoor;
    // 點擊可以拿起的物品後的動作
    public TakeLook takeLook;
    public Logic logic;

    public GameObject contactBook;
    public GameObject diary;
    public GameObject crossHair;
    public GameObject camera;

    static public Vector3 startPos;
    static public Vector3 startRotation;

    private AudioSource audioSource;
    public AudioClip touch;
    public AudioClip SlidingDoor;
    public AudioClip DogBowl;
    public AudioClip Drawer;
    public AudioClip DogFoods;
    public AudioClip Refrigerator;
    public AudioClip CabinetDoor;
    public AudioClip Clock;
    public AudioClip Door;

    void Start()
    {
        // 開始關掉提示和對話框
        //PressE.SetActive(false);
        //DialogueBG.SetActive(false);

        audioSource = GetComponent<AudioSource>();

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
            //// 鼠標出現
            //Cursor.visible = true;
            //Cursor.lockState = CursorLockMode.None;
            LevelText01.isTalking = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            LevelText01.isTalking = false;
        }

        if (LevelText01.isTalking)
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

        //if (Physics.Raycast(ray, out hit, raylength) && !EventSystem.current.IsPointerOverGameObject())

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

                // 根據被點擊的物件播放不同音效
                PlayClickSound(hit.collider.name);

                // 點場景內 tag 設定成 key 的物件，切換 CanHear
                if (hit.collider.gameObject.tag == "key")
                {
                    CanHear = !CanHear;
                }

                // 點擊需要開門的物件的開門
                openDoor.HitByRaycast(hit.collider.name);

                // 暫放
                //print("s = " + LevelController.selectName + " , c = " + LevelController.clickName);

                logic.GameLogic(hit.collider.name);

                if (!LevelController.isTask)
                {
                    if (!LevelText01.isTalking)
                    {
                        if (CanHear)
                        {
                            // canHear 的文字內容
                            levelText01.canHearText(hit.collider.name);
                        }
                        else
                        {
                            // notHear 的文字內容
                            levelText01.notHearText(hit.collider.name);
                        }


                        //cameraControl.CameraChange(hit.collider.name);
                        takeLook.onClickCanTakeLook(hit.collider.gameObject);
                    }

                    if (hit.collider.name == "Computer")
                    {
                        clickComputer.OnClick();
                        LevelText01.isTalking = true;
                    }

                    if (hit.collider.name == "ContactBook")
                    {
                        startPos = gameObject.transform.position;
                        startRotation = gameObject.transform.rotation.eulerAngles;
                        LevelText01.isTalking = true;
                        contactBook.SetActive(true);
                        //Debug.Log(gameObject.transform.position);
                        //Debug.Log(gameObject.transform.rotation.eulerAngles);
                    }

                    if (hit.collider.name == "Diary")
                    {
                        startPos = gameObject.transform.position;
                        startRotation = gameObject.transform.rotation.eulerAngles;
                        LevelText01.isTalking = true;
                        diary.SetActive(true);
                        crossHair.SetActive(false);
                    }
                }
            }

            if (Input.GetMouseButtonUp(0))
            {

                if (hit.collider.name == "ContactBook")
                {
                    LevelText01.isTalking = true;
                    contactBook.SetActive(true);
                    gameObject.transform.position = new Vector3(1.398f, 5.729f, 20.329f);
                    gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                    camera.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                    crossHair.SetActive(false);
                }
                if (hit.collider.name == "Diary")
                {
                    LevelText01.isTalking = true;
                    diary.SetActive(true);
                    gameObject.transform.position = new Vector3(5.9f, 5.85f, 19.64f);
                    gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                    camera.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                    crossHair.SetActive(false);
                }

            }
        }
        else
        {
            isHit = false;
        }

        if (BooksSpaceBack.goBack == true)
        {
            crossHair.SetActive(true);
            gameObject.transform.position = startPos;
            gameObject.transform.rotation = Quaternion.Euler(new Vector3(startRotation.x, startRotation.y, startRotation.z));
            LevelText01.isTalking = false;
            BooksSpaceBack.goBack = false;
        }
    }

    void PlayClickSound(string objectName)
    {
        // 根據被點擊的物件名稱選擇要播放的音效
        switch (objectName)
        {
            case "SlidingDoor001":
            case "SlidingDoor002":
            case "SlidingDoor003":
            case "SlidingDoor004":
                audioSource.clip = SlidingDoor;
                break;
            case "DogBowl001":
                audioSource.clip = DogBowl;
                break;
            case "Drawer001":
            case "Drawer002":
            case "Drawer003":
            case "Drawer004":
            case "Drawer005":
                audioSource.clip = Drawer;
                break;
            case "DogFoods":
                audioSource.clip = DogFoods;
                break;
            case "Refrigerator002":
            case "Refrigerator003":
                audioSource.clip = Refrigerator;
                break;
            case "CabinetDoor001":
            case "CabinetDoor002":
            case "WardrobeDoor001":
            case "WardrobeDoor002":
                audioSource.clip = CabinetDoor;
                break;
            case "Clock":
                audioSource.clip = Clock;
                break;
            case "Door001":
                audioSource.clip = Door;
                break;
            default:
                // 默認的音效
                audioSource.clip = touch;
                break;
        }

        // 播放音效
        if (audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
}
