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
    public static int toolsNum = 0;
    public static int posNum = 0;

    Tools tools;

    public void addTools(string name)
    {
        name = name.Substring(0, name.Length - 7);
        try
        {
            print("AAA");
            print(name);
            Tools result = (Tools)Enum.Parse(typeof(Tools), name);
            print("BBB");
            toolsNum = (int)result;
            print("CCC");
            imgPos[posNum].SetActive(true);
            print("DDD");
            Image img = imgPos[posNum].GetComponent<Image>();
            print("EEE");
            img.sprite = toolsImg[toolsNum];
            print("FFF");
            posNum++;
            print("GGG");
        }
        catch
        {
            print("not found");
        }
    }

    public void onClick()
    {

    }
}
