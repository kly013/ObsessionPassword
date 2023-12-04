using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public GameObject objImg;
    public Sprite[] imgs;

    bool isPaste = false;

    public void GameLogic(string name)
    {
        if (LevelController.selectName == "Scissors" && LevelController.clickName == "PhotoDog")
        {
            imgChange(0);
        }

        if (LevelController.selectName == "PhotoCutDog" && LevelController.clickName == "Paste")
        {
            isPaste = true;
            imgChange(1);
        }

        if (LevelController.selectName == "PhotoCutDog" && isPaste && LevelController.clickName == "Photo2020")
        {
            imgChange(2);
        }
    }

    void imgChange(int num)
    {
        objImg.SetActive(true);
        Sprite sp = objImg.GetComponent<Sprite>();
        sp = imgs[num];
    }
}
