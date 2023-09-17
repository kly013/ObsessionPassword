using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static float gameTimer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        gameTimer += Time.deltaTime;
    }
}
