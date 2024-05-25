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
        GameObject gameObj = Resources.Load<GameObject>(gameobj.name);
        if (gameObj != null)
        {
            LevelController.isTakeLook = true;
            LevelText01.isTalking = true;
            GameObject rotateobj = Instantiate(gameObj, objPos);

            // �ȩ�
            //print(gameobj.gameObject.name);

            gameobj.SetActive(false);
            choseText.SetActive(true);

            rotate.enabled = true;
            rotate.RotateObj(rotateobj, gameobj);
        }
    }
}
