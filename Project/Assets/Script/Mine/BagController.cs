using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BagController : MonoBehaviour
{
    // 所有可以拿取的物品
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

    // 替換圖片
    public Sprite[] toolsImg;
    // 圖片顯示位置
    public GameObject[] imgPos;
    // 道具編號
    int toolsNum = 0;
    // 指向道具欄位編號，表下一道具該放哪
    public static int posNum = 0;

    // 取得物品新增至道具欄
    public void addTools(GameObject obj)
    {
        // 去掉(clone)文字
        string name = obj.name.Substring(0, obj.name.Length - 7);

        // 如果為Tools中所列道具，則出現相對應圖片
        try
        {
            // 暫放
            //print(name);

            // 測試是否為Tools所列道具
            Tools result = (Tools)Enum.Parse(typeof(Tools), name);
            // 有則取得道具編號
            toolsNum = (int)result;
            // 將目前所指向道具欄位圖片顯示
            imgPos[posNum].SetActive(true);
            // 取得該欄位Image
            Image img = imgPos[posNum].GetComponent<Image>();
            // 替換道具圖
            img.sprite = toolsImg[toolsNum];
            // 將欄位指向下一個位置(?!)
            posNum++;
        }
        catch
        {
            // 暫放
            //print("not found");
        }
    }

    // 丟掉道具，道具換位
    public void onChangePos(string name)
    {
        // 三個道具欄位的image
        Image img1;
        Image img2;
        Image img3;

        // 丟出物品為第一欄位物品
        if (name == "Tool01")
        {
            // 暫放
            //print("tool01");

            // 取得道具欄位的image
            img1 = imgPos[0].GetComponent<Image>();
            img2 = imgPos[1].GetComponent<Image>();

            // 如果第二欄位是顯示狀態
            if (imgPos[1].activeSelf)
            {
                // 將第二欄位的圖片給第一欄位
                img1.sprite = img2.sprite;
                // 先將第二欄位隱藏
                imgPos[1].SetActive(false);
                // 將指向欄位換成第二欄位
                posNum = 1;

                // 取得道具欄位的image
                img3 = imgPos[2].GetComponent<Image>();
                // 如果第三欄位是顯示狀態
                if (imgPos[2].activeSelf)
                {
                    // 將第三欄位的圖片給第二欄位
                    img2.sprite = img3.sprite;
                    // 將第二欄位改為顯示
                    imgPos[1].SetActive(true);
                    // 將第三欄位隱藏
                    imgPos[2].SetActive(false);
                    // 指向欄位為第三欄位
                    posNum = 2;
                }
            }
            // 非顯示狀態，則表道具欄原只有一道具，丟掉唯一道具
            else
            {
                // 直接將第一欄位隱藏
                imgPos[0].SetActive(false);
                // 指向欄位為第一欄位
                posNum = 0;
            }
        }

        // 丟出物品為第二欄位物品
        if (name == "Tool02")
        {
            // 暫放
            //print("tool02");

            // 取得道具欄位的image
            img2 = imgPos[1].GetComponent<Image>();
            img3 = imgPos[2].GetComponent<Image>();

            // 如果第三欄位是顯示狀態
            if (imgPos[2].activeSelf)
            {
                // 將第三欄位的圖片給第二欄位
                img2.sprite = img3.sprite;
                // 將第二欄位改為顯示
                imgPos[1].SetActive(true);
                // 將第三欄位隱藏
                imgPos[2].SetActive(false);
                // 指向欄位為第三欄位
                posNum = 2;
            }
            // 若第三欄位為隱藏狀態，表原有兩項道具
            else
            {
                // 將第二欄位隱藏
                imgPos[1].SetActive(false);
                // 指向第二欄位
                posNum = 1;
            }
        }

        // 丟出物品為第三欄位物品
        if (name == "Tool03")
        {
            // 暫放
            //print("tool03");

            // 將第三欄位隱藏
            imgPos[2].SetActive(false);
            // 指向第三欄位
            posNum = 2;
        }
    }
}
