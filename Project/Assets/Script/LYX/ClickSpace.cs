using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSpace : MonoBehaviour
{
    // ��ܮ�
    public GameObject DialogueBG;
    // ���ťճB
    public GameObject clickSpace;

    public void onClick()
    {
      
        if (!LevelController.isClickComputer && !LevelController.isTakeLook && !RayScript.isReading)
        {
           LevelText01.isTalking = false;
        }
        DialogueBG.SetActive(false);
        clickSpace.SetActive(false);

    }
}
