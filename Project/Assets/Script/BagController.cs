using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagController : MonoBehaviour
{
    public Sprite[] toolsImg;
    public GameObject[] imgPos;
    public static int toolsNum = 0;

    public void addTools(string name)
    {
        imgPos[toolsNum].SetActive(true);
        toolsNum++;
    }
}
