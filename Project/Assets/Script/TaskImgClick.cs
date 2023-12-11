using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskImgClick : MonoBehaviour
{
    public Sprite[] toolsImg;
    public GameObject tool;
    public GameObject photodog;
    int taskNum = 0;

    public void onClick()
    {
        print("change");
        Image img = tool.GetComponent<Image>();
        img.sprite = toolsImg[taskNum];
        LevelText01.isTalking = false;
        photodog.SetActive(false);
        this.gameObject.SetActive(false);
        taskNum++;
    }
}
