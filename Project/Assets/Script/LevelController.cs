using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static float gameTime = 0;

    void Start()
    {
        
    }

    void Update()
    {
        gameTime += Time.deltaTime;
    }
}
