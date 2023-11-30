using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayOutline : MonoBehaviour
{
    void OnMouseEnter()
    {
        if(RayScript.isHit)
        {
            print(RayScript.hit.collider.name);
            if (RayScript.hit.collider.name == this.gameObject.name)
            {
                GetComponent<Outline>().enabled = true;
            }
        }
    }

    void OnMouseExit()
    {
        GetComponent<Outline>().enabled = false;
    }
}
