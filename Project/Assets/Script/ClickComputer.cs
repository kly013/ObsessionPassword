using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickComputer : MonoBehaviour
{
    public GameObject screen;
    public GameObject folder;

    public void OnClick()
    {
        screen.SetActive(true);
    }

    public void onClickFolder()
    {
        folder.SetActive(true);
    }

    public void onClickClose()
    {
        folder.SetActive(false);
    }

    public void onClickBack()
    {
        screen.SetActive(false);
        LevelText01.isTalking = false;
    }
}
