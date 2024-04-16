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
    public static int min = 0;
    public static int hr = 0;

    int accelerate = 2;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            LevelController.gameTimer *= accelerate;
        }
        if (LevelController.gameTimer >= 86400)
        {
            LevelController.gameTimer = 0;
        }
        Timer();
    }

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

    public void Timer()
    {
        //print(LevelController.gameTimer);
        sec = (int)LevelController.gameTimer % 60;
        min = (int)LevelController.gameTimer / 60;
        hr = min / 60 + 13;

        if (min < 10)
        {
            timeMin.text = "0" + min;
        }
        else
        {
            if (min > 59)
            {
                min = min % 60;
            }
            timeMin.text = min.ToString();
        }

        if (hr < 10)
        {
            timeHour.text = "0" + hr;
        }
        else
        {
            if (hr > 23)
            {
                hr = hr % 24;
            }
            timeHour.text = hr.ToString();
        }
    }

    public void onClickTime()
    {
        timeWindows.SetActive(true);
    }
}
