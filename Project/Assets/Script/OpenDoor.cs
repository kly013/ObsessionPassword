using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class OpenDoor : MonoBehaviour
{
    Animator OpenDoorAnim;
    bool isOpen;
    bool[] isthisOpen = Enumerable.Repeat(false, 15).ToArray();

    public void HitByRaycast() //被射線打到時會進入此方法
    {
        //print("EEEEEE");

        OpenDoorAnim = RayScript.hit.collider.GetComponent<Animator>();
        string name = RayScript.hit.collider.name;
        int thisNum = -1;

        switch (name)
        {
            case "Refrigerator002":
                thisNum = 0;
                break;
            case "Refrigerator003":
                thisNum = 1;
                break;
            case "CabinetDoor001":
                thisNum = 2;
                break;
            case "CabinetDoor002":
                thisNum = 3;
                break;
            case "Drawer001":
                thisNum = 4;
                break;
            case "Drawer002":
                thisNum = 5;
                break;
            case "Drawer003":
                thisNum = 6;
                break;
            case "Drawer004":
                thisNum = 7;
                break;
            case "Drawer005":
                thisNum = 8;
                break;
            case "WardrobeDoor001":
                thisNum = 9;
                break;
            case "WardrobeDoor002":
                thisNum = 10;
                break;
            case "SlidingDoor003":
                thisNum = 11;
                break;
            case "SlidingDoor004":
                thisNum = 12;
                break;
        }

        //print("ThisNum = " + thisNum);

        if (thisNum >= 0)
        {
            if (isthisOpen[thisNum])
            {
                isOpen = false;
            }
            else
            {
                isOpen = true;
            }

            isthisOpen[thisNum] = isOpen;
            print("isOpen = " + isOpen);

            switch (name)
            {
                case "Refrigerator002":
                case "Refrigerator003":
                case "CabinetDoor001":
                case "CabinetDoor002":
                case "Drawer001":
                case "Drawer002":
                case "Drawer003":
                case "Drawer004":
                case "Drawer005":
                case "WardrobeDoor001":
                case "WardrobeDoor002":
                case "SlidingDoor003":
                case "SlidingDoor004":
                    OpenDoorAnim.SetBool("isOpen", isOpen);
                    break;
            }
        }
    }
}
