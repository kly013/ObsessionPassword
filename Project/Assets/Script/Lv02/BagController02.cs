using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BagController02 : MonoBehaviour
{
    enum Tools
    {
        BanyanTree_Branches,
        BanyanTree_Leaf,
        Battery,
        CamphorTree_Branches,
        CamphorTree_Leaf,
        Clothes,
        FlashLight,
        Lighter,
        Match,
        Pistacia_Braches,
        Pistacia_Leaf,
        RoundStone,
        SharpStone,
        SmoothStone,
        WaxTree_Braches,
        WaxTree_Leaf
    }

    public Sprite[] toolsImg;
    public GameObject[] imgPos;
    int toolsNum = 0;
    public static int posNum = 0;

    public GameObject toolImage;
    public GameObject clickSpace;
    public GameObject choseText;
    GameObject toolObj;

    public void changeToolsImg(GameObject obj)
    {
        toolObj = obj;
        string name = obj.tag;
        Tools result = (Tools)Enum.Parse(typeof(Tools), name);
        toolsNum = (int)result;
        Image image = toolImage.GetComponent<Image>();
        image.sprite = toolsImg[toolsNum];
        clickSpace.SetActive(false);
        choseText.SetActive(true);
        toolImage.SetActive(true);
    }

    public void addTools()
    {
        //print("aaa");
        try
        {
            toolObj.SetActive(false);
            imgPos[posNum].SetActive(true);
            LevelController02.toolsList.Add(toolObj);
            Image img = imgPos[posNum].GetComponent<Image>();
            img.sprite = toolsImg[toolsNum];
            posNum++;
        }
        catch
        {
            //print("not found");
        }
    }

    public void onChangePos(string name)
    {
        Image img1;
        Image img2;
        Image img3;

        if (name == "Tool01")
        {
            img1 = imgPos[0].GetComponent<Image>();
            img2 = imgPos[1].GetComponent<Image>();

            if (imgPos[1].activeSelf)
            {
                img1.sprite = img2.sprite;
                imgPos[1].SetActive(false);
                posNum = 1;
            }
            else
            {
                imgPos[0].SetActive(false);
                posNum = 0;
            }

            img3 = imgPos[2].GetComponent<Image>();
            if (imgPos[2].activeSelf)
            {
                img2.sprite = img3.sprite;
                imgPos[1].SetActive(true);
                imgPos[2].SetActive(false);
                posNum = 2;
            }

        }

        if (name == "Tool02")
        {
            img2 = imgPos[1].GetComponent<Image>();
            img3 = imgPos[2].GetComponent<Image>();
            if (imgPos[2].activeSelf)
            {
                img2.sprite = img3.sprite;
                imgPos[1].SetActive(true);
                imgPos[2].SetActive(false);
                posNum = 2;
            }
            else
            {
                imgPos[1].SetActive(false);
                posNum = 1;
            }
        }

        if (name == "Tool03")
        {
            imgPos[2].SetActive(false);
            posNum = 2;
        }
    }
}
