using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSpace : MonoBehaviour
{
    public GameObject objectCanvas;

    public void onClick()
    {
        print("點到空白處");
        objectCanvas.SetActive(false);
    }
}
