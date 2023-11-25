using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSpace : MonoBehaviour
{
    // 對話框
    public GameObject DialogueBG;
    // 按空白處
    public GameObject clickSpace;

    public void onClick()
    {
        LevelText01.isTalking = false;
        DialogueBG.SetActive(false);
        clickSpace.SetActive(false);
    }
}
