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
    public static int toolsNum = 0;
    public static int posNum = 0;
    public Button[] button;

    Tools tools;

    public void addTools(string name)
    {
        name = name.Substring(0, name.Length - 7);
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
            print("not found");
        }
    }

    public void OnButtonClick()
    {
        print(gameObject.name);
        

        Image buttonImage = GetComponent<Image>();

        // 檢查是否成功獲取 Image
        if (buttonImage != null)
        {
            // 在這裡使用 buttonImage 進行其他操作
            Sprite sourceSprite = buttonImage.sprite;
            LevelController.selectName = sourceSprite.name;
            //button.interactable = false;
            Debug.Log("按鈕的 Source Image 是：" + sourceSprite.name);
        }
        else
        {
            Debug.LogWarning("未找到 Image 元件");
        }
    }
}
