using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskImgClick : MonoBehaviour
{
    public Sprite[] toolsImg;
    public GameObject tool;
    int taskNum = 0;

    public void onClick()
    {
        print("change");
        Sprite sp = tool.GetComponent<Sprite>();
        sp = toolsImg[taskNum];
        LevelText01.isTalking = false;
        this.gameObject.SetActive(false);
    }
}
