using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskImgClick : MonoBehaviour
{
    public Sprite[] toolsImg;
    public GameObject[] imgPos;

    public void onClick()
    {
        this.gameObject.SetActive(false);
    }
}
