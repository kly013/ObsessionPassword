using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public GameObject objImg;
    public Sprite[] imgs;

    public GameObject clickCellphone;

    bool isPaste = false;

    float waitTime = 5;
    float curTime;
    bool isFirst = true;

    public static bool notChange = false;
    public static bool isElectrified = false;

    public void GameLogic(string name)
    {
        if (LevelController.selectName == "Scissors" && LevelController.clickName == "PhotoDog"
             || LevelController.clickName == "Scissors" && LevelController.selectName == "PhotoDog")
        {
            imgChange(0);
        }

        if (LevelController.selectName == "PhotoCutDog" && LevelController.clickName == "Paste")
        {
            isPaste = true;
            imgChange(1);
        }

        if (LevelController.selectName == "PhotoCutDog" && isPaste && LevelController.clickName == "Photo")
        {
            // print("FinishPhoto");
            imgChange(2);
            LevelController.isFinishPhoto = true;
        }

        if(LevelController.isCheatPhoto)
        {
            // print("FinishPhoto");
            imgChange(2);
            LevelController.isFinishPhoto = true;
        }

        if (LevelController.selectName == "Charger" && LevelController.clickName == "Cellphone")
        {
            if (isFirst)
            {
                notChange = true;
                curTime = LevelController.gameTimer;
                isFirst = false;
            }
            else if (LevelController.gameTimer - curTime < waitTime)
            {
            }
            else
            {
                LevelController.isClickCellphone = true;
                isElectrified = true;
                clickCellphone.SetActive(true);
            }
        }
    }

    void imgChange(int num)
    {
        LevelController.isTask = true;
        objImg.SetActive(true);
        Image img = objImg.GetComponent<Image>();
        img.sprite = imgs[num];
        LevelText01.isTalking = true;
    }
}
