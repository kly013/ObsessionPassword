using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static float gameTimer = 0;
    public static int levelnum = 1;

    void Start()
    {
        gameTimer = 0;
    }

    void Update()
    {
        gameTimer += Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Z))
        {
            LevelText01.isTalking = true;
        }
    }
}
