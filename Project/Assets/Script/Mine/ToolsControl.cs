using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsControl : MonoBehaviour
{
    bool isOpen = true;
    public Animator animator;

    public void onClickArrow()
    {
        isOpen = !isOpen;
        print(isOpen);
        animator.SetBool("isOpen", isOpen);
    }
}
