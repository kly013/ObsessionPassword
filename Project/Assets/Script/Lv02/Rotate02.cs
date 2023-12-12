using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate02 : MonoBehaviour
{
    float speed = 3f;

    float axisX;
    float axisY;

    GameObject rotateObj;
    GameObject gameObj;
    public GameObject DialogueBG;
    public GameObject choseText;

    public BagController02 bagController02;

    bool isEnter = true;

    void Update()
    {
        if (!isEnter)
        {
            if (Input.GetMouseButton(0))
            {
                axisX = -Input.GetAxis("Mouse X");
                axisY = Input.GetAxis("Mouse Y");
                rotateObj.transform.Rotate(new Vector3(0, axisX * speed, axisY * speed), Space.World);
            }
        }
        else
        {
            if (Input.GetMouseButtonUp(0))
            {
                isEnter = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DialogueBG.SetActive(false);
            gameObj.SetActive(true);
            choseText.SetActive(false);
            LevelController02.isTakeLook = false;
            LevelText02.isTalking = false;
            this.enabled = false;
            Destroy(rotateObj);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (BagController.posNum <= 2)
            {
                //print(BagController.posNum);
                DialogueBG.SetActive(false);
                choseText.SetActive(false);
                bagController02.addTools(rotateObj);
                LevelController.isTakeLook = false;
                LevelText01.isTalking = false;
                this.enabled = false;
                Destroy(rotateObj);
            }
        }
    }

    public void RotateObj(GameObject rotateobj, GameObject gameobj)
    {
        rotateObj = rotateobj;
        gameObj = gameobj;
    }
}
