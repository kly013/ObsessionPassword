using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static float gameTimer = 0;
    public static int levelnum = 1;

    public static bool isChangeCamera;
    public static bool isClickComputer;
    public static bool isTakeLook;

    public static string selectName;
    public static string clickName;
    public static int taskNum = 0;
    public static bool isTask = false;

    public static bool isFinishTime;
    

    void Start()
    {
        gameTimer = 0;
    }

    void Update()
    {
        gameTimer += Time.deltaTime;

        if(Input.GetKey(KeyCode.LeftShift))
        {
            if(Input.GetKey(KeyCode.Alpha1))
            {
                selectName = "Scissors";
                clickName = "";
            }
            if(Input.GetKey(KeyCode.Alpha2))
            {
                selectName = "Scissors";
                clickName = "";
            }
            if(Input.GetKey(KeyCode.Alpha3))
            {
                selectName = "Scissors";
                clickName = "";
            }
        }
    }
}
