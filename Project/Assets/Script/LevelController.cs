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

    void Start()
    {
        gameTimer = 0;
    }

    void Update()
    {
        gameTimer += Time.deltaTime;
    }
}
