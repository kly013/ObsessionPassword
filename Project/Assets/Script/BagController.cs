using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BagController : MonoBehaviour
{
    enum Tools
    {
        AluminumCan001,
        AluminumCan002,
        AluminumCan003,
        AluminumCan004,
        Book001,
        Book002,
        Book003,
        Book004,
        Book005,
        Book006,
        Book007,
        Book008,
        Book010,
        Book011,
        Book012,
        Book014,
        Book015,
        Book016,
        Charger,
        ContactBook,
        Diary,
        DogBowl001,
        DogBowl002,
        DogCollar,
        Flour001,
        Flour002,
        Flour003,
        Flower,
        IceCreamBox001,
        IceCreamBox002,
        IceCreamBox003,
        Magnifier,
        Milk001,
        Milk002,
        Paste,
        Pen001,
        Pen002,
        Pen003,
        Pen004,
        Pen005,
        Pen006,
        Pen007,
        Photo2020,
        PhotoDog,
        PhotoFrame,
        PopsicleBox001,
        PopsicleBox002,
        PopsicleBox003,
        PopsicleBox004,
        Scissors,
        Seasoning001,
        Seasoning002,
        Seasoning003,
        Seasoning004,
        Seasoning005,
        Watermelon001,
        Watermelon002,
        Wine001,
        Wine002,
        Wine003
    }

    public Sprite[] toolsImg;
    public GameObject[] imgPos;
    int toolsNum = 0;
    public static int posNum = 0;

    public void addTools(GameObject obj)
    {
        string name = obj.name.Substring(0, obj.name.Length - 7);
        try
        {
            //print(name);
            Tools result = (Tools)Enum.Parse(typeof(Tools), name);
            toolsNum = (int)result;
            imgPos[posNum].SetActive(true);
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
