using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator OpenDoorAnim;
    bool Opened;


    
    // Start is called before the first frame update
    void Start()
    {
        OpenDoorAnim = GetComponent<Animator>();
       

    }

    // Update is called once per frame
    void Update()
    {

       
    }

    void HitByRaycast() //被射線打到時會進入此方法
    {


        if (Input.GetKeyDown(KeyCode.E))
        {
            print("EEEEEE");
            Opened = !Opened;

            if (RayScript.hit.transform.tag == "Refrigerator")
            {
                
                if (Opened == true)
                {
                    OpenDoorAnim.SetTrigger("RefrigeratorOpen");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("RefrigeratorClose");
                }
            }

            if (RayScript.hit.transform.tag == "Cabinet")
            {
                
                if (Opened == true)
                {
                    OpenDoorAnim.SetTrigger("CabinetOpen");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("CabinetClose");
                }
            }



            if (RayScript.hit.transform.tag == "Drawer001")
            {
                
                if (Opened == true)
                {
                    OpenDoorAnim.SetTrigger("DrawerOpen");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("DrawerClose");
                }
            }
            if (RayScript.hit.transform.tag == "Drawer002")
            {
                
                if (Opened == true)
                {
                    OpenDoorAnim.SetTrigger("DrawerOpen002");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("DrawerClose002");
                }
            }
            if (RayScript.hit.transform.tag == "Drawer003")
            {
               
                if (Opened == true)
                {
                    OpenDoorAnim.SetTrigger("DrawerOpen003");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("DrawerClose003");
                }
            }



            if (RayScript.hit.transform.tag == "WardrobeDoor")
            {
                
                if (Opened == true)
                {
                    OpenDoorAnim.SetTrigger("WardrobeOpen");
                }
                else
                {
                    OpenDoorAnim.SetTrigger("WardrobeClose");
                }
            }
        }

    }








}
