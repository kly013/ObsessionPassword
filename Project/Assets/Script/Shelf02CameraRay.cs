using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shelf02CameraRay : MonoBehaviour
{
    static public Ray Camera02Ray;
    static public float raylength = 1.5f;
    static public RaycastHit Camera02hit;

    public string[] DoorName;

    public GameObject[] ShelfCameraMove;
    public GameObject[] ShelfObjTalk;
    public GameObject ShelfCamera;
    public GameObject BackButton;
    public GameObject DialogueBG;
    public Text ObjTalk;
    public GameObject PressE;

    public GameObject CameraMain;
    public GameObject CursorPNG;

    bool isStart = false;


    // Start is called before the first frame update
    void Start()
    {
        BackButton.SetActive(false);
        DialogueBG.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Camera02Ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(Camera02Ray, out Camera02hit, raylength) && !EventSystem.current.IsPointerOverGameObject())
        {

            Debug.DrawLine(Camera02Ray.origin, Camera02hit.point, Color.blue);
            PressEControl();

        }

        if (CameraControl.CursorControl == true)
        {
            CursorVisible();
        }


        if (Input.GetMouseButtonUp(0))
        {
            isStart = true;
        }

        if (isStart)
        {
            if (Input.GetMouseButton(0))
            {

                ClickObjectCameraMove();

                if (RayScript.CanHearDog == true)
                {
                    ClickObjectTalkHearDog();
                }
                else
                {
                    ClickObjectTalk();
                }
            }

            if (Input.GetMouseButton(0) && Camera02hit.collider.gameObject.name == "Drawer004")
            {
                Camera02hit.transform.SendMessage("DrawerOpen04", gameObject, SendMessageOptions.DontRequireReceiver);
            }
            if (Input.GetMouseButton(0) && Camera02hit.collider.gameObject.name == "Drawer005")
            {
                Camera02hit.transform.SendMessage("DrawerOpen05", gameObject, SendMessageOptions.DontRequireReceiver);
            }


        }
       
        if(ShelfCamera.transform.position==new Vector3(0.146f, -0.894f, 1.581f)|| ShelfCamera.transform.position == new Vector3(0.146f, -0.518f, 1.808f))
        {
            Camera02hit.transform.SendMessage("ShelfDoorsControl", gameObject, SendMessageOptions.DontRequireReceiver);
        }

  


        if (Input.GetKeyDown(KeyCode.Space))
        {
            CursorPNG.SetActive(true);
            CameraMain.SetActive(true);
            ShelfCamera.SetActive(false);
            ShelfCamera.transform.position = new Vector3(0.01f, -0.72f, 0.9f);
            ShelfCamera.transform.eulerAngles = new Vector3(0, 0, 0);
            GameObject.Find("Player").GetComponent<RayScript>().enabled = true;
            BackButton.SetActive(false);
            isStart = false;
        }


        if(Input.GetKeyDown(KeyCode.Space) &&ShelfOpenDoors.Drawer04Control==true)
        {
            GameObject.Find("Drawer004").SendMessage("DrawerClose04", gameObject, SendMessageOptions.DontRequireReceiver);
            
        }
        if (Input.GetKeyDown(KeyCode.Space) && ShelfOpenDoors.Drawer05Control==true)
        {
            GameObject.Find("Drawer005").SendMessage("DrawerClose05", gameObject, SendMessageOptions.DontRequireReceiver);

        }


        if (Input.GetKeyDown(KeyCode.Space) && ShelfOpenDoors.Sliding01Control == true)
        {
            GameObject.Find("SlidingDoor001").SendMessage("Sliding01Close", gameObject, SendMessageOptions.DontRequireReceiver);

            ShelfOpenDoors.Opened = false;

        }
        if (Input.GetKeyDown(KeyCode.Space) && ShelfOpenDoors.Sliding02Control == true)
        {
            GameObject.Find("SlidingDoor002").SendMessage("Sliding02Close", gameObject, SendMessageOptions.DontRequireReceiver);
            ShelfOpenDoors.Opened = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && ShelfOpenDoors.Sliding03Control == true)
        {
            GameObject.Find("SlidingDoor003").SendMessage("Sliding03Close", gameObject, SendMessageOptions.DontRequireReceiver);
            ShelfOpenDoors.Opened = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && ShelfOpenDoors.Sliding04Control == true)
        {
            GameObject.Find("SlidingDoor004").SendMessage("Sliding04Close", gameObject, SendMessageOptions.DontRequireReceiver);
            ShelfOpenDoors.Opened = false;
        }
        // Debug.Log(ShelfCamera.transform.position);
    }



    void PressEControl()
    {
        if (ShelfCamera.transform.position == new Vector3(0.146f, -0.894f, 1.581f) || ShelfCamera.transform.position == new Vector3(0.146f, -0.518f, 1.808f))
        {
            foreach (string name in DoorName)
            {
                if (string.Equals(name, Camera02hit.transform.name))
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


    }

    void CursorVisible()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void ClickObjectCameraMove()
    {
        
        if (Camera02hit.collider.gameObject == ShelfCameraMove[0])
        {
            ShelfCamera.transform.position = new Vector3(-0.298f, -0.521f, 1.806f);
            BackButton.SetActive(true);
        }
        if (Camera02hit.collider.gameObject == ShelfCameraMove[1])
        {
            ShelfCamera.transform.position = new Vector3(-0.298f, -0.521f, 1.806f);
            BackButton.SetActive(true);
        }
        if (Camera02hit.collider.gameObject == ShelfCameraMove[2])
        {
            ShelfCamera.transform.position = new Vector3(-0.298f, -0.521f, 1.806f);
            BackButton.SetActive(true);
        }
        if (Camera02hit.collider.gameObject == ShelfCameraMove[3])
        {
            ShelfCamera.transform.position = new Vector3(-0.298f, -0.521f, 1.806f);
            BackButton.SetActive(true);
        }
        if (Camera02hit.collider.gameObject == ShelfCameraMove[4])
        {
            ShelfCamera.transform.position = new Vector3(-0.298f, -0.521f, 1.806f);
            BackButton.SetActive(true);
        }



        if (Camera02hit.collider.gameObject.name == ShelfCameraMove[5].name)
        {
            ShelfCamera.transform.position = new Vector3(0.146f, -0.894f, 1.581f);
            BackButton.SetActive(true);
            //print("e = " + Camera02hit.collider.gameObject.name);
            //print("f = " + ShelfCameraMove[5].name);
        }
        if (Camera02hit.collider.gameObject.name == ShelfCameraMove[6].name)
        {
            ShelfCamera.transform.position = new Vector3(0.146f, -0.894f, 1.581f);
            BackButton.SetActive(true);
            //print("g = " + Camera02hit.collider.gameObject.name);
            //print("h = " + ShelfCameraMove[6].name);
        }


        if (Camera02hit.collider.gameObject.name == ShelfCameraMove[7].name)
        {
            ShelfCamera.transform.position = new Vector3(0.146f, -0.518f, 1.808f);
            BackButton.SetActive(true);
            //print("a = " + Camera02hit.collider.gameObject.name);
            //print("b = " + ShelfCameraMove[7].name);
        }
        if (Camera02hit.collider.gameObject.name == ShelfCameraMove[8].name)
        {
            ShelfCamera.transform.position = new Vector3(0.146f, -0.518f, 1.808f);
            BackButton.SetActive(true);
            //print("c = " + Camera02hit.collider.gameObject.name);
            //print("d = " + ShelfCameraMove[8].name);
        }




        if (Camera02hit.collider.gameObject.name == ShelfCameraMove[9].name)
        {
            ShelfCamera.transform.position = new Vector3(-0.304f, 0.275f, 2.023f);
            ShelfCamera.transform.eulerAngles = new Vector3(90, 0, 0);
            BackButton.SetActive(true);
            
        }
        if (Camera02hit.collider.gameObject.name == ShelfCameraMove[10].name)
        {
            ShelfCamera.transform.position = new Vector3(-0.304f, 0.111f, 2.023f);
            ShelfCamera.transform.eulerAngles = new Vector3(90, 0, 0);
            BackButton.SetActive(true);
        }

    }

    void ClickObjectTalk()
    {
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[0].name)//調料瓶
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "放著各式調味料的瓶子。";
            
        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[1].name)//調料瓶
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "放著各式調味料的瓶子。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[2].name)//調料瓶
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "放著各式調味料的瓶子。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[3].name)//調料瓶
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "放著各式調味料的瓶子。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[4].name)//調料瓶
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "放著各式調味料的瓶子。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[5].name)//餐具
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "吃飯時的餐具。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[6].name)//餐具
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "吃飯時的餐具。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[7].name)//杯子
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "玻璃製的杯子。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[8].name)//杯子
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "玻璃製的杯子。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[9].name)//杯子
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "玻璃製的杯子。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[10].name)//杯子
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "玻璃製的杯子。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[11].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "許多陶瓷碗盤。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[12].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "許多陶瓷碗盤。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[13].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "許多陶瓷碗盤。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[14].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "許多陶瓷碗盤。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[15].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "許多陶瓷碗盤。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[16].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "許多陶瓷碗盤。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[17].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "許多陶瓷碗盤。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[18].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "許多陶瓷碗盤。";

        }
    }

    void ClickObjectTalkHearDog()
    {
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[0].name)//調料瓶
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "爺爺煮菜都會加 我也想加看看，但爺爺總是說不行。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[1].name)//調料瓶
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "爺爺煮菜都會加 我也想加看看，但爺爺總是說不行。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[2].name)//調料瓶
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "爺爺煮菜都會加 我也想加看看，但爺爺總是說不行。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[3].name)//調料瓶
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "爺爺煮菜都會加 我也想加看看，但爺爺總是說不行。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[4].name)//調料瓶
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "爺爺煮菜都會加 我也想加看看，但爺爺總是說不行。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[5].name)//餐具
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "看爺爺跟主人吃飯都會用，為什麼不能直接用嘴吃呢?";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[6].name)//餐具
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "看爺爺跟主人吃飯都會用，為什麼不能直接用嘴吃呢?";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[7].name)//杯子
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "爺爺和主人的杯子跟我的碗一樣！ 裝喝的都會變色，好好玩！";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[8].name)//杯子
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "爺爺和主人的杯子跟我的碗一樣！ 裝喝的都會變色，好好玩！";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[9].name)//杯子
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "爺爺和主人的杯子跟我的碗一樣！ 裝喝的都會變色，好好玩！";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[10].name)//杯子
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "爺爺和主人的杯子跟我的碗一樣！ 裝喝的都會變色，好好玩！";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[11].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "裡面感覺裝了好多好吃的食物。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[12].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "裡面感覺裝了好多好吃的食物。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[13].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "裡面感覺裝了好多好吃的食物。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[14].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "裡面感覺裝了好多好吃的食物。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[15].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "裡面感覺裝了好多好吃的食物。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[16].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "裡面感覺裝了好多好吃的食物。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[17].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "裡面感覺裝了好多好吃的食物。";

        }
        if (Camera02hit.collider.gameObject.name == ShelfObjTalk[18].name)//碗盤
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "裡面感覺裝了好多好吃的食物。";

        }
    }

    public void BackButtonClick()
    {
        ShelfCamera.transform.position = new Vector3(0.01f, - 0.72f, 0.9f);
        ShelfCamera.transform.eulerAngles = new Vector3(0, 0, 0);
        BackButton.SetActive(false);
        DialogueBG.SetActive(false);

        if (ShelfOpenDoors.Sliding01Control == true)
        {
            GameObject.Find("SlidingDoor001").SendMessage("Sliding01Close", gameObject, SendMessageOptions.DontRequireReceiver);
            ShelfOpenDoors.Opened = false;
        }
        if ( ShelfOpenDoors.Sliding02Control == true)
        {
            GameObject.Find("SlidingDoor002").SendMessage("Sliding02Close", gameObject, SendMessageOptions.DontRequireReceiver);
            ShelfOpenDoors.Opened = false;
        }
        if (ShelfOpenDoors.Sliding03Control == true)
        {
            GameObject.Find("SlidingDoor003").SendMessage("Sliding03Close", gameObject, SendMessageOptions.DontRequireReceiver);
            ShelfOpenDoors.Opened = false;
        }
        if (ShelfOpenDoors.Sliding04Control == true)
        {
            GameObject.Find("SlidingDoor004").SendMessage("Sliding04Close", gameObject, SendMessageOptions.DontRequireReceiver);
            ShelfOpenDoors.Opened = false;
        }
    }


}

