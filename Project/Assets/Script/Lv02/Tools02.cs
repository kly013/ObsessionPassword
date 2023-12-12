using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools02 : MonoBehaviour
{
    GameObject gameObj;
    public GameObject DialogueBG;
    public GameObject choseText;

    public BagController02 bagController02;

    bool isEnter = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DialogueBG.SetActive(false);
            gameObj.SetActive(true);
            choseText.SetActive(false);
            LevelController02.isTakeLook = false;
            LevelText02.isTalking = false;
            this.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (BagController.posNum <= 2)
            {
                //print(BagController.posNum);
                DialogueBG.SetActive(false);
                choseText.SetActive(false);
                //bagController02.addTools(rotateObj);
                LevelController.isTakeLook = false;
                LevelText01.isTalking = false;
                this.enabled = false;
            }
        }
    }

    public void RotateObj(GameObject gameobj)
    {
        //rotateObj = rotateobj;
        gameObj = gameobj;
    }
}
