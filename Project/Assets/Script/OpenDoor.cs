using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator OpenDoorAnim;
    bool Opened;
    
    void Start()
    {
        OpenDoorAnim = GetComponent<Animator>();
    }

    void HitByRaycast() //被射線打到時會進入此方法
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //print("EEEEEE");
            Opened = !Opened;

            if (RayScript.hit.collider.name == "Refrigerator")
            {
                if (Opened)
                {
                    OpenDoorAnim.SetTrigger("RefrigeratorOpen");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("RefrigeratorClose");
                }
            }


            if (RayScript.hit.collider.name == "Cabinet01")
            {
                if (Opened)
                {
                    OpenDoorAnim.SetTrigger("CabinetOpen001");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("CabinetClose001");
                }
            }

            if (RayScript.hit.collider.name == "Cabinet02")
            {
                if (Opened)
                {
                    OpenDoorAnim.SetTrigger("CabinetOpen002");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("CabinetClose002");
                }
            }


            if (RayScript.hit.collider.name == "Drawer001")
            {
                if (Opened)
                {
                    OpenDoorAnim.SetTrigger("DrawerOpen001");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("DrawerClose001");
                }
            }

            if (RayScript.hit.collider.name == "Drawer002")
            {
                if (Opened)
                {
                    OpenDoorAnim.SetTrigger("DrawerOpen002");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("DrawerClose002");
                }
            }

            if (RayScript.hit.collider.name == "Drawer003")
            {
                if (Opened)
                {
                    OpenDoorAnim.SetTrigger("DrawerOpen003");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("DrawerClose003");
                }
            }


            if (RayScript.hit.collider.name == "WardrobeDoor01")
            {
                if (Opened)
                {
                    OpenDoorAnim.SetTrigger("WardrobeOpen001");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("WardrobeClose001");
                }
            }

            if (RayScript.hit.collider.name == "WardrobeDoor02")
            {
                if (Opened)
                {
                    OpenDoorAnim.SetTrigger("WardrobeOpen002");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("WardrobeClose002");
                }
            }
        }
    }
}
