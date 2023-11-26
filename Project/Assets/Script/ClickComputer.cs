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
        LevelController.isClickComputer = true;
        GetComponent<ComputerBack>().enabled = true;
    }

    public void onClickFolder()
    {
        folder.SetActive(true);
    }

    public void onClickClose()
    {
        folder.SetActive(false);
    }
}
