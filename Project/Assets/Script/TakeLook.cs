using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeLook : MonoBehaviour
{
    public Transform objPos;
    public GameObject choseText;

    public Rotate rotate;

    public void onClickCanTakeLook(GameObject gameobj)
    {
        //print(gameobj.name);
        GameObject gameObj = Resources.Load<GameObject>(gameobj.name);
        if (gameObj != null)
        {
            LevelController.isTakeLook = true;
            LevelText01.isTalking = true;
            GameObject rotateobj = Instantiate(gameObj, objPos);
            gameobj.SetActive(false);
            choseText.SetActive(true);

            if (gameobj.name == "ContactBook")
            {
                OpenBook.isContactBook = true;
            }
            else if (gameobj.name == "Diary")
            {
                OpenBook.isDiary = true;
            }
            else
            {
                print(gameobj.name);
                rotate.enabled = true;
                rotate.RotateObj(rotateobj, gameobj);
            }
        }
    }
}
