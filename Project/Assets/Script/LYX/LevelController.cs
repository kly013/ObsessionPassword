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
    public static bool isFinishPhoto;

    public static bool isCheatPhoto;

    public static List<GameObject> toolsList = new List<GameObject>();

    void Start()
    {
        gameTimer = 0;
        isFinishTime = false;
        isFinishPhoto = false;
    }

    void Update()
    {
        gameTimer += Time.deltaTime;

        if(Input.GetKey(KeyCode.LeftShift))
        {
            if(Input.GetKey(KeyCode.Alpha1))
            {
                selectName = "Scissors";
                clickName = "PhotoDog";
            }
            if(Input.GetKey(KeyCode.Alpha2))
            {
                selectName = "PhotoCutDog";
                clickName = "Paste";
            }
            if(Input.GetKey(KeyCode.Alpha3))
            {
                isCheatPhoto = true;
            }
        }
    }
}
