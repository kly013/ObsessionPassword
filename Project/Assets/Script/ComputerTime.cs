using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerTime : MonoBehaviour
{
    public Dropdown yearDropdown;
    public Dropdown moonDropdown;
    public Dropdown dayDropdown;

    public Text date;

    public GameObject timeWindows;

    int year;
    int moon;
    int day;

    bool isChange = false;

    void Update()
    {
        if (year == 2021 && moon == 5 && day == 27)
        {
            print("TimeFinish");
            LevelController.isFinishTime = true;
        }

        if(isChange)
        {
            isChange = false;
            timeWindows.SetActive(false);
        }
    }

    public void onClickChange()
    {
        int yearIndex = yearDropdown.value;
        string yearOption = yearDropdown.options[yearIndex].text;
        int.TryParse(yearOption, out year);

        int moonIndex = moonDropdown.value;
        string moonOption = moonDropdown.options[moonIndex].text;
        int.TryParse(moonOption, out moon);

        int dayIndex = dayDropdown.value;
        string dayOption = dayDropdown.options[dayIndex].text;
        int.TryParse(dayOption, out day);

        date.text = year + "/" + moon + "/" + day;

        isChange = true;
    }

    public void onClickCancel()
    {
        timeWindows.SetActive(false);
    }
}
