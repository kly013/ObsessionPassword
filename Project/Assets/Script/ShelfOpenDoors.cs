using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShelfOpenDoors : MonoBehaviour
{
    public GameObject ShelfCamera;
    Animator OpenDoorAnim;
    static public bool Opened;
    static public bool Drawer04Control;
    static public bool Drawer05Control;

    static public bool Sliding01Control;
    static public bool Sliding02Control;
    static public bool Sliding03Control;
    static public bool Sliding04Control;
    public GameObject BackButton;
    // Start is called before the first frame update
    void Start()
    {
        OpenDoorAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ShelfDoorsControl()
    {
        if (Input.GetKeyDown(KeyCode.E) )
        {
            
            Opened = !Opened;

            if (Shelf02CameraRay.Camera02hit.transform.name == "SlidingDoor001")
            {

                if (Opened == true)
                {
                    Sliding01Control = true;
                    OpenDoorAnim.SetTrigger("LeftSlidingOpen01");
                }
                else
                {
                    Sliding01Control = false;
                    OpenDoorAnim.SetTrigger("LeftSlidingClose01");
                }
            }

            if (Shelf02CameraRay.Camera02hit.transform.name == "SlidingDoor002")
            {

                if (Opened == true)
                {
                    Sliding02Control = true;
                    OpenDoorAnim.SetTrigger("RightSlidingOpen02");
                }
                else
                {
                    Sliding02Control = false;
                    OpenDoorAnim.SetTrigger("RightSlidingClose02");
                }
            }

            if (Shelf02CameraRay.Camera02hit.transform.name == "SlidingDoor003")
            {

                if (Opened == true)
                {
                    Sliding03Control = true;
                    OpenDoorAnim.SetTrigger("LeftSlidingOpen03");
                }
                else
                {
                    Sliding03Control = false;
                    OpenDoorAnim.SetTrigger("LeftSlidingClose03");
                }
            }

            if (Shelf02CameraRay.Camera02hit.transform.name == "SlidingDoor004")
            {

                if (Opened == true)
                {
                    Sliding04Control = true;
                    OpenDoorAnim.SetTrigger("RightSlidingOpen04");
                }
                else
                {
                    Sliding04Control = false;
                    OpenDoorAnim.SetTrigger("RightSlidingClose04");
                }
            }



        }

    }
    void Sliding01Close()
    {
        Sliding01Control = false;
        OpenDoorAnim.SetTrigger("LeftSlidingClose01");
    }
    void Sliding02Close()
    {
        Sliding02Control = false;
        OpenDoorAnim.SetTrigger("RightSlidingClose02");
    }
    void Sliding03Close()
    {
        Sliding03Control = false;
        OpenDoorAnim.SetTrigger("LeftSlidingClose03");
    }
    void Sliding04Close()
    {
        Sliding04Control = false;
        OpenDoorAnim.SetTrigger("RightSlidingClose04");
    }



    void DrawerOpen04()
    {
        Drawer04Control = true;
        OpenDoorAnim.SetTrigger("DrawerOpen04");
    }
    void DrawerOpen05()
    {
        Drawer05Control = true;
        OpenDoorAnim.SetTrigger("DrawerOpen05");
    }


     void DrawerClose04()
    {
        Drawer04Control = false;
        OpenDoorAnim.SetTrigger("DrawerClose04");
    }
    void DrawerClose05()
    {
        Drawer05Control = false;
        OpenDoorAnim.SetTrigger("DrawerClose05");
    }




    public void OpenDoorBackButtonClick01()
    {
        ShelfCamera.transform.position = new Vector3(0.01f, -0.72f, 0.9f);
        ShelfCamera.transform.eulerAngles = new Vector3(0, 0, 0);
        BackButton.SetActive(false);

        if (Drawer04Control == true)
        {
            OpenDoorAnim.SetTrigger("DrawerClose04");
            Drawer04Control = false;
        }


    }

    public void OpenDoorBackButtonClick02()
    {
        ShelfCamera.transform.position = new Vector3(0.01f, -0.72f, 0.9f);
        ShelfCamera.transform.eulerAngles = new Vector3(0, 0, 0);
        BackButton.SetActive(false);

        if (Drawer05Control == true)
        {
            OpenDoorAnim.SetTrigger("DrawerClose05");
            Drawer05Control = false;
        }
    }

}
