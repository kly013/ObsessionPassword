using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayOutline : MonoBehaviour
{
    void OnMouseEnter()
    {
        if(RayScript.isHit)
        {
            if (RayScript.hit.collider != null)
            {
                if (RayScript.hit.collider.name == this.gameObject.name)
                {
                    Outline outline = GetComponent<Outline>();
                    if (outline != null)
                    {
                        outline.enabled = true;
                    }
                }
            }
        }
    }

    void OnMouseExit()
    {
        Outline outline = GetComponent<Outline>();
        if (outline != null)
        {
            outline.enabled = false;
        }
    }
}
