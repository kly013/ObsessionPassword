using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSpace02 : MonoBehaviour
{
    // ��ܮ�
    public GameObject DialogueBG;
    // ���ťճB
    public GameObject clickSpace;

    public void onClick()
    {
        LevelText02.isTalking = false;
        DialogueBG.SetActive(false);
        clickSpace.SetActive(false);
    }
}
