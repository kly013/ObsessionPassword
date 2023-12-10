using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickComputer : MonoBehaviour
{
    public GameObject screen;
    public GameObject folder;
    public GameObject timeWindows;

    public Text timeHour;
    public Text timeMin;

    int sec = 0;
    int min = 0;
    int hr = 0;

    public void OnClick()
    {
        screen.SetActive(true);
        LevelController.isClickComputer = true;
        GetComponent<ComputerBack>().enabled = true;
        Timer();
    }

    public void onClickFolder()
    {
        folder.SetActive(true);
    }

    public void onClickClose()
    {
        folder.SetActive(false);
    }

    public void Timer()
    {
        timeWindows.SetActive(true);
        sec = (int)LevelController.gameTimer % 60;
        min = (int)LevelController.gameTimer / 60;
        hr = min / 60;

        if (min < 10)
        {
            timeMin.text = "0" + min;
        }
        else
        {
            timeMin.text = min.ToString();
        }

        if (hr < 10)
        {
            timeHour.text = "0" + hr;
        }
        else
        {
            timeHour.text = hr.ToString();
        }
    }
}
