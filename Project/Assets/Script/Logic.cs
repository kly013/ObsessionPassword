using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    public GameObject objImg;
    public GameObject[] obj;

    public Sprite[] toolsImg;
    public GameObject[] imgPos;

    bool isPaste = false;

    public void GameLogic(string name)
    {
        if (LevelController.selectName == "Scissors" && LevelController.clickName == "PhotoDog")
        {
            //Instantiate(obj[0], pos);
        }

        if (LevelController.selectName == "PhotoCutDog" && LevelController.clickName == "Paste")
        {
            //Instantiate(obj[1], pos);
            isPaste = true;
        }

        if (LevelController.selectName == "PhotoCutDog" && isPaste)
        {
            //Instantiate(obj[2], pos);
        }
    }
}
