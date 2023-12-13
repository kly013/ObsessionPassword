using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic02 : MonoBehaviour
{
    public Light spotlight;
    int times = 0;

    public GameObject ghost;

    public void GameLogic(GameObject obj)
    {
        if (LevelController02.selectName == "FlashLight" && LevelController02.clickName == "Battery")
        {
            spotlight.enabled = true;
            times++;
            obj.SetActive(false);
            spotlight.intensity = spotlight.intensity + times;
            LevelController02.isPower = true;
            ghost.SetActive(true);
        }
    }
}
