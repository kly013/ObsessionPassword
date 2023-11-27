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
        //switch (gameobj.name)
        //{
        //    case "Book001":
        //    case "Book002":
        //    case "Book003":
        //    case "Book004":
        //    case "Book005":
        //    case "Book006":
        //    case "Book007":
        //    case "Book008":
        //    case "Book009":
        //    case "Book010":
        //    case "Book011":
        //    case "Book012":
        //        LevelController.isTakeLook = true;
        //        LevelText01.isTalking = true;
        //        GameObject gameObj = Resources.Load<GameObject>(gameobj.name);
        //        GameObject rotateobj = Instantiate(gameObj, objPos);
        //        gameobj.SetActive(false);
        //        backText.SetActive(true);
        //        rotate.enabled = true;
        //        rotate.RotateObj(rotateobj, gameobj);
        //        break;
        //}

        GameObject gameObj = Resources.Load<GameObject>(gameobj.name);
        if (gameObj != null)
        {
            LevelController.isTakeLook = true;
            LevelText01.isTalking = true;
            GameObject rotateobj = Instantiate(gameObj, objPos);
            gameobj.SetActive(false);
            choseText.SetActive(true);
            rotate.enabled = true;
            rotate.RotateObj(rotateobj, gameobj);
        }
    }
}
